using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone("11999999999", "Modelo 14", "IMEI 896", 256);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Whatsapp");
Iphone.Informacoes("Iphone");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia("11988888888", "Modelo 1", "IMEI 1", 64);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Facebook");
Nokia.Informacoes("Nokia");