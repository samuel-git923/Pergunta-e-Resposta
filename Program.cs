using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Qual é o site que possui um ótimo conteúdo sobre programação";
            p.Resposta = "https://www.dfilitto.com.br";
            p.Dica = "O mantenedor do site é Danilo Filitto";

            Console.WriteLine("Tente adivinhar a pergunta: ");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.Write("Resposta: ");
            String resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabéns!!! Você Acertou.");
            }
            else
            {
                Console.WriteLine("Que Pena!!! Você errou.");
                Console.WriteLine("A resposta correta é: " + p.Resposta);
            }

            Console.ReadKey();
        }
    }
}
