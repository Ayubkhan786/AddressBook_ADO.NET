CREATE DATABASE AddressBook



SELECT Name
FROM sys.databases;

USE AddressBook


CREATE TABLE AddressBook
(
	FirstName	varchar(50),
	LastName	varchar (50),
	Address		varchar(150),
	City		varchar(25),
	State		varchar(25),
	zip			BigInt,
	PhoneNumber BigInt,
	Email		varchar(50)
	)


INSERT INTO AddressBook([FirstName] ,[LastName],[Address] ,[City],[State],[zip],[PhoneNumber],[Email])
	
Values ('Ayub','khan','Dindigul','Dindigul','TN',561775,9887512345,'Ayubkhan@gmail.com'),
			('Vijay','kumar','gandhi maidan','Patna','Bihar', 856475,965431287,'vijya87348@gmail.com'),
			('Abhi','sri','colony','gurgaon','New Delhi',369342,897894234,'Abi@gmail.com'),
			('Nithish','mehta','Nagar','Hyd','Maharashtra',534342,9874564234,'Nitmeh@gmail.com')
		   

UPDATE AddressBook Set  LastName = 'Khanna' WHERE FirstName = 'Vijay' ;

DELETE From AddressBook WHERE FirstName = 'Abhi';
	
	SELECT * FROM AddressBook 


SELECT * From AddressBook WHERE City = 'Dindigul';
SELECT * From AddressBook WHERE State = 'Maharashtra';


SELECT COUNT(City)  From AddressBook WHERE City = 'Dindigul';
SELECT COUNT(State) From AddressBook WHERE State = 'TN';



SELECT * FROM AddressBook WHERE City = 'Dindigul'
Order by FirstName ASc; 


ALTER TABLE AddressBook ADD Type varchar(30);
SELECT * FROM Addressbook;

UPDATE AddressBook Set Type = 'Friend' WHERE FirstName = 'Ayub' or FirstName = 'Nithish' ;
UPDATE AddressBook Set Type = 'Family' WHERE FirstName = 'Vijay';
SELECT * From Addressbook WHERE Type = 'Friend';

SELECT COUNT (Type) From Addressbook WHERE Type = 'Friend';
