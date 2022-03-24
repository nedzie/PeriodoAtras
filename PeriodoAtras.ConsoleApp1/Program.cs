using System;

namespace PeriodoAtras.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data datas = new();
            TimeSpan dias = new TimeSpan();
<<<<<<< HEAD
            datas.dateHoje = DateTime.Now;
            datas.dataInformada = DateTime.Parse("25/03/2022 17:00:00");
=======
           datas.dateHoje = DateTime.Now;
            datas.dataInformada = DateTime.Parse("10/03/2022");
>>>>>>> 2ca9ec86e1f39cdf2418564f8ae67f4f2a1fcad9
            dias = datas.dateHoje - datas.dataInformada;
            Console.WriteLine(datas.Mensagem(dias));
            Console.ReadKey();
        }
    }
}