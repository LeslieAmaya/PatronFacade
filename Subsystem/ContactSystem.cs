using PatronFacade.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFacade.Subsystem
{
    public class ContactSystem
    {
        public Contact CreateContact()
        {
            Console.WriteLine("Introduzca el nombre de usuario");
            string name = Console.ReadLine();
            Console.WriteLine("Introduzca el email");
            string email = Console.ReadLine();
            Console.WriteLine("Introduzca el número telefónico");
            string phone = Console.ReadLine();
            Console.WriteLine("Introduzca la contraseña");
            string password = Console.ReadLine();

            Contact contacto1 = new Contact(name, email, phone, password);
            return contacto1;
        }
    }
}
