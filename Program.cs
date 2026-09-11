Console.Clear();

Console.WriteLine("--Tradutor de Baleias--\n");
Console.Write("Em Português: ");

string texto = Console.ReadLine()!;
Console.WriteLine("\nEm Baleês:\n");



Console.WriteLine(texto
.Replace("a", "aaa")
.Replace("e", "eee")
.Replace("i", "iii")
.Replace("o", "ooo")
.Replace("u", "uuu")
.Replace("A", "AAA")
.Replace("E", "EEE")
.Replace("I", "III")
.Replace("O", "OOO")
.Replace("U", "UUU")
);
Console.WriteLine();