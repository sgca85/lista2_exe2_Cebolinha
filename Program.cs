string fraseDigitada;
string fraseModificada;

Console.Write("Digite uma frase: ");
fraseDigitada = Console.ReadLine()!; 

fraseModificada = fraseDigitada.Replace("r","l").Replace("R","L");

Console.WriteLine(fraseModificada);

