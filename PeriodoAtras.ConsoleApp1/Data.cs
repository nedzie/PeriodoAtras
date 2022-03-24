using System;

namespace PeriodoAtras.ConsoleApp1
{
    public partial class Data
    {
        public DateTime dateHoje;
        public DateTime dataInformada;

        public string Mensagem(TimeSpan dias)
        {
            if (dias.TotalDays < 0)
                return ($"Futuro?");
            if (dias.TotalDays < 1)
            {
                if (dias.TotalMinutes < 60 && dias.TotalSeconds > 60)
                {
                    return ($"{dias.TotalMinutes % 60:F0} minutos atrás");
                }
                else if (dias.TotalSeconds < 60)
                {
                    return ($"{dias.TotalSeconds % 60:F0} segundos atrás");
                }
                return ($"{dias.Hours % 24} horas atrás");
            }
            if (dias.Days < 7)
            {
                IntParaStringDias dia = (IntParaStringDias)dias.Days;
                if (dias.Days > 1)
                {
                    return ($"{dia} dia atrás");
                }
                else
                    return ($"{dia} dias atrás");
            }
            else if (dias.Days >= 7 && dias.Days < 30)
            {
                IntParaStringDias semanas;
                IntParaStringDias dia = (IntParaStringDias)(dias.Days % 7);
                if (dias.Days / 7 == 2)
                    semanas = (IntParaStringDias)Enum.Parse(typeof(IntParaStringDias), "duas");

                else
                    semanas = (IntParaStringDias)(dias.Days / 7);

                if (dias.Days / 7 == 0)
                {
                    return ($" {semanas} semana(s) atrás");
                }
                return ($"{semanas} semana(s) e {dia} dia(s) atrás");
            }
            else if (dias.Days >= 30 && dias.Days < 360)
            {
                IntParaStringDias dia = (IntParaStringDias)(((dias.Days % 30) % 7));
                IntParaStringDias semanas;
                IntParaStringDias meses = (IntParaStringDias)(dias.Days / 30);

                if ((dias.Days % 30) / 7 == 2)
                    semanas = (IntParaStringDias)Enum.Parse(typeof(IntParaStringDias), "duas");

                else
                    semanas = (IntParaStringDias)(dias.Days / 7);

                if ((dias.Days % 30) / 7 == 0)
                {
                    if ((dias.Days % 30) / 7 == 0)
                    {
                        return ($"{meses} mes(es) atrás");
                    }
                    return ($"{meses} mes(es) e {semanas} semana(s) atrás");
                }

                return ($"{meses} mese(s) e {semanas} semana(s) e {dia} dia(s) atrás");
            }
            else if (dias.Days >= 360)
            {
                IntParaStringDias dia = (IntParaStringDias)(((dias.Days % 360) / 30 % 7));
                IntParaStringDias semanas = (IntParaStringDias)((dias.Days % 360) % 30 / 7);
                IntParaStringDias meses = (IntParaStringDias)(dias.Days % 360 / 30);
                IntParaStringDias anos = (IntParaStringDias)(dias.Days / 360);

                if ((dias.Days % 360) % 30 / 7 == 2)
                    semanas = (IntParaStringDias)Enum.Parse(typeof(IntParaStringDias), "duas");

                else
                    semanas = (IntParaStringDias)((dias.Days % 360) % 30 / 7);

                if ((dias.Days % 360) / 30 % 7 == 0 && (dias.Days % 360) % 30 / 7 == 0 && (dias.Days % 360 / 30) == 0)

                    return ($"{anos} ano(s) atrás");

                else if ((dias.Days % 360) / 30 % 7 == 0 && (dias.Days % 360) % 30 / 7 == 0)
                    return ($"{anos} ano(s) e {meses} mese(s) atrás");
                else if ((dias.Days % 360) / 30 % 7 == 0)
                    return ($"{dia} ano(s) e {meses} mese(s) e {semanas} semana(s) atrás");

                return ($"{anos} ano(s) e {meses} mese(s) e {semanas} semana(s) e {dia} dia(s) atrás");
            }
            return "";
        }
    }
}