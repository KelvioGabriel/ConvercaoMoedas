using ConvercaoMoedas;
using System;
using System.Globalization;

namespace ConversaoMoedas
{
    public class Conversor : Moedas
    {
        public Conversor() { }

        public Conversor(decimal valor)
        {
            ValorMoeda = valor;
        }

        public void ValorDolar(decimal valor)
        {
            ValorMoeda = valor / 5.30m;
            Console.WriteLine(ValorMoeda.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }

        public void ValorEuro(decimal valor)
        {
            ValorMoeda = valor / 5.76m;
            Console.WriteLine(ValorMoeda.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
        }

        public void ValorIene(decimal valor)
        {
            ValorMoeda = valor / 0.034m;
            Console.WriteLine(ValorMoeda.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
        }

        public void ValorLibra(decimal valor)
        {
            ValorMoeda = valor / 6.78m;
            Console.WriteLine(ValorMoeda.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
        }

        public void SetaValor(decimal valor)
        {
            ValorMoeda = valor;
        }
    }
}