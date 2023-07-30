double bse, altura, area, perimetro, diagonal;

Console.WriteLine("BASE DO RETANGULO: ");
bse = double.Parse(Console.ReadLine());

Console.WriteLine("ALTURA DO RETANGULO: ");
altura = double.Parse(Console.ReadLine());


area = bse * altura;
perimetro = (bse * 2) + (altura * 2);
diagonal = Math.Sqrt(bse * bse + altura * altura);


Console.WriteLine("AREA DO RETANGULO: " + area);


Console.WriteLine("PERIMETRO DO RETANGULO: " + perimetro.ToString("F4"));


Console.WriteLine("DIAGOAL DO RETANGULO: " + diagonal.ToString("f4"));





