import easypost


easypost.api_key = "EASYPOST_API_KEY"

shipment = easypost.Shipment.retrieve("shp_...")

shipment.get_smartrates()

print(shipment)
