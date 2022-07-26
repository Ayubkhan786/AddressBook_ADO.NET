using AddressBook_ADO.NET;

Console.WriteLine("Welcome to AddressBook ");

AddressBook Book = new AddressBook();
//Book.RetrieveAll();
//Book.AddContact();
//Book.AddDate();
//Book.UpdateDate();
Book.RetrieveFromDate();