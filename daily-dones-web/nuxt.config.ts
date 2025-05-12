// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  modules: ['nuxtjs-naive-ui'],
  nitro: {
    replace: {
      // replace the browser detection in a server lib
      'globalThis.navigator': 'undefined',
      'global.navigator': 'undefined',
    },
  },
  devtools: { enabled: true },
  build: {
    transpile: ['naive-ui', 'vueuc'],
  }
})