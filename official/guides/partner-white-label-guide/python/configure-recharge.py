import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

user = client.user.retrieve_me()

updated_user = client.user.update(user.id, recharge_threshold="50.00")

print(updated_user)
