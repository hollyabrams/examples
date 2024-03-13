require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

retrieved_user = client.user.retrieve_me

user = client.user.update(retrieved_user.id, name: 'New Name')

puts user
