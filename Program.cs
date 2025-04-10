using System.Security.Cryptography.X509Certificates;

Console.Clear();

Console.WriteLine("Digite seu peso em kg: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura em m: ");
double altura = Convert.ToDouble(Console.ReadLine());

double result1IMC = altura * altura;
double resultIMC = peso / result1IMC;

if (resultIMC <17)
{
    Console.WriteLine("Muito a baixo do peso"); //substituir por uma string
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