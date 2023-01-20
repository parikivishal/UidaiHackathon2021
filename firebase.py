import pyrebase

t=4

config={
	"apiKey": "AIzaSyAxbjMu9tlLAQnNCqQZXyXiztlU-ffLqc4",
    "authDomain": "kitsw-raspberry.firebaseapp.com",
    "databaseURL": "https://kitsw-raspberry-default-rtdb.firebaseio.com",
    "projectId": "kitsw-raspberry",
    "storageBucket": "kitsw-raspberry.appspot.com",
    "messagingSenderId": "963587724803",
    "appId": "1:963587724803:web:b9cfeaa5df852dfc88e036",
    "measurementId": "G-F90Z7R7NX7"
};
firebase=pyrebase.initialize_app(config)
storage=firebase.storage()
database=firebase.database()
database.child("Temparature")
data={"key1":t}
database.set(data)
print('Success')