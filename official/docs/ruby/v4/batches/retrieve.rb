require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

batch = EasyPost::Batch.retrieve('batch_...')

puts batch
