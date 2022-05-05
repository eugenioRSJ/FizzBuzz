// Desenvolva uma lógica que dada um lista de inteiros de 1 a 100, percorra ela e caso o numero seja:
// * divisível por 3 imprima "fizz"
// * divisível por 5 imprima "buzz"
// * divisível por 3 e 5 imprima "fizz buzz"
// * caso nao entre nas regras acima, deverá imprimir o próprio número.

bool Calcular(int valor, int divisor)
{
    return valor % divisor == 0;
}

void FizzBuzz(int item)
{
    string result = "";
    if (Calcular(item, 3))
        result += " fizz";

    if (Calcular(item, 5))
        result += " buzz";
        
    if(!Calcular(item, 3) && !Calcular(item, 5))
        result = item.ToString();

    if(Calcular(item, 7))
        result = "Eugênio Rocha";

    Console.WriteLine(result);
}

for (int i = 1; i <= 100; i++)
{
    FizzBuzz(i);
}
