using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choise = 1;
            AddressBookService addressbookService = new AddressBookService();
            Console.WriteLine("##################-AddressBook-#####################");
            Console.WriteLine();

            do
            {
                Console.WriteLine("\nYou can choose from following:");
                Console.WriteLine(" __________________________________________________________________________________");
                Console.WriteLine("|                  |           |             |             |           |           |");
                Console.WriteLine("| New Address [1]. | Read [2]. | UpDate [3]. | Delete [4]. | Find [5]. | Exit [0]. | ");
                Console.WriteLine("|__________________|___________|_____________|_____________|___________|___________|");
                Console.WriteLine("");
                Console.Write("Choose: ");
                Console.WriteLine("");
                if (byte.TryParse(Console.ReadLine(), out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            AddressBook newaddress = new AddressBook();
                            Console.WriteLine("___________________New Address_________________________");

                            Console.Write("Enter The ID:");
                            newaddress.ID = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            newaddress.Name = Console.ReadLine();

                            Console.Write("Enter Surname: ");
                            newaddress.Surname = Console.ReadLine();

                            Console.Write("Enter Phone Number:(0)");
                            newaddress.Phonenumber = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter Email: ");
                            newaddress.Email = Console.ReadLine();

                            Console.Write("Enter Address: ");
                            newaddress.Address = Console.ReadLine();

                            addressbookService.New(newaddress);
                            Console.WriteLine("\nNew Address added successfully!");

                            break;

                        case 2:

                            AddressBook[] addressBooks = addressbookService.Read();
                            Console.WriteLine("___________________Read_________________________");

                            for (int i = 0; i < addressBooks.Length; i++)
                            {
                                Console.WriteLine($"ID:{addressBooks[i].ID}|     Name: {addressBooks[i].Name},  Surname: {addressBooks[i].Surname},  Phone Number: 0{addressBooks[i].Phonenumber}, Email: {addressBooks[i].Email}, Address: {addressBooks[i].Address}");
                            }
                            break;

                        case 3:

                            Console.WriteLine("___________________UpDate_________________________");

                            foreach (var item in addressbookService.Read())
                            {
                                Console.WriteLine($"ID:{item.ID}|     Name: {item.Name},  Surname: {item.Surname},  Phone Number: 0{item.Phonenumber}, Email: {item.Email}, Address: {item.Address}");
                            }
                            Console.Write("Choose ID: ");
                            int AddressId = Convert.ToInt32(Console.ReadLine());
                            AddressBook addressbook = addressbookService.Find(AddressId);

                            Console.Write($"Ente new name({addressbook.Name}): ");
                            addressbook.Name = Console.ReadLine();

                            Console.Write($"Ente new Surname({addressbook.Surname}): ");
                            addressbook.Surname = Console.ReadLine();

                            Console.Write($"Ente new Phone number(0{addressbook.Phonenumber}):(0)");
                            addressbook.Phonenumber = Convert.ToDouble(Console.ReadLine());

                            Console.Write($"Ente new Email({addressbook.Email}): ");
                            addressbook.Email = Console.ReadLine();

                            Console.Write($"Ente new Address({addressbook.Address}): ");
                            addressbook.Address = Console.ReadLine();

                            addressbookService.UpDate(AddressId, addressbook);

                            Console.WriteLine("UpDated successfully!");
                            Console.WriteLine();

                            break;

                        case 4:

                            Console.WriteLine("___________________Delete_________________________");

                            AddressBook[] addressBooks1 = addressbookService.Read();

                            for (int i = 0; i < addressBooks1.Length; i++)
                            {
                                Console.WriteLine($"ID:{addressBooks1[i].ID}|     Name: {addressBooks1[i].Name},  Surname: {addressBooks1[i].Surname},  Phone Number: 0{addressBooks1[i].Phonenumber}, Email: {addressBooks1[i].Email}, Address: {addressBooks1[i].Address}");
                            }

                            Console.Write("Choose ID: ");
                            int IdForDelete = Convert.ToInt32(Console.ReadLine());
                            addressbookService.Delete(IdForDelete);

                            Console.WriteLine("Deleted successfully!");
                            break;
                        case 5:

                            Console.WriteLine("___________________Find_________________________");

                            Console.Write("Choose ID: ");

                            int IdForFind = Convert.ToInt32(Console.ReadLine());
                            AddressBook addressFind = addressbookService.Find(IdForFind);
                            Console.WriteLine($"ID:{addressFind.ID}|     Name: {addressFind.Name},  Surname: {addressFind.Surname},  Phone Number: 0{addressFind.Phonenumber}, Email: {addressFind.Email}, Address: {addressFind.Address}");

                            break;
                        case 0:
                            Console.WriteLine("Exist");
                            break;
                        default:
                            Console.WriteLine("Error: You can only select from table!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("You must enter the number from Table!");
                    Console.WriteLine();
                    choise = 1;
                }
            } while (choise != 0);
        }
    }
}
