using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketPlace
{
    public class Address
    {
        public string MainAdress { get; set; }

        public string SecondAddress { get; set; }

        public int Number { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        //public Address(string mainAddress,
        //              string secondAddress,
        //              int number,
        //              string zip, string city, string state, string country)
        //{
        //    MainAdress = mainAddress;
        //    SecondAddress = secondAddress;
        //    Number = number;
        //    ZipCode = zip;
        //    City = city;
        //    State = state;
        //    Country = country;

        //}

        public Address CreateAddress(Address address)
        {
            Console.WriteLine("Logradouro: ");
            this.MainAdress = Console.ReadLine();
            Console.WriteLine("Complemento: ");
            this.SecondAddress = Console.ReadLine();
            Console.WriteLine("Numero: ");
            this.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CEP: ");
            this.ZipCode = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            this.City = Console.ReadLine();
            Console.WriteLine("Estado: ");
            this.State = Console.ReadLine();
            Console.WriteLine("País: ");
            this.Country = Console.ReadLine();
            return this;
        }

        
    }
}