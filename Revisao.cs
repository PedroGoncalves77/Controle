namespace ControleDeMaterial;

public class Revisao
{
    public DateTime DiaDeRevisar;
    private DateTime Dia = DateTime.Now;
    public void ProximaRevisao(int dias)  => DiaDeRevisar = Dia.AddDays(dias);
}

