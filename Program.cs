using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iph = new Iphone("18 999999999", "Iphone 15 Pro Max", "MEI 1", 14);
Nokia nok = new Nokia("18 777777777", "Nokia 5200", "MEI 2", 2);

iph.InstalarAplicativo("Instagram");
Console.WriteLine($"Número do Iphone: {iph.Numero}");
iph.Ligar();

Console.WriteLine("\n");

nok.InstalarAplicativo("Jogo da cobrinha");
Console.WriteLine($"Número do Nokia: {nok.Numero}");
nok.ReceberLigacao();



