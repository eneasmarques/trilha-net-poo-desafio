using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
Smartphone.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphonne:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
Smartphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
