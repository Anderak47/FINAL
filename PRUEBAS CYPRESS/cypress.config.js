const { defineConfig } = require("cypress");

module.exports = defineConfig({
  env: {
     base_url: 'https://localhost:7023'
  },
  e2e: {
    setupNodeEvents(on, config) {
     
    },
  },
});
