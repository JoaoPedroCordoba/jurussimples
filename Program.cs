Double j, c, i, m, t;

Console.WriteLine("Capital [c] (R$).......:");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Taxa de juros [i] (%)..:");
i = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Tempo [t] (meses)......:");
t = Convert.ToDouble(Console.ReadLine());

j = c* (i / 100)*t;
m = (c + j);

Console.WriteLine($"Juros (R$).....:{j:C2}");
Console.WriteLine($"Montante (R$)..:{m:C2}");
