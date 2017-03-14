(Week 4 of We Can Code It Full-Stack .NET bootcamp weekend project)

Applied learning of C#, OOP Principles (Inheritance, Polymorphism, Encapsulation, and Abstraction), and StreamWriter to 
created a single-user online banking console application. This application allowed users to view there account balances 
for three separate accounts (Checking, Reserve, and Savings), deposit or withdraw funds, and exit the program. 
After each transaction the user's information was saved to a StreamWriter file including: Date, Time, Ammount, Account, 
and New Balance. I was able to incorporate persistence as well. 

Thanks for checking out my code!
.......
Below are the instructions/project requirements from class:
.......

#Bank Account Project ##Directions You will be designing a console application to manage a client’s bank account. 
For now, the application will have only one client that is hard-coded into the system.

##Tasks ###Menu Items

 View Client Information
 View Account Balance
 Checking Account Balance
 Reserve Account Balance
 Savings Account Balance
 Deposit Funds
 Withdraw Funds
 Exit
###Checking Account Class

 Inherits Account base class
 Minimum 2 fields
 Minimum 2 properties
 Minimum 1 constructor
###Reserve Account Class

 Inherits Account base class
 Minimum 2 fields
 Minimum 2 properties
 Minimum 1 constructor
###Savings Account Class

 Inherits Account base class
 Minimum 2 fields
 Minimum 2 properties
 Minimum 1 constructor
###Objects

 Minimum 1 object instantiated from the Checking Account Class
 Minimum 1 object instantiated from the Reserve Account Class
 Minimum 1 object instantiated from the Savings Account Class
###Other Required Tasks

 Use StreamWriter to create account summary files that track transactions for each account type (each type has its own text file). 
 Files should be located in the Debug Folder and should include:
 Name of Client
 Client Account Number
 Account Type (Checking, Reserve, or Savings)
 Each transaction should be on its own line
 Each transaction should show date and time of transaction (must use DateTime Class)
 Each transaction should show a “+” for deposit and a “-” for withdrawal
 Each transaction should show the transaction amount
 Each transaction should show the new current balance after the transaction
Stretch Tasks

With the current tasks persistence is not a requirement. 
Implementing persistence with FileWriter would make the program reusable for tracking balances.

Right now this program is designed for one user. 
Giving the ability to enter a user name when the program begins would make the program useful for multiple users. 
At this point do not worry about trying to add passwords. That is outside of the scope of what we know at this point. 
Letting the users log in with only their names is less secure, but we're focused on functionality right now.
