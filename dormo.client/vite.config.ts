import {defineConfig} from 'vite';
import {TanStackRouterVite} from '@tanstack/router-plugin/vite'
import preact from '@preact/preset-vite';
import fs from 'fs';
import path from 'path';
import child_process from 'child_process';
import {env} from 'process';

const baseFolder =
    env.APPDATA !== undefined && env.APPDATA !== ''
        ? `${env.APPDATA}/ASP.NET/https`
        : `${env.HOME}/.aspnet/https`;

const certificateName = "dormo.client";
const certFilePath = path.join(baseFolder, `${certificateName}.pem`);
const keyFilePath = path.join(baseFolder, `${certificateName}.key`);

if (!fs.existsSync(baseFolder)) {
    fs.mkdirSync(baseFolder, {recursive: true});
}

if (!fs.existsSync(certFilePath) || !fs.existsSync(keyFilePath)) {
    if (0 !== child_process.spawnSync('dotnet', [
        'dev-certs',
        'https',
        '--export-path',
        certFilePath,
        '--format',
        'Pem',
        '--no-password',
    ], {stdio: 'inherit',}).status) {
        throw new Error("Could not create certificate.");
    }
}

const apiVersion = env.API_VERSION || '/api/v1.0';
const isProd = process.env.NODE_ENV === 'production';
const target = isProd 
    ? env.VITE_API_BASE_URL || 'https://dormo.azurewebsites.net'
    : env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
      env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'https://localhost:7164';

export default defineConfig({
    plugins: [preact(),
        TanStackRouterVite({target: 'react', autoCodeSplitting: true})],
    resolve: {
        alias: {
            '@': path.resolve(__dirname, './src'),
        }
    },
    server: {
        proxy: {
            [apiVersion]: {
                target,
                secure: false,
                changeOrigin: true
            }
        },
        port: 52333,
        https: !isProd ? {
            key: fs.readFileSync(keyFilePath),
            cert: fs.readFileSync(certFilePath),
        } : undefined
    }
})
