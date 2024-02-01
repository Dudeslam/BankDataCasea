USE BankDataCaseDev

Create TABLE Account (
AccountID int NOT NULL Primary key,
FirstName int NOT NULL,
SurName int,
Balance int
);


INSERT INTO Account (AccountID, FirstName, SurName, Balance)
	VALUES(1, 'Peter', 'Dinklage', 500000),
			(2, 'Peter', 'Dinklage', 25000),
			(3, 'Sam', 'Jackson', 47100),
			(4, 'Leonardo', 'Decap', 200000000),
			(5, 'Sam', 'Smith', 3250192);


Create TABLE Transactions (
ProviderID int NOT NULL Unique FOREIGN KEY REFERENCES Account(AccountID),
TransactionID int NOT NULL,
ReceiverID int,
Amount int,
Modified date
);


INSERT INTO Transactions(ProviderID, TransactionID, ReceiverID, Amount, Modified)
	VALUES(1, 23, 2, 500, CURRENT_TIMESTAMP),
			(1, 25, 3, 250, CURRENT_TIMESTAMP),
			(3, 82, 4, 470, CURRENT_TIMESTAMP),
			(4, 27, 5, 200, CURRENT_TIMESTAMP),
			(2, 48, 5, 350, CURRENT_TIMESTAMP),
			(1, 203, 5, 1000, CURRENT_TIMESTAMP),
			(4, 123, 3, 500, CURRENT_TIMESTAMP),
			(5, 58, 1, 3750, CURRENT_TIMESTAMP);