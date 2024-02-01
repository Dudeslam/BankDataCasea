# Bankdata coding Challenge
###### By: Vinh Trung Thai


This repo consists of 2 solutions. A backend .NET solution which will be the main focus of this documentation and a VueJS frontend. In This readme, a breakdown of what has been implemented and how it was implemented with its intents and purpose explained, but also what is yet to implemented and possible solutions to these shortcommings.

##Backend C# .NET Solution
The purpose of this solution is to allow the frontend to accept changes from a user and pass it the database.
The backend provides methods for creating, retrieving, updating and deleting a specific account, as well as all accounts on a database.
Furthermore it implements a method to transfer a sum of money from one account to another by by updating the current balance of the receiver and provider.
To keep track of transfers, a Transaction model has been added which holds data about receiver, provider, an ID for the specific transaction, the sum of transfer and the date of occurrence.

##Frontend VueJS solution
The purpose of this solution is to provide a user with an interface where they can "consume" the Account API. It should provide and easy and intuitive method to create, read, update or delete accounts as well as listing them all. However, not much has been added to frontend solution. It has mainly been stuck trying to connect with the backend due to CORS. A solution has not been found yet due to time limitation.





