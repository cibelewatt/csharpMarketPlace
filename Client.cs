using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketPlace
{
    public class Client : User, ICreateClient
    {
        public Address DeliveryAddress { get; set; }
        public Address BillingAddress { get; set; }
        public DateTime BirthDate { get; set; }

        public void CreateClient(Client client)
        {
            Console.WriteLine($"Ok! Vamos criar um cadastro para você poder comprar?");
            Console.WriteLine("Nome: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Nome de usuario (letras minusculas, sem espaco): ");
            this.UserName = Console.ReadLine();
            Console.WriteLine("Senha: ");
            this.Password = Console.ReadLine();
            Console.WriteLine("Data de Nascimento: ");
            this.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ok! Vamos agora ao endereço de entrega. ");
            var deliveryaddress = new Address();
            this.DeliveryAddress = deliveryaddress.CreateAddress(deliveryaddress);
            Console.WriteLine("Falta só um pouqinho... Vamos ao endereco de cobranca! ");
            var billingaddress = new Address();
            this.BillingAddress = billingaddress.CreateAddress(billingaddress);


        }
    }
}
