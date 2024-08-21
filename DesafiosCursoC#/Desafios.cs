using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafiosCursoC_
{
    internal class Desafios
    {

        public void PrimeiroDesafio() {

            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Olá, " + nome + "! Seja muito bem-vindo!");
        }

        public void SegundoDesafio()
        {
            Console.Write("Informe seu primeiro nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe seu sobrenome: ");
            string sobrenomeNome = Console.ReadLine();

            string nomeCompleto = nome + " " + sobrenomeNome;

            Console.WriteLine("Nome completo: " + nomeCompleto);
        }

        public void TerceiroDesafio()
        {
            Console.Write("Informe o primeiro numero: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double somaDosNumeros = primeiroNumero + segundoNumero;
            double subtracaoDosNumeros = primeiroNumero - segundoNumero;
            double multiplicacaoDosNumeros = primeiroNumero * segundoNumero;
            double mediaDosNumeros = (primeiroNumero + segundoNumero) / 2;
            
            Console.WriteLine("Soma: " + somaDosNumeros);
            Console.WriteLine("Subtração: " + subtracaoDosNumeros);
            Console.WriteLine("Multiplicação: " + multiplicacaoDosNumeros);

            if (segundoNumero == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            else
            {
                Console.WriteLine("Divisão: " + primeiroNumero / segundoNumero);
            }

            Console.WriteLine("Media: " + mediaDosNumeros);



        }

        public void QuartoDesafio()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();


            Console.WriteLine("Quantidade de caracteres que a palavra inserida tem: " + palavra.Length);
        }

        public void QuintoDesafio()
        {
            Console.Write("Informe a placa do veiculo: ");
            string placa =  Console.ReadLine();

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("ERRO: Informe uma placa para ser verificada.");
                return;
            }

            placa = placa.ToUpper().Trim();

            string padraoAntigo = @"^[A-Z]{3}\d{4}$";

            string padraoMercosul = @"^[A-Z]{3}\d{1}[A-Z]{1}\d{2}$";

            bool placaValida = Regex.IsMatch(placa, padraoAntigo) || Regex.IsMatch(placa, padraoMercosul);

            string msgRetorno = placaValida ? "válida" : "não é válida";

            Console.WriteLine("A placa é: " + msgRetorno);

        }

        public void SextoDesafio()
        {
            DateTime dataAtual = DateTime.Now;

            // Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)
            Console.Write("Data completa:");
            Console.WriteLine(dataAtual.ToString("dddd, dd/MM/yyyy HH:mm:ss"));

            // Apenas a data no formato "01/03/2024"
            Console.Write("Apenas a data:");
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

            // Apenas a hora no formato de 24 horas
            Console.Write("Apenas a hora (formato 24 horas):");
            Console.WriteLine(dataAtual.ToString("HH:mm:ss"));

            // A data com o mês por extenso
            Console.Write("Data com o mês por extenso:");
            Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy 'às' HH:mm:ss"));
        }
    }
}
