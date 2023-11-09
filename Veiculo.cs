namespace _11;

public class Veiculo
{
    private string? placa;
    public string Placa
    {
        get{return placa??"";}
        set{placa=value;}
    }


    private string? modelo;
    public string Modelo
    {
        get{return modelo??"";}
        set{modelo=value;}
    }
    private string ?marca;
    public string Marca
    {
        get{return marca??"";}
        set{marca=value;}
    }
    private int? ano;
    public int Ano
    {
        get{return ano??0;}
        set{ano=value;}
    }
    


}
