using System;

namespace marketPlace
{
    public class User : ICreate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public User CreateUser(User usuario)
        {
            Console.WriteLine("Nome: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Nome de usuario (letras minusculas, sem espaco): ");
            this.UserName = Console.ReadLine();
            Console.WriteLine("Senha: ");
            this.Password = Console.ReadLine();
            this.WriteObjectString();
            return this;
        }

        public void WriteObjectString()
        {
            Console.WriteLine(this.Name + " " + this.UserName + " " + this.Password);
        }

    }
}