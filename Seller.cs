using System;

namespace marketPlace
{
    public class Seller : User

    {
        public string ThingToSell { get; set; }

        public Seller CreateSeller(Seller seller)
        {
            Console.WriteLine("Nome: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Nome de usuario (letras minusculas, sem espaco): ");
            this.UserName = Console.ReadLine();
            Console.WriteLine("Senha: ");
            this.Password = Console.ReadLine();
            Console.WriteLine("O que você quer vender? ");
            this.ThingToSell = Console.ReadLine();
            this.WriteObjectString();
            return this;
        }
    }
}