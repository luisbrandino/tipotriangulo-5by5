// Faça um programa que leia os três lados de um triângulo e informe o tipo dele 

double sideA;
double sideB;
double sideC;

while (true)
{
    Console.Write("Medida do primeiro lado: ");
    sideA = double.Parse(Console.ReadLine());

    Console.Write("Medida do segundo lado: ");
    sideB = double.Parse(Console.ReadLine());

    Console.Write("Medida do terceiro lado: ");
    sideC = double.Parse(Console.ReadLine());

    bool isTriangle =
        sideA + sideB > sideC &&
        sideA + sideC > sideB &&
        sideB + sideC > sideA;

    if (isTriangle)
        break;

    Console.WriteLine("Os valores informados não podem formar um triângulo, tente novamente.");
}

bool isEquilateral =
    sideA == sideB &&
    sideA == sideC;

bool isIsosceles =
    (sideA == sideB && sideA != sideC) ||
    (sideA == sideC && sideA != sideB) ||
    (sideB == sideC && sideB != sideA);

bool isRight =
    Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
    Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2) ||
    Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2);

Console.Write("\nOs lados informados formam um triângulo ");

if (isEquilateral)
    Console.Write("equilátero");
else if (isIsosceles)
    Console.Write("isósceles");
else
    Console.Write("escaleno");

if (isRight)
    Console.WriteLine("\nAlém disso, esse triângulo também é retângulo");