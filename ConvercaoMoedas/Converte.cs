using ConversaoMoedas;
using System;

class Converte
{
    static void Main()
    {
        Conversor moeda = new Conversor();

        Console.WriteLine("Qual Valor Deseja Converter:");
        var valorReal = Convert.ToDecimal(Console.ReadLine());
        moeda.SetaValor(valorReal);

        Console.WriteLine($"Deseja converter o valor de R$ {moeda.ValorMoeda}:\n\n1.Dólar\n2.Euro\n3.Iene\n4.Libra esterlina");
        var response = Convert.ToInt32(Console.ReadLine());

        switch (response)
        {
            case 1:
                moeda.ValorDolar(valorReal);
                break;
            case 2:
                moeda.ValorEuro(valorReal);
                break;
            case 3:
                moeda.ValorIene(valorReal);
                break;
            case 4:
                moeda.ValorLibra(valorReal);
                break;
            default:
                Console.WriteLine("Opção Inválida. Selecione Novamente");
                break;
        }
        Console.ReadLine();
    }
}