/// <reference types="vite/client" />

interface ImportMetaEnv {
    readonly VITE_API_VERSION: string
    readonly DEV: boolean
    readonly VITE_API_BASE_URL: string
}

interface ImportMeta {
    readonly env: ImportMetaEnv
}
