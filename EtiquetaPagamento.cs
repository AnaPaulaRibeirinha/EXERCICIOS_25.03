using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIOS_25_03
{
    public class EtiquetaPagamento
    {
        static void Main(string[] args)
        {
            double precoEtiqueta, precoFinal;
            string opcaoPagamento;

            Console.Write("Digite o preco de etiqueta do produto: ");
            precoEtiqueta = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a opcao de pagamento: ");
            Console.WriteLine("a) A vista em dinheiro ou cheque");
            Console.WriteLine("b) A vista no cartao de credito");
            Console.WriteLine("c) Em duas vezes, preco normal de etiqueta sem juros");
            Console.WriteLine("d) Em duas vezes, preco normal de etiqueta mais juros de 10%");
            Console.WriteLine("================================================================");
            opcaoPagamento = Console.ReadLine();

            switch (opcaoPagamento)
            {
                case "a":
                    precoFinal = precoEtiqueta * 0.9;
                    Console.WriteLine($"Preco final: R${precoFinal:F2}");
                    break;
                case "b":
                    precoFinal = precoEtiqueta * 0.85;
                    Console.WriteLine($"Preco final: R${precoFinal:F2}");
                    break;
                case "c":
                    precoFinal = precoEtiqueta;
                    Console.WriteLine($"Preco final: R${precoFinal:F2}");
                    break;
                case "d":
                    precoFinal = precoEtiqueta * 1.1;
                    Console.WriteLine($"Preco final: R${precoFinal:F2}");
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }
        }
    }
}
