curl -X POST https://api.easypost.com/v2/shipments \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
    "shipment": {}
  }'
