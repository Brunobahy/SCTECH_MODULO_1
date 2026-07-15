//ATIVIDADE 1 
string user = "tester";
string senha = "1234";
bool logado = false;
Console.WriteLine("Bem vindo, faça seu login: ");
for(int i = 1; i <=3; i++)
{
    Console.Write("Usuario: ");
    string userTentativa = Console.ReadLine();
    Console.Write("Senha: ");
    string senhaTentativa = Console.ReadLine();
    if(user == userTentativa && senha == senhaTentativa)
    {
        Console.WriteLine("Você esta logado ;)");
        break;
    }
    else
    {
        Console.WriteLine("usuario ou senha incorreto");
        Console.WriteLine($"Você ainda tem {3-i} tentativas");
    }
};
if (logado)
{
Console.WriteLine("Você esgotou suas tentativas :(");
    
}

//ATIVIDADE 2


bool sair = false;
float saldo=0;

do
{
    Console.WriteLine("***************");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Ver Saldo");
    Console.WriteLine("4 - sair");
    bool validador = int.TryParse(Console.ReadLine(),out int resposta);
    if (validador)
    {
        switch(resposta){
            case 1:
                Console.WriteLine("Quanto você quer depositar?");
                Console.Write("R$");
                bool vValor = float.TryParse(Console.ReadLine(),out float valor);
                if (vValor && valor >0)
                {
                    saldo+=valor;
                }
                else
                {
                    Console.WriteLine("Valor Invalido");
                }
                ;
                continue;
            case 2:
                Console.WriteLine("Quanto você quer sacar?");
                Console.Write("R$");
                vValor = float.TryParse(Console.ReadLine(),out valor);
                if (vValor && valor >0 && valor<=saldo)
                {
                    saldo-=valor;
                }
                else
                {
                    Console.WriteLine("Valor Invalido ou saldo insuficiente");
                }
                ;
                continue;
            case 3:
                Console.WriteLine($"Seu saldo é R${saldo}");
                continue;
            case 4:
                Console.WriteLine("Você esta saindo, tchau ;)");
                sair = true;
                continue;
            default:
                continue;
            
        }
    }
}while(!sair);

