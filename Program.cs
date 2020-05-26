using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone samsung = new Smartphone();
            samsung.tamanho = 2800;
            samsung.modelo = "Galaxy S20";
            samsung.cor = "Preto";
            samsung.on = false;

            
            Console.WriteLine("Bem vindo ao seu Smartphone!");
            Menu:
            Console.WriteLine("O que deseja fazer?  (1, 2, 3, 4)");
            Console.WriteLine("1. Ligar o celular");
            Console.WriteLine("2. Fazer uma ligação");
            Console.WriteLine("3. Enviar uma mensagem");
            Console.WriteLine("4. Desligar o celular");
            string answer = Console.ReadLine();
            if (answer == "1" ){
                Console.WriteLine(samsung.Ligado());
                goto Menu;
            }
            if (answer == "2"){
                Console.WriteLine(samsung.Ligação());
                goto Menu;
            }
            if (answer == "3"){
                Console.WriteLine(samsung.Mensagem());
                goto Menu;
            }
            if (answer == "4"){
                Console.WriteLine(samsung.Desligado());
            }
        }
    }
}
