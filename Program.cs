using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(99) 99999-9999", modelo: "Redmi Note 8", imei: "54645546464652", memoria: 128);
Console.WriteLine($"Número: {nokia.Numero}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "(88) 88888-8888", modelo: "Redmi Note 9S", imei: "6546546545466", memoria: 128);
Console.WriteLine($"Número: {iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");