import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

webhook = client.webhook.create(url="example.com")

print(webhook)
