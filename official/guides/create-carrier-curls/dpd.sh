curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "DpdAccount",
  "description": "DpdAccount",
  "carrier_account": {
    "credentials": {
      "customer_number": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    },
    "test_credentials": {
      "customer_number": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
