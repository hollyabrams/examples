curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "DhlParcelAccount",
    "description": "DhlParcelAccount",
    "credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "user_id": "VALUE"
    },
    "test_credentials": {
      "account_number": "VALUE",
      "api_key": "VALUE",
      "user_id": "VALUE"
    }
  }
}'
