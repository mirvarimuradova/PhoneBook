using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.DataAccess
{
    public class BusinessLogicLayer
    {

        private DataLogicLayer dll;

        public BusinessLogicLayer()
        {
            this.dll = new DataLogicLayer();
        }

        public void CheckContact(Contact contact)
        {
            if (contact.Name != null &&
                contact.Phone != null )
            {
                dll.AddContact(contact);
            }
            else
            {
                throw new ArgumentException();
            }
                
        }
    }
}
