/// <reference types="vite/client" />

interface ImportMetaEnv {
    readonly VITE_API_VERSION: string
    readonly VITE_DEV: boolean
    readonly VITE_API_BASE_URL: string
    readonly VITE_NODE_ENV: string
}

interface ImportMeta {
    readonly env: ImportMetaEnv
}
