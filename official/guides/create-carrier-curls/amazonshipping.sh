curl -X POST https://api.easypost.com/v2/carrier_accounts \
  -u "$EASYPOST_API_KEY": \
  -H 'Content-Type: application/json' \
  -d '{
  "carrier_account": {
    "type": "AmazonShippingAccount",
    "description": "AmazonShippingAccount",
    "credentials": {
      "account_number": "VALUE",
      "partner_oauth_url": "VALUE",
      "refresh_token": "VALUE"
    }
  }
}'
