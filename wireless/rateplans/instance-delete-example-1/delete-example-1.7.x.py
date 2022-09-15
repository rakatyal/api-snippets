# Download the Python helper library from twilio.com/docs/python/install
import os
from twilio.rest import Client

# required for all twilio access tokens
# To set up environmental variables, see http://twil.io/secure
account_sid = os.environ['TWILIO_ACCOUNT_SID']
auth_token = os.environ['TWILIO_AUTH_TOKEN']

client = Client(account_sid, auth_token)

ratePlanDeleted = client.wireless \
    .rate_plans('WPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA') \
    .delete()

print(ratePlanDeleted)