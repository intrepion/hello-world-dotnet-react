const { defineConfig } = require("cypress");

module.exports = defineConfig({
  e2e: {
    baseUrl: 'https://127.0.0.1:44459',
    setupNodeEvents(on, config) {
      // implement node event listeners here
    },
  },
});
