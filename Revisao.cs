namespace ControleDeMaterial;

public class Revisao
{

    public DateTime DiaDeRevisar;
    private DateTime Dia = DateTime.Now;
    public Boolean IsDay { get
        {
            if (Dia == DiaDeRevisar) { return true; }
            else
            { return false; }
        }
        }
    public void ProximaRevisao(int dias)  => DiaDeRevisar = Dia.AddDays(dias);





}

