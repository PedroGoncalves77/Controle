using System.Diagnostics.Tracing;

namespace ControleDeMaterial;

internal class Revisao
{
    public Revisao()
    {
        Dia = DateTime.Now;
    }
    public DateTime DiaDeRevisar { get; set; }
    private DateTime Dia { get; set; }
    public Boolean IsDay { get
        {
            if (Dia == DiaDeRevisar) { return true; }
            else
            { return false; }
        }
        }
    public DateTime ProximaRevisao(int dias) 
    {
        DiaDeRevisar = Dia.AddDays(dias);
        return DiaDeRevisar;
    }

}

