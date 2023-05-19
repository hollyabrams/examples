import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

user = client.user.retrieve_me()

updated_user = client.user.update(recharge_threshold="50.00")

print(updated_user)
