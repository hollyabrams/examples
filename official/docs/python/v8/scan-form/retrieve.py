import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

scan_form = client.scan_form.retrieve("sf_...")

print(scan_form)
