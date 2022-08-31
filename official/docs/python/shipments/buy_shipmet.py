import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

shipment = easypost.Shipment.retrieve("shp_...")

shipment.buy(
    rate="rate_...",
    insurance=249.99,
)

print(shipment)
