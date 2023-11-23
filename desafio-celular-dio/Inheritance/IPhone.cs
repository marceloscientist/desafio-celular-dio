using desafio_celular_dio.Model;

namespace desafio_celular_dio.Inheritance;

public class IPhone: SmartPhone
{
    public IPhone(string marca, string modelo, string numero, string imei, int memoria) : base(marca, modelo, numero, imei, memoria)
    {
    }
    
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} em um iPhone...");
    }

    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando mensagem com iMessage: {mensagem}");
    }
}