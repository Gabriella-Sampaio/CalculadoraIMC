Console.Clear();

Console.WriteLine("Digite seu peso em kg: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura em m: ");
string alturastring = Console.ReadLine()!.Replace(".", ",");
double altura = double.Parse(alturastring); //Converte uma string em double

double resultIMC = peso / (altura * altura);

if (resultIMC <17)
{
    Console.WriteLine("Muito a baixo do peso"); 
}

else if (resultIMC <18.5 )
{
    Console.WriteLine("Abaixo do peso");
}

else if (resultIMC <25)
{
    Console.WriteLine("Peso normal");
}

else if (resultIMC <30)
{
    Console.WriteLine("Acima do peso");
}

else if (resultIMC <35)
{
    Console.WriteLine("Obesidade I");
}

else if (resultIMC <40)
{
    Console.WriteLine("Obesidade II (severa)");
}

else
{
    Console.WriteLine("Obesidade III (mórbida)");
}