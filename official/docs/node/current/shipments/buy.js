const EasyPostClient = require('@easypost/api');

const client = new EasyPostClient('EASYPOST_API_KEY');

(async () => {
  const retrievedShipment = await client.Shipment.retrieve('shp_...');

  const shipment = await client.Shipment.buy(
    retrievedShipment.id,
    retrievedShipment.lowestRate(),
    249.99,
  );

  console.log(shipment);
})();
