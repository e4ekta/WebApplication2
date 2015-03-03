# WebApplication2
This project implements user authentication in Visual Studio 2013
The API is already available in VS. 
This project makes the API available for use, and makes a user interface to make calls to the API.
The file scripts/apps.js provides the code for user interface and API call structure.

This project works on Visual Studio 2013 for Web
- Download the zip file and extract on your PC. 
- Open the project file.
- Select the we browser and press F5
- The API interface opens on the web browser
- Press F12 to open network settings

Register:
- enter email id
- enter a password : 8 letters, capitals, lowercase, numbers, special characters must all be used
- press register
- status should show Done! for successful store, else shows error code
- network call should show  a Register POST call

Login:
- enter email id and password
- press login
- status should show email id for successful store, else shows error code
- network call should show  a Token POST call
