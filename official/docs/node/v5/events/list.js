const Easypost = require('@easypost/api');

const api = new Easypost('EASYPOST_API_KEY');

api.Event.all({
  page_size: 5,
}).then(console.log);
