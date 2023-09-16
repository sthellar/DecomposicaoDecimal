int numeroDigitado, centenas, dezenas, unidades;

Console.Write("Digite um número..: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O número digitado possui:");

centenas = numeroDigitado / 100;
dezenas = (numeroDigitado % 100) / 10;
unidades = (numeroDigitado % 100) % 10;

Console.WriteLine($"{centenas} centena(s)");
Console.WriteLine($"{dezenas} dezena(s)");
Console.WriteLine($"{unidades} unidades(s)");
