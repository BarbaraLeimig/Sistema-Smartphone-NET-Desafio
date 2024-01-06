using DesafioPOO.Models;

// Instaciando o objeto nokia a partir da classe Nokia
Console.WriteLine("Teste Smartphone Nokia:\n");
Nokia nokia = new Nokia(numero: "+55 81 98765 - 4321", modelo: "Nokia C01 Plus", imei: "123456789012345", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n---------------------------------------------------------------\n");
// Instaciando o objeto iphone a partir da classe Iphone
Console.WriteLine("Teste Smartphone Iphone:\n");
Iphone iphone = new Iphone(numero: "+55 81 98679 - 1234", modelo: "Iphone 15", imei: "987654321098765", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Shopee");