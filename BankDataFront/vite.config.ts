import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [vue()],
  server: {
    proxy:{
      '/getFiles' :{
        target: 'https://localhost:8080',
        changeOrigin: true,
        secure: false,
        ws: false,
      }},
    port: 8081,
    host: '0.0.0.0'
  },
  build: {
    // generate manifest.json in outDir
    manifest: true,
    rollupOptions: {
      // make sure to externalize deps that shouldn't be bundled
      // into your library
      external: ['vue'],
      output: {
        // Provide global variables to use in the UMD build
        // for externalized deps
        globals: {
          vue: 'Vue'
        }
      }
    }
  },
})
