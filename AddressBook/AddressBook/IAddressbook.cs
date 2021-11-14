using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    interface IAddressbook
    {
        AddressBook New(AddressBook addressBook);
        AddressBook UpDate(int id, AddressBook addressBook);
        AddressBook Find(int id);
        AddressBook[] Read();
        bool Delete(int id);

    }
}
