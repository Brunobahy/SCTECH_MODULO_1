
// // int[] arrayNum = new int[3];
// // var arrayNumComVar = new int[3];

// // int num1;
// // num1 = 5;
// // Console.WriteLine(num1);

// // int[] arrayNum = new int[4];

// // arrayNum[0] = 5;
// // Console.WriteLine(arrayNum[0]);
// // arrayNum[1] = 6;
// // Console.WriteLine(arrayNum[1]);
// // arrayNum[2] = 7;
// // Console.WriteLine(arrayNum[2]);
// // arrayNum[3] = 8;
// // Console.WriteLine(arrayNum[3]);

// // string[] arrayTexto = new string[3];

// // arrayTexto[0] = "Bruno";
// // Console.WriteLine(arrayTexto[0]);
// // arrayTexto[1] = "Gislaine";
// // Console.WriteLine(arrayTexto[1]);
// // arrayTexto[2] = "Astolfo";
// // Console.WriteLine(arrayTexto[2]);

// bool validaTm = false;
// int tamanho = 0;
// do{ 
//     Console.Write("Digite o tamanho do array: ");
//     validaTm = int.TryParse(Console.ReadLine(), out tamanho);

// }while(!validaTm);

// string[] array = new string[tamanho];

// for(var i=0; i<tamanho; i++)
// {
//     Console.Write($"Digite o {i+1}° nome na posição: ");
//     array[i]=Console.ReadLine();
// }

// for (int i = 0; i < tamanho; i++)
// {
//     Console.WriteLine($"Nome {i+1}: {array[i]}");
// }

// Exercicio

/// Crie um programa para calculo de média que pegunte quantas notas,
/// obtenha os valores delas,  e  realize  o calculo e depois exiba a nota.

// int tamanho = 0;
// bool validaTm = false;

// Console.WriteLine("Bem vindo a calculadora de media");
// do
// {
//     Console.Write("Quantas notas devo calcular? ");
//     validaTm = int.TryParse(Console.ReadLine(),out tamanho);
// }while(!validaTm && tamanho <=0);

// float[] notas = new float[tamanho];
// float soma = 0; 
// for(int i = 0; i < tamanho; i++)
// {
//     bool validaNota = false;
//     float atual;
//     do{
//         Console.Write($"Digite a {i+1}° nota: ");
//         validaNota = float.TryParse(Console.ReadLine(),out atual);
//     }while(!validaNota);

//     notas[i]= atual;
//     soma += atual;
// }
// float media = soma/tamanho;

// Console.WriteLine("");
// Console.WriteLine($"A media das {tamanho} notas é: {media}");
// Console.WriteLine("Notas fornecidas: ");
// for(int i = 0; i < tamanho; i++)
// {
//     Console.WriteLine($"{i+1}) {notas[i]}");
// };

// Listas


// int tamanho = 0;
// bool validaTm = false;

// Console.WriteLine("Bem vindo a calculadora de media");
// do
// {
//     Console.Write("Quantas notas devo calcular? ");
//     validaTm = int.TryParse(Console.ReadLine(),out tamanho);
// }while(!validaTm && tamanho <=0);

// List<float> notas = new List<float>{};
// float soma = 0; 
// for(int i = 0; i < tamanho; i++)
// {
//     bool validaNota = false;
//     float atual;
//     do{
//         Console.Write($"Digite a {i+1}° nota: ");
//         validaNota = float.TryParse(Console.ReadLine(),out atual);
//     }while(!validaNota);

//     notas.Add(atual);
//     soma += atual;
// }
// float media = soma/tamanho;

// Console.WriteLine("");
// Console.WriteLine($"A media das {tamanho} notas é: {media}");
// Console.WriteLine("Notas fornecidas: ");
// for(int i = 0; i < notas.Count; i++)
// {
//     Console.WriteLine($"{i+1}) {notas[i]}");
// };


// foreach(var nota in notas)
// {
//     Console.WriteLine(nota);
// }



List<string> nomes = new List<string>();
string resposta;
while(true){
    Console.WriteLine("Digite um nome para adicionar a lista, ou (sair) para sair:");
    resposta = Console.ReadLine();
    if(resposta.ToLower() == "sair")
    {
        break;
    }
    nomes.Add(resposta);
};

Console.WriteLine("****************");
Console.WriteLine($"Foram adicionados {nomes.Count} sendo eles:");
foreach(var nome in nomes)
{
    Console.WriteLine("");
    Console.WriteLine(nome);
}