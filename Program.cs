using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
// Implementado!
Console.WriteLine("Testando Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16, "Android 14.0");
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\nTestando Smartphone Iphone:");
Smartphone iphone = new Iphone("987654321", "Iphone 12 Pro", "987654321", 64, "IOS 17.2.1");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");