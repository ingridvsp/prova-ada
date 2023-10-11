using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System;
using System.Text;
using System.Globalization;


namespace Prova
{
  class Program
  {
    static void Main()
    {
      // Questão #01
      // Console.WriteLine("Digite 5 numeros");
      // int[] numbers = new int[5];

      // int perValues = 0;
      // int nonPerValues = 0;
      // int positiveValues = 0;
      // int negativeValues = 0;

      // for (int i = 0; i < numbers.Length; i++)
      // {
      //   bool validValue = false;
      //   while (!validValue)
      //   {
      //     Console.WriteLine($"Digite o {i + 1}° valor: ");
      //     if (int.TryParse(Console.ReadLine(), out numbers[i]))
      //     {
      //       Console.WriteLine(numbers[i]);
      //       validValue = true;
      //     }
      //     else
      //     {
      //       Console.WriteLine("Por favor insira um valor valido");
      //     };

      //   };
      // };

      // foreach (int number in numbers)
      // {
      //   if (number % 2 == 0)
      //   {
      //     perValues++;
      //   }
      //   else
      //   {
      //     nonPerValues++;
      //   }

      //   if (number < 0)
      //   {
      //     negativeValues++;
      //   }
      //   else if (number > 0)
      //   {
      //     positiveValues++;
      //   }
      // }
      // Console.WriteLine($"A quantidade de numeros pares é{perValues}");
      // Console.WriteLine($"A quantidade de numeros impares é{nonPerValues}");
      // Console.WriteLine($"A quantidade de numeros Positivos é{positiveValues}");
      // Console.WriteLine($"A quantidade de numeros Negativos é{negativeValues}");


      //Questão #02
      // bool firstValueValid = false;
      // bool secondValueValid = false;
      // // Enquanto a variavel N1 nao for valida, continue rodando
      // while (!firstValueValid)
      // {
      //   Console.Write("Digite o primeiro número (N1): ");
      //   if (int.TryParse(Console.ReadLine(), out int n1))
      //   {
      //     //Se a variavel N1 for valida, mude a firstValueValid para true, para que o primeiro while pare
      //     firstValueValid = true;
      //     //enquanto a variavel N2 for invalida, continue perguntando
      //     while (!secondValueValid)
      //     {
      //       Console.Write("Digite o segundo número (N2): ");
      //       if (int.TryParse(Console.ReadLine(), out int n2))
      //       {
      //         //Se a variavel N2 for valida, mude a secondValueValid para true, para que o segundo while pare
      //         secondValueValid = true;
      //         //variavel que vai definir o valor da multiplicacao
      //         int multiplicacao = 0;
      //         //variavel que vai definir o valor da divisao inteira
      //         int divisaoInteira = 0;

      //         // Calculando a multiplicação
      //         // Metodo Math.Abs pega o valor absoluto de um numero, ou seja, a distancia dele ate zero
      //         // Ex: o valor absoluto de -5 é 5
      //         // o valor absoluto de 10 é 10
      //         for (int i = 0; i < Math.Abs(n2); i++)
      //         {
      //           multiplicacao += Math.Abs(n1);
      //         }

      //         // Verificando o sinal do resultado da multiplicação
      //         // Se N1 for maior que zero e N2 for menor que 0
      //         // OU 
      //         // Se N1 for menor que zero e N2 for maior que 0
      //         // esse IF vai inverter o sinal da multiplicacao
      //         if ((n1 > 0 && n2 < 0) || (n1 < 0 && n2 > 0))
      //         {
      //           multiplicacao = -multiplicacao;
      //         }

      //         // Calculando a divisão inteira
      //         int absN1 = Math.Abs(n1);
      //         int absN2 = Math.Abs(n2);
      //         //Enquanto valor absoluto de N1 for maior ou igual ao valor absoluto de N2
      //         // O valor absoluto de N1 deve ser subtraido pelo valor absoluto de N2
      //         // E a divisao inteira deve somar mais 1
      //         while (absN1 >= absN2)
      //         {
      //           absN1 -= absN2;
      //           divisaoInteira++;
      //         }
      //         // Verificando o sinal do resultado da divisão inteira
      //         // Se N1 for maior que zero e N2 for menor que 0
      //         // OU 
      //         // Se N1 for menor que zero e N2 for maior que 0
      //         // esse IF vai inverter o sinal da divisao
      //         if ((n1 > 0 && n2 < 0) || (n1 < 0 && n2 > 0))
      //         {
      //           divisaoInteira = -divisaoInteira;
      //         }

      //         Console.WriteLine($"Multiplicação: {multiplicacao}");
      //         Console.WriteLine($"Divisão Inteira: {divisaoInteira}");
      //       }
      //       else
      //       {
      //         Console.WriteLine("Digite um valor valido para N2");
      //       }
      //     }

      //   }
      //   else
      //   {
      //     Console.WriteLine("Digite um valor valido para N1");
      //   }
      // }

      //Questão#03
      // Cria uma variavel para verificar se a frase eh valida
      bool validPhrase = false;
      // Enquanto a frase nao for valida, continue rodando
      while (!validPhrase)
      {
        // Para tratar Exececoes
        try
        {
          Console.WriteLine("Digite uma frase");

          //Transforma uma frase em um array baseado em espaco em branco
          string[] items = Console.ReadLine().Split(' ');
          // Variavel responsavel por contar paravas maiusculas
          int upperWords = 0;
          // Variavel responsavel por contar paravas minusculas
          int lowerWords = 0;
          // Variavel responsavel por contar paravas que comecam com maiusculas
          int upperBegin = 0;
          // Variavel responsavel por contar paravas que comecam com minusculas
          int lowerBegin = 0;
          // Variavel responsavel por contar quantas palavras possue a frase
          int wordsQuantity = items.Length;
          //para cada palavra da frase, sera feita uma repeticao
          foreach (string item in items)
          {
            //Remove acentos das letras
            string itemNormalized = item.Normalize(NormalizationForm.FormD);
            //Funcao All vai verificar se cada uma das letras esta maiuscula
            if (itemNormalized.All(char.IsUpper))
            {
              //Adiciona +1 para cada palavra maiuscula
              upperWords++;
            }
            //Funcao All vai verificar se cada uma das letras esta minuscula
            else if (itemNormalized.All(char.IsLower))
            {
              //Adiciona +1 para cada palavra minuscula
              lowerWords++;
            }
            //Funcao IsUpper vai verificar se a primeira letra e maiuscula
            if (char.IsUpper(itemNormalized[0]))
            {
              //Adiciona +1 para cada palavra com a primeira letra maiuscula
              upperBegin++;
            }
            //Funcao IsUpper vai verificar se a primeira letra e minuscula
            else if (char.IsLower(itemNormalized[0]))
            {
              //Adiciona +1 para cada palavra com a primeira letra minuscula
              lowerBegin++;
            }
          }
          //torna o validPhrase true para parar o loop do while
          validPhrase = true;

          Console.WriteLine($"A quantidade de palavras maiusculas é {upperWords}");
          Console.WriteLine($"A quantidade de palavras minusculas é {lowerWords}");
          Console.WriteLine($"A quantidade de palavras que comecam com letra maiuscula é {upperBegin}");
          Console.WriteLine($"A quantidade de palavras que comecam com letra minuscula é {lowerBegin}");
          Console.WriteLine($"A quantidade de palavras é {wordsQuantity}");
        }
        catch (Exception)
        {
          // Solicita que o usuario digite pelo menos uma palavra
          Console.WriteLine("Por favor, digite pelo menos uma frase");
        }
      }


      //Questão 04
      //Resposta - Letra C
      //justificativa: O resultado de Convert.ToInt16(!(21 > 21)) retornará 1 porque a expressão 21 > 21 é avaliada
      // como false, e a negação ! inverte o valor booleano para true. Como resultado, ! (21 > 21) é true, que é 
      //equivalente a 1 quando convertido para um valor inteiro.

      //Questão 05
      //Resposta - Letra D
      //justificativa:Ele irá fazer quatro loops, no primeiro ele ira verificar se -5 é menor que 7, e irá executar o Console.WriteLine, depois irá somar +3, sendo então i = -2, ele irá verificar se -2 < 7, e irá executar o Console.WriteLine, e irá somar +3, sendo então i = 1, então ele irá verificar se 1 < 7, E irá executar o Console.WriteLine, e irá somar +3, tornando entao i = 4, então ele irá verificar se 4 < 7, e irá executar o Console.WriteLine, e irá somar +3, sendo então i = 7, ele irá verificar se 7 < 7, sendo falso, ele não irá mais executar o loop.

    }
  }
}


