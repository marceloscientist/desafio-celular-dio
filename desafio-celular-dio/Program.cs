using desafio_celular_dio.Inheritance;
using desafio_celular_dio.Model;

class Program
{
    static void Main()
    { 
        SmartPhone nokiaPhone = new Nokia("Nokia","G60","11969895248","1236635463653",2);
        nokiaPhone.Ligar();
        nokiaPhone.InstalarAplicativo("WhatsApp");
        nokiaPhone.Ligar();
        nokiaPhone.EnviarMensagem("Isso é um Samsung!");
        nokiaPhone.TirarFoto();
        
        Console.WriteLine();

        SmartPhone iPhone = new IPhone("iPhone", "15", "47995874521","987653563574321",4);
        iPhone.Ligar();
        iPhone.InstalarAplicativo("Instagram");
        iPhone.EnviarMensagem("Enviando com iMessage!");
        iPhone.TirarFoto();

        Console.WriteLine();
    }
}