import {defineConfig, loadEnv} from 'vite';
import {TanStackRouterVite} from '@tanstack/router-plugin/vite'
import preact from '@preact/preset-vite';
import fs from 'fs';
import path from 'path';
import child_process from 'child_process';

// https://vitejs.dev/config/
export default defineConfig(({ mode }) => {
  // Load env file based on `mode` in the current directory.
  // Set the third parameter to '' to load all env regardless of the `VITE_` prefix.
  const envVars = loadEnv(mode, process.cwd(), '');
  
  // Check if we're in production mode
  const isProd = mode === 'production';
  
  // Certificate setup for development only
  const baseFolder =
    envVars.APPDATA !== undefined && envVars.APPDATA !== ''
      ? `${envVars.APPDATA}/ASP.NET/https`
      : `${envVars.HOME}/.aspnet/https`;
      
  const certificateName = "dormo.client";
  const certFilePath = path.join(baseFolder, `${certificateName}.pem`);
  const keyFilePath = path.join(baseFolder, `${certificateName}.key`);
  
  // Only create certificates in development mode
  if (!isProd) {
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
  }
  
  // API version from environment variable or default
  const apiVersion = envVars.VITE_API_VERSION || '/api/v1.0';
  
  // Target API URL - different for dev and prod
  const target = isProd 
    ? envVars.VITE_API_BASE_URL || 'https://dormo.azurewebsites.net'
    : envVars.ASPNETCORE_HTTPS_PORT ? `https://localhost:${envVars.ASPNETCORE_HTTPS_PORT}` :
      envVars.ASPNETCORE_URLS ? envVars.ASPNETCORE_URLS.split(';')[0] : 'https://localhost:7164';
      
  return {
    plugins: [
      preact(),
      TanStackRouterVite({target: 'react', autoCodeSplitting: true})
    ],
    resolve: {
      alias: {
        '@': path.resolve(__dirname, './src'),
      }
    },
    define: {
      // Make additional environment variables available to the client
      'import.meta.env.VITE_API_VERSION': JSON.stringify(apiVersion),
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
  };
});
