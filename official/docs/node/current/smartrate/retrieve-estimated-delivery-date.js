const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const estimatedDeliveryDates = await client.Shipment.retrieveEstimatedDeliveryDate(
    'shp_...',
    'YYYY-MM-DD',
  );

  console.log(estimatedDeliveryDates);
})();
