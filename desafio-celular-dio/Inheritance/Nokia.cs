using desafio_celular_dio.Model;

namespace desafio_celular_dio.Inheritance;

public class Nokia: SmartPhone
{
    public Nokia(string marca, string modelo, string numero, string imei, int memoria) : base(marca, modelo, numero, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} em um Nokia...");
    }
    public override void TirarFoto()
    {
        Console.WriteLine($"Tirando foto com o celular {Marca} {Modelo} com câmera avançada.");
    }
}