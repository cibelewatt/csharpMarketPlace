using System;

namespace marketPlace
{
    public class Menu
    {
        private int ids = 0;

        public string GeneralMenu()
        {
            Console.WriteLine("Bem vindo ao sistema de marketplace");
            Console.WriteLine("Observe o menu e escolha o número da opção desejada");
            Console.WriteLine("01 - Cadastrar Novo Usuário");
            Console.WriteLine("02 - Sou um usuário, quero ser Vendedor");
            Console.WriteLine("03 - Sou um usuário, quero ser Cliente");
            Console.WriteLine("04 - Sair");
            Console.Write("Opção: ");
            return Console.ReadLine();
        }

        public void Option(int _option)
        {
            switch (_option)
            {
                case 1:
                    var user = new User();
                    user.Id = ids++;
                    user.CreateUser(user);
                    GeneralMenuOption();
                    break;
                case 2:
                    var seller = new Seller();
                    seller.Id = ids++;
                    seller.CreateSeller(seller);
                    GeneralMenuOption();
                    break;
                case 3:
                    var client = new Client();
                    client.Id = ids++;
                    client.CreateClient(client);
                    GeneralMenuOption();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opção Inválida, tente novamente");
                    GeneralMenuOption();
                    break;
            }
        }

        public void GeneralMenuOption()
        {
            string _option = GeneralMenu();
            int _optionInt;
            bool _optionToInt = Int32.TryParse(_option, out _optionInt);
            if (_optionToInt)
                Option(_optionInt);
            else
                Option(0);
        }
    }
}