using System;

namespace CalculadoraSimples {
    internal class Program {
        public static void Main() {

            bool continuar = true;

            while (continuar) {
                //Pergunta inicial ao usuario
                Console.WriteLine("O que deseja fazer ?");
                Console.WriteLine("Soma (DIGITE 1)");
                Console.WriteLine("Subtração (DIGITE 2)");
                Console.WriteLine("Multiplicação (DIGITE 3)");
                Console.WriteLine("Divisão (DIGITE 4)");
                Console.WriteLine("Porcentagem (DIGITE 5)");

                //Lendo e armazenando o que o usuario digitou
                int op = int.Parse(Console.ReadLine());

                //Se caso o número escolhido for o 1 | soma
                switch (op) {

                    case 1:
                        double soma;

                        Console.WriteLine("Você escolheu a soma!");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Digite um número:");
                        //Ler e armazenar o primeiro número escolhido pelo usuario
                        double num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        //Ler e armazenar o segundo número escolhido pelo usuario
                        double num2 = double.Parse(Console.ReadLine());

                        //Realizando a soma
                        soma = num1 + num2;

                        //Mostrando o total na tela
                        Console.WriteLine($"O resultado da soma é: {soma:F2}");
                        continuar = false;
                        break;

                    case 2:
                        double sub;

                        Console.WriteLine("Você escolheu a subtração!");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Digite um número:");
                        //Ler e armazenar o primeiro número escolhido pelo usuario
                        double num3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        //Ler e armazenar o segundo número escolhido pelo usuario
                        double num4 = double.Parse(Console.ReadLine());

                        //Realizando a subtração
                        sub = num3 - num4;

                        //Mostrando o total na tela
                        Console.WriteLine($"O resultado da subtração é: {sub:F2}");
                        continuar = false;
                        break;

                    case 3:
                        double mult;

                        Console.WriteLine("Você escolheu a multiplicação!");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Digite um número:");
                        //Ler e armazenar o primeiro número escolhido pelo usuario
                        double num5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        //Ler e armazenar o segundo número escolhido pelo usuario
                        double num6 = double.Parse(Console.ReadLine());

                        //Realizando a multiplicação
                        mult = num5 * num6;

                        //Mostrando o total na tela
                        Console.WriteLine($"O resultado da multiplicação é: {mult:F2}");
                        continuar = false;
                        break ;

                    case 4:
                        double div;

                        Console.WriteLine("Você escolheu a divisão!");
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Digite um número:");
                        //Ler e armazenar o primeiro número escolhido pelo usuario
                        double num7 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        //Ler e armazenar o segundo número escolhido pelo usuario
                        double num8 = double.Parse(Console.ReadLine());

                        //Realizando a divisão
                        div = num7 / num8;

                        //Mostrando o total na tela
                        Console.WriteLine($"O resultado da divisão é: {div:F2}");
                        continuar = false;
                        break;

                    case 5:
                        double por;

                        Console.WriteLine("Você escolheu a porcentagem!");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Digite a porcentagem escolhida:");
                        //Ler e armazenar o primeiro número escolhido pelo usuario
                        double num9 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite um número:");
                        //Ler e armazenar o segundo número escolhido pelo usuario
                        double num10 = double.Parse(Console.ReadLine());

                        //Realizando a porcentagem
                        por = (num9 / 100) * num10;

                        //Mostrando o total na tela
                        Console.WriteLine($"O resultado da porcentagem é: {por:F2}");
                        continuar = false;
                        break;

                    default:
                        //Caso o usuario escolha nenhuma das opções
                        Console.WriteLine("Escolha uma das opções por favor!");
                        break;
                }   
                    

            } 
            
        }
    }
}