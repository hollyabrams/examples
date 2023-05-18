require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

webhook = client.webhook.retrieve('hook_...')

success = client.webhook.delete(webhook.id)

puts success
