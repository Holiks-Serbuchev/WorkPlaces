# How to work with
## How install project:
Before getting started, you need to download the project.
  With this command:
 ```
 git clone https://github.com/Holiks-Serbuchev/WorkPlaces.git
 cd WorkPlaces
 dotnet build
 dotnet run
 ```
 ## User Manual:
When a new user enters the site for the first time. He sees the authorization interface:
The authorization interface includes:
  * Multiple input fields for entering login and password;
  * And there are also several buttons.
    * When the user clicks on the "Sign In" button, the site will be logged in if the data entered by the user is correct;
    * When clicking on the "Sing Up" button, the user is redirected to the registration page.
   
![alt text](https://media.discordapp.net/attachments/592433653683060761/893112954294239263/Opera.png?width=1310&height=676)
   
When the user clicks the "Sign Up" button, the user will be redirected to the registration page.

The registration interface includes:
* Multiple input fields for entering the recorded data;
* As well as several buttons.
    * By clicking on the "Back" button, the user will be redirected to the authorization page;
    * Clicking on the "Register" button will register the user and he will be redirected to the table reservation page.

![alt text](https://media.discordapp.net/attachments/592433653683060761/893234034686165023/2.png?width=1310&height=676)

When the user clicks on "Sign Up" on the authorization page, he will be taken to the table reservation page.

The table booking interface includes:
* Multiple buttons to navigate through pages;
    * When you click on the "Workplace device" button, you are redirected to the device editing page;
    * When you click on the "Roles" button, you are redirected to the role editing page;
    * When you click on the "Reservation table" button, you are redirected to the table reservation page;
    * When you click on the "Tables" button, you are redirected to the table editing page.
* There is also an input field for the date on the page. By default, today's date is set;
* The page also displays tables that the user can book. When you select a table, the "To book" button will appear. When you click on it, your table will be booked for you for the time you have chosen.
* When you click on the "To book" or "View" button, a list of devices will also appear where you can select the devices you need after selecting, click the "Edit devices" and the change of devices will take effect.

![alt text](https://media.discordapp.net/attachments/592433653683060761/893241608928133216/1.png?width=1315&height=676)

When the user clicks the "Roles" button, it will be redirected to the role editing page.

The role editing interface includes:
* One drop-down list that contains all the data that can be changed or deleted;
* One input field for adding or changing data;
* There are also several buttons.
    * When you click on the "Add" button, data will be added to the database. To use this button, you need to fill in the input field;
    * When you click on the "Update" button, the data in the database will change. To use this button, you need to fill in the input field and also select the desired value in the drop-down list that the user wants to change;
    * When you click on the "Delete" button, the data in the database will be deleted. To use this button, select the desired value in the drop-down list that the user wants to delete.

![alt text](https://media.discordapp.net/attachments/592433653683060761/893248122686418974/3.png?width=1330&height=676)

When the user clicks the "Workplace device" button, it will be redirected to the devices editing page.

The device editing interface includes:
* One drop-down list that contains all the data that can be changed or deleted;
* One input field for adding or changing data;
* There are also several buttons.
    * When you click on the "Add" button, data will be added to the database. To use this button, you need to fill in the input field;
    * When you click on the "Update" button, the data in the database will change. To use this button, you need to fill in the input field and also select the desired value in the drop-down list that the user wants to change;
    * When you click on the "Delete" button, the data in the database will be deleted. To use this button, select the desired value in the drop-down list that the user wants to delete.

![alt text](https://media.discordapp.net/attachments/592433653683060761/893251121492135936/4.png?width=1332&height=676)

When the user clicks the "Tables" button, he will be redirected to the tables editing page.

The table editing interface includes:
* Several drop-down lists containing data from the database;
* Multiple date entry fields. They are used to select the booking period;
* As well as several buttons.
    * When you click on the "Add" button, the data will be added to the database. To use this button, you need to select the necessary values in the drop-down lists and select a specific period;
    * When you click on the "Update" button, the data will be changed in the database. To use this button, you need to select the necessary values from the drop-down lists and select a specific period;
    * When you click on the "Delete" button, the data in the database will be deleted. To use this button, the user needs to select the desired value from the top drop-down list that the user wants to delete.

![alt text](https://media.discordapp.net/attachments/592433653683060761/893256208562143232/5.png?width=1312&height=676)
