using System;
namespace exe3_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXE - 1: Salário do Funcionário");

            int numFuncionario;
            int horasTrabalhadas;
            double salarioPorHora;

            Console.WriteLine("Insira o número do funcionário:");
            numFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas trabalhadas pelo funcionário:");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o salário deste funcionário por hora:");
            salarioPorHora = double.Parse(Console.ReadLine());

            double salarioFinal = horasTrabalhadas * salarioPorHora;

            Console.WriteLine("O salário final do funcionário " + numFuncionario + " é igual à: R$" + salarioFinal.ToString("F2"));



            Console.WriteLine("\nEXE - 2: Valor da peça");

            int codigoPeca1 = 101;
            int codigoPeca2 = 404;

            Console.WriteLine("Insira o código da peça");
            int codigoPecaInserido = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de peças: ");
            int numeroPecas = int.Parse(Console.ReadLine());

            if (codigoPecaInserido == codigoPeca1)
            {
                Console.WriteLine("Insira o valor da peça 1");
                double valorUnitario = double.Parse(Console.ReadLine());

                double valorPagar = valorUnitario * numeroPecas;
                Console.WriteLine("O valor à pagar referente às: " + numeroPecas + " peças do tipo: Peça - 1 é igual à: R$" + valorPagar);
            }
            else if (codigoPecaInserido == codigoPeca2)
            {
                Console.WriteLine("Insira o valor da peça 2");
                double valorUnitario = double.Parse(Console.ReadLine());

                double valorPagar = valorUnitario * numeroPecas;
                Console.WriteLine("O valor à pagar referente às: " + numeroPecas + " peças do tipo: Peça - 2 é igual à: R$" + valorPagar);
            }



            Console.WriteLine("\nEXE - 3: Calculadora de Fórmulas");

            Console.WriteLine("Insira o valor A:");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor B:");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor C:");
            double C = double.Parse(Console.ReadLine());


            double areaTriangulo = A * C / 2.0;
            Console.WriteLine("\nÁrea do triângulo usando A * C / 2.0: " + areaTriangulo.ToString("F2"));

            double areaCirculo = 3.14159 * C * C;
            Console.WriteLine("\nÁrea do círculo usando PI * C * C: " + areaCirculo.ToString("F2"));

            double areaTrapezio = (A + B) / 2.0 * C;
            Console.WriteLine("\nÁrea do trapézio usando (A + B) / 2.0 * C: " + areaTrapezio.ToString("F2"));

            double areaQuadrado = B * B;
            Console.WriteLine("\nÁrea do quadrado usando B * B: " + areaQuadrado.ToString("F2"));

            double areaRetangulo = A * B;
            Console.WriteLine("\nÁrea do retângulo usando A * B: " + areaRetangulo.ToString("F2"));



            Console.WriteLine("\n---------- Lista 3.5 ----------");

            Console.WriteLine("\nEXE - 1: Login");

            Console.WriteLine("Insira seu Usuário:");
            string login = Console.ReadLine();

            Console.WriteLine("\nInsira sua senha:");
            string senha = Console.ReadLine();

            if (login == "admin" && senha == "1234")
            {
                Console.WriteLine("\nPode Acessar");
            }
            else
            {
                Console.WriteLine("Login ou Senha Incorreta");
            }


            Console.WriteLine("\nEXE - 2: Estoque de Blusas");

            Console.WriteLine("Insira a Quantitade de Blusas no Estoque:");
            int qntEstoque = int.Parse(Console.ReadLine());

            if (qntEstoque > 40)
            {
                Console.WriteLine("Estoque OK");
            }
            else if (qntEstoque > 20 && qntEstoque < 40)
            {
                Console.WriteLine("Atenção ao Estoque");
            }
            else
            {
                Console.WriteLine("Estoque Crítico");
            }


            Console.WriteLine("\nEXE - 3: Visto de Viagem");

            Console.WriteLine("Insira sua Idade:");
            int idadeVistoViagem = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu Salário:");
            double salarioVistoViagem = double.Parse(Console.ReadLine());

            if (idadeVistoViagem >= 18 && salarioVistoViagem > 2000)
            {
                Console.WriteLine("\nPode viajar");
            }
            else
            {
                Console.WriteLine("\nNão pode Viajar");
            }


            Console.WriteLine("\nEXE - 4: Votação de Aula");

            Console.WriteLine("Vote na Aula do Mês: \nOs votos 1 e 2 são para: Desenho e Pintura; \nOs votos 3 e 4 são para Discurso e Debate; \nOutros Valores de Voto são para Dança.");

            Console.WriteLine("\nInsira seu Voto:");
            int voto = int.Parse(Console.ReadLine());

            if (voto == 1 || voto == 2)
            {
                Console.WriteLine("Desenho e Pintura");
            }
            else if (voto == 3 || voto == 4)
            {
                Console.WriteLine("Discurso e Debate");
            }
            else
            {
                Console.WriteLine("Dança");
            }


            Console.WriteLine("\nEXE - 5: Valor de 100");

            Console.WriteLine("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor > 0 && valor > 100)
            {
                Console.WriteLine("Valor Especial");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }
        }
    }
}
