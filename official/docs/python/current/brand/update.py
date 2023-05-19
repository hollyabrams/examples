import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

user = client.user.retrieve_me()

updated_brand = client.user.update_brand(color="#303F9F")

print(updated_brand)
