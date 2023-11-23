namespace desafio_celular_dio.Model;

public abstract class SmartPhone
{
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    protected string IMEI { get; set; }
    protected int Memoria { get; set; }
    
    public string Marca { get; set; }

    public abstract void InstalarAplicativo(string nome);
 
    public SmartPhone(string marca, string modelo, string numero, string imei, int memoria)
    {
        Marca = marca;
        Modelo = modelo;
        Numero = numero;
        IMEI = imei; 
        Memoria = memoria;
    }

    public virtual void Ligar()
    {
        Console.WriteLine($"O celular {Marca} {Modelo} está ligando.");
    }

    public virtual void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando mensagem: {mensagem}");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine($"{Modelo} está recebendo uma ligação...");
    }
    
    public virtual void TirarFoto()
    {
        Console.WriteLine($"Tirando foto com o celular {Marca} {Modelo}.");
    }
}