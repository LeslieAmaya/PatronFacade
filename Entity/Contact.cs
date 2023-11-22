using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFacade.Entity
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email{ get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public Contact(string name, string email, string phone, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Password = password;
        }
        public override string ToString()
        {
            return $"Nombre de usuario {Name} \n Correo Electrónico: {Email} \n " +
                $"Numero Telefónico: {Phone} \n Contraseña: {Password}";
        }
    }
    
}
