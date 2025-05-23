const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const results = await client.SmartRate.estimateDeliveryDate({
    from_zip: '10001',
    to_zip: '10002',
    planned_ship_date: '2024-07-18',
    carriers: ['UPS'],
  });

  console.log(results);
})();
