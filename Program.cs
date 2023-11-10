using DesafioPOO.Models;

Console.WriteLine("Smarthphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "tijolao", imei:"1234", memoria: 128);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("GitHub");

Console.WriteLine("------------------------------");

Smartphone iphone = new Iphone(numero: "28232393", modelo:"tudo igual", imei:"nemprecisa",memoria:88888);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("PlayStore");