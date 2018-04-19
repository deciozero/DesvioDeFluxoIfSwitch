using System;

namespace OperacoesCondiconais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário in-line (em linha)
            /*
            Comentário in-block(em bloco)
            */

            //declaração da variável operação. Ela será do tipo inteira
            int operacao;

            //declaração das variáveis n1 e n2.  Elas serão do tipo double
            double n1, n2;
            /* 
            Para limpar a tela de comando a cada execução, utilizaremos o comando Console.Clear();
            obs,: Clear > Limpar

             /* */
             Console.Clear();
             Console.WriteLine("Escolha uma das operações abaixo:");
             /*
             Para exibição das opções de operação, vanos usar o comando console.Writeline e, usaremos um comando de quebra de linha \n(contra-barra n
             (new line)).
             Assim, as opçoes ficarão uma abaixo da outra.
              */
              Console.WriteLine("1-soma\n2-subtrair\n3-multiplicar\n4-dividir");
              operacao = int.Parse(Console.ReadLine());
              Console.WriteLine("Digite um número:");
              n1 = double.Parse(Console.ReadLine());
              Console.WriteLine("Digite outro número:");
              n2 = double.Parse(Console.ReadLine());
              if(operacao==1)
              {
                  Console.WriteLine("O resultado da soma é: "+(n1+n2));
              }
              else if (operacao==2)
              {
                  Console.WriteLine("O resultado da subtração é: "+(n1-n2));
              }
                else if(operacao==3)
                {
                    Console.WriteLine("O resultado da multiplicação é: "+(n1*n2));
                }
                else if (operacao==4)
                {        
                Console.WriteLine("O rsultado da divisão é: "+(n1/n2));
                }
                else
                {
                    Console.WriteLine("Operação inválida!");
                }


        }
    }
}
