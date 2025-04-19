Console.Clear();




Console.WriteLine("Digite seu peso em kg: ");
double peso;
string pesoString = Console.ReadLine()!;
bool pesoValido = Double.TryParse(pesoString, out peso); //TryParse vai TENTAR converter, se tiver letra n vai conseguir e vai dar falso

/*
double peso = Convert.ToDouble(Console.ReadLine());
*/

Console.WriteLine("Digite sua altura em m: ");
double altura;
string alturastring = Console.ReadLine()!.Replace(".", ","); //da pra alterar o formato do país
bool alturaValido = double.TryParse(alturastring, out altura);

/*
double altura = double.Parse(alturastring); outra opção usando Parse (não recomendado)
Parse e TryParse converte uma string em variável numérica, no caso double
bool verifica se o TryParse é verdadeiro
*/

if (alturaValido && pesoValido) //se forem verdadeiras (! para inverter, se n for verdadeira)
{
    if (peso <= 0 || altura <= 0 || peso > 400 || altura > 3) //inclui números negativos; 
    // Da pra incluir td no último if cm ||, ms compliquei pra treinar e pra exibir a msg q eu quero nesse caso
    {
        Console.WriteLine("Número inválido, tente novamente");
    }

    else
    {
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
    }
}

else
{
    Console.WriteLine("Por favor, digite somente números");
}

Thread.Sleep(500);
Console.WriteLine("Obrigada por utilizar nossa calculadora\nBy Bii Sam✨");
Thread.Sleep(1000);
Environment.Exit(-1); //termina o programa com um código com erro
