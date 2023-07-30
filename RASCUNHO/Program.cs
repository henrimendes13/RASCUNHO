Console.WriteLine("Comprimento do terreno:");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Largura do terreno:");
double largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Preço do mt2 do terreno:");
double preço = Convert.ToDouble(Console.ReadLine());

double area = comprimento * largura;
double preçoTotal = area * preço;

Console.WriteLine("A area do terreno é: " + area);
Console.WriteLine("O preço do terreno é: " + preçoTotal);







