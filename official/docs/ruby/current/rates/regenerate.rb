require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

shipment = client.shipment.regenerate_rates('shp_...')

puts shipment
