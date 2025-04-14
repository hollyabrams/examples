curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "DaiPostAccount",
    "description": "DaiPostAccount",
    "credentials": {
      "account_code": "VALUE",
      "origin_terminal": "VALUE",
      "password": "VALUE",
      "username": "VALUE"
    }
  }
}'
