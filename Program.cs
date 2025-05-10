using System;

namespace CalculadoraSimples {
    internal class Program {
        public static void Main() {

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
            if (op == 1) {

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
            } else if (op == 2) {
                double sub;

                Console.WriteLine("Você escolheu a subtração!");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Digite um número:");
                //Ler e armazenar o primeiro número escolhido pelo usuario
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                //Ler e armazenar o segundo número escolhido pelo usuario
                double num2 = double.Parse(Console.ReadLine());

                //Realizando a subtração
                sub = num1 - num2;

                //Mostrando o total na tela
                Console.WriteLine($"O resultado da subtração é: {sub:F2}");
            }else if (op == 3) {
                double mult;

                Console.WriteLine("Você escolheu a multiplicação!");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Digite um número:");
                //Ler e armazenar o primeiro número escolhido pelo usuario
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                //Ler e armazenar o segundo número escolhido pelo usuario
                double num2 = double.Parse(Console.ReadLine());

                //Realizando a multiplicação
                mult = num1 * num2;

                //Mostrando o total na tela
                Console.WriteLine($"O resultado da multiplicação é: {mult:F2}");
            }else if (op == 4) {
                double div;

                Console.WriteLine("Você escolheu a divisão!");
                Console.WriteLine("------------------------");
                Console.WriteLine("Digite um número:");
                //Ler e armazenar o primeiro número escolhido pelo usuario
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                //Ler e armazenar o segundo número escolhido pelo usuario
                double num2 = double.Parse(Console.ReadLine());

                //Realizando a divisão
                div = num1 / num2;

                //Mostrando o total na tela
                Console.WriteLine($"O resultado da divisão é: {div:F2}");
            }else if (op == 5) {
                double por;

                Console.WriteLine("Você escolheu a porcentagem!");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Digite a porcentagem escolhida:");
                //Ler e armazenar o primeiro número escolhido pelo usuario
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite um número:");
                //Ler e armazenar o segundo número escolhido pelo usuario
                double num2 = double.Parse(Console.ReadLine());

                //Realizando a porcentagem
                por = (num1 / 100) * num2;

                //Mostrando o total na tela
                Console.WriteLine($"O resultado da porcentagem é: {por:F2}");
            }else {
                Console.WriteLine("Escolha uma das opções por favor!");
                
            }
        }
    }
}