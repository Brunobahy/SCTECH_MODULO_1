// int i=1;
// while (i <= 10)
// {
//     Console.WriteLine($"{i}X2={i*2}");
//     i++;
// }

// Console.WriteLine("Digite um numero entre 1 e 10");
// bool ehnumero = int.TryParse(Console.ReadLine(),out int resposta) ; 
// while (resposta < 1 || resposta > 10)
// {
//     Console.WriteLine(resposta);
//     Console.WriteLine(ehnumero);
//     Console.WriteLine("Resposta Errada");
//     Console.WriteLine("Digite um numero entre 1 e 10");

//     ehnumero = int.TryParse(Console.ReadLine(),out resposta); 
// }
// Console.WriteLine($"Você digitou {resposta}");

// int num2;
// bool ehnumero = false;
// do
// {
//     Console.WriteLine("Digite um numero");
//     ehnumero = int.TryParse(Console.ReadLine(),out num2);

// } while (!ehnumero);

// Console.WriteLine($"O numero é {num2}");


// bool ehnumero = false;
// int numeroOriginal=0;
// int fatorial=1;

// while (!ehnumero)
// {
//     Console.WriteLine("Digite um numero para fazer o fatorial");
//     ehnumero = int.TryParse(Console.ReadLine(),out numeroOriginal);

// }

// int numero = numeroOriginal;
// while(numero > 0)
// {
//     fatorial*=numero;
//     numero--;
// }
// Console.WriteLine($"Com while {fatorial}");

// fatorial=1;
// numero = numeroOriginal;

// do
// {
//     fatorial*=numero;
//     numero--;
// }while(numero >0);

// Console.WriteLine($"Com do while {fatorial}");

// fatorial=1;
// numero = numeroOriginal;

// for(int i=numero; i > 0; i--)
// {
//     fatorial *=i;
// }
// Console.WriteLine($"Com for {fatorial}");


// atividade

int escolha = 0;
while (escolha != 4)
{
Console.WriteLine("Escolha uma opção:");
Console.WriteLine("1 - Tabuada");
Console.WriteLine("2 - Input Validator");
Console.WriteLine("3 - Fatorial");
Console.WriteLine("4 - Sair");
bool valida = int.TryParse(Console.ReadLine(),out escolha);

switch (escolha)
{
    case 1:
        Console.WriteLine("Tabuada");
        int i=1;
        while (i <= 10)
        {
            Console.WriteLine($"{i}X2={i*2}");
            i++;
        }
        break;
    case 2:
        Console.WriteLine("Digite um numero entre 1 e 10");
        bool ehnumero = int.TryParse(Console.ReadLine(),out int resposta) ; 
        while (resposta < 1 || resposta > 10)
        {
            Console.WriteLine("Resposta Errada");
            Console.WriteLine("Digite um numero entre 1 e 10");

            ehnumero = int.TryParse(Console.ReadLine(),out resposta); 
        }
        Console.WriteLine($"Você digitou {resposta}");
        break;
    case 3:

        Console.WriteLine("Digite um numero para fazer o fatorial");
        ehnumero = int.TryParse(Console.ReadLine(),out int numeroOriginal);
        int fatorial = 1;
        
        int numero = numeroOriginal;
        while(numero > 0)
        {
            fatorial*=numero;
            numero--;
        }
        Console.WriteLine($"Com while {fatorial}");

        fatorial=1;
        numero = numeroOriginal;

        do
        {
            fatorial*=numero;
            numero--;
        }while(numero >0);

        Console.WriteLine($"Com do while {fatorial}");

        fatorial=1;
        numero = numeroOriginal;

        for(int h=numero; h > 0; h--)
        {
            fatorial *=h;
        }
        Console.WriteLine($"Com for {fatorial}");
        break;
    default:
    break;
}

}