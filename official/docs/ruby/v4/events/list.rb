require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

events = EasyPost::Event.all(
  page_size: 5,
)

puts events
