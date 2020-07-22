using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        public static string metodo;
        public static int primeiroValorInteiro;
        public static int segundoValorInteiro;
        static void Main(string[] args)
        {
            InserirValor1();
        }


        static void InserirValor1()
        {
            Console.Write("Insira um numero (1 ou + digitos): ");
            string primeiroDigito = Console.ReadLine();



            if (int.TryParse(primeiroDigito, out primeiroValorInteiro))
            {
                EscolherMetodo();
            }
            else
            {
                Console.WriteLine("Tem de inserir numeros para fazer a conta!!");
                InserirValor1();
            }

        }

        static void EscolherMetodo()
        {
            Console.WriteLine("Escolha o tipo de conta que quer fazer (+ ; - ; * ; /)");
            metodo = Console.ReadLine();
            // + - / *
            //metodo == "+"

            // OR:  if (nome == "Iara" || nome == "Pedro")
            // AND: if (nome == "Iara" && nome == "Pedro")




            if (metodo == "+" || metodo == "-" || metodo == "*" || metodo == "/")
            {
                //
                InserirValor2();
            }

            else
            {
                Console.WriteLine("Tem de inserir o metodo que quer utilizar para a sua conta!");
                EscolherMetodo();
            }

        }
        static void InserirValor2()
        {
            Console.Write("Insira o segundo numero (1 ou + digitos): ");
            string segundoDigito = Console.ReadLine();

            if (int.TryParse(segundoDigito, out segundoValorInteiro))
            {
                ApresesentarResultado();
            }
            else
            {
                Console.WriteLine("Tem de inserir o segundo numero para puder acabar a conta!");
                InserirValor2();
            }

        }

        static void ApresesentarResultado()
        {
            int resultado = 0;

            switch (metodo)
            {
                case "+":
                    resultado = primeiroValorInteiro + segundoValorInteiro;
                    break;
                case "-":
                    resultado = primeiroValorInteiro - segundoValorInteiro;
                    break;
                case "*":
                    resultado = primeiroValorInteiro * segundoValorInteiro;
                    break;
                case "/":
                    resultado = primeiroValorInteiro / segundoValorInteiro;
                    break;
            }

            Console.WriteLine(string.Format("Resultado: {0}", resultado));
            Console.WriteLine();
            InserirValor1();

        }


    }
}
