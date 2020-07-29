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
        public static List<int> listaResultados = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo/a à minha calculadora");
            Opcoes();
        }

        static void Opcoes()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha 1: Fazer uma conta!");
            Console.WriteLine("Escolha 2: Ver resultados!");
            Console.WriteLine("Escolha 3: Sair!");
            Console.Write("Escolha: ");
            string escolha = Console.ReadLine();

            switch(escolha)
            {
                case "1":
                    InserirValor1();
                    break;
                case "2":
                    ResultadosDasContas();
                    break;
                case "3":
                    Sair();
                    break;
                default:
                    Console.WriteLine("Tem de escolher o 1 ou 2!");
                    Opcoes();
                    break;
            }
            
        }

        private static void Sair()
        {
            Environment.Exit(0);
        }

        private static void ResultadosDasContas()
        {
            Console.WriteLine("Resultados das suas contas anteriores!");

            for(int i = 0; i < listaResultados.Count; i++)
            {
                Console.WriteLine(listaResultados[i]);
            }
            Opcoes();

            //foreach (int resultado in listaResultados)
            //{
            //    Console.WriteLine(resultado);
            //}
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

            //int[] arrayInteiros = new int[4];  // array!  declaração

            /*
             * arrayInteiros[0] = 54;
             * arrayInteiros[1] = 54;
             * arrayInteiros[2] = 54;
             * arrayInteiros[3] = 54;
             * arrayInteiros[4] = 54; // DÁ ERRO!! -> Array só tem 4 posições disponíveis
             */

            // Forma de percorrer todas as posições do array
            //for (int i = 0; i < 4; i++)
            //{
            //    arrayInteiros[i] = DevolveNumeroArray();
            //}

            //List<string> listaStrings = new List<string>();
            //listaStrings.Add("trenga");

            //for (int i = 0; i < listaStrings.Count; i++)
            //{
            //    Console.WriteLine(listaResultados[i]);
            //}

            //foreach (string item in listaStrings)
            //{
            //    Console.WriteLine(item);
            //}

            ////key - value

            //Dictionary<string, string> dicionarioStrings = new Dictionary<string, string>();
            //dicionarioStrings.Add("A", "trenga");

            //dicionarioStrings.Add("c", "Acabar");
            //dicionarioStrings.Add("B", "Ananas");

            //Dictionary<int, int> dicionarionInts = new Dictionary<int, int>();
            //Dictionary<int, string> dicionarioMisto = new Dictionary<int, string>();
            

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

        static int DevolveNumeroArray()
        {
            Random rnd = new Random();
            return rnd.Next();
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

            listaResultados.Add(resultado);

            Console.WriteLine(string.Format("Resultado: {0}", resultado));
            Console.WriteLine();
            Opcoes();

        }


    }
}
