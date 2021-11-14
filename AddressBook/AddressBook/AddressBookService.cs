using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookService : IAddressbook
    {
        private AddressBook[] addressBooks = new AddressBook[0];
        public bool Delete(int id)
        {
            addressBooks = Array.FindAll(addressBooks, e => e.ID != id);
            return true;
        }

        public AddressBook Find(int id)
        {
            AddressBook FindAddress = Array.Find(addressBooks, e => e.ID == id);
            return FindAddress;
        }

        public AddressBook New(AddressBook addressBook)
        {
            Array.Resize(ref addressBooks, addressBooks.Length + 1);
            addressBooks[addressBooks.Length - 1] = addressBook;
            return addressBook;
        }

        public AddressBook[] Read()
        {
            return this.addressBooks;
        }

        public AddressBook UpDate(int id, AddressBook addressBook)
        {
            AddressBook UpDateAdress = Array.Find(addressBooks, e => e.ID == id);
            UpDateAdress = addressBook;
            return UpDateAdress;
        }
    }
}
