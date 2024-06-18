curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "type": "FlexportAccount",
  "description": "FlexportAccount",
  "carrier_account": {
    "credentials": {
      "api_key": "VALUE"
    }
  }
}'
