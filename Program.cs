using System;

class Lista
{
    static void Main()
    {
        List<string> fruta = new List<string> {"Banana", "Maçã", "Laranja", "Manga",
        "Melancia", "Abacaxi"};

        Console.WriteLine("\r\nDeseja comprar mais alguma fruta para estoque?\r\n");  
        
        string novafruta = Console.ReadLine();
        
        Console.WriteLine($"\r\nA fruta: {novafruta} foi adicionada ao estoque\r\n");
        
        fruta.Add( novafruta );

        Console.WriteLine("\r\nFrutas em estoque: " + string.Join(", ", fruta));

    }
}
