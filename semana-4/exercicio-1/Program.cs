String escolha;
decimal saldo=0;
List<decimal> extrato = new List<decimal>();


Console.WriteLine("Bem vindo a SCBANK");
do
{
    ExibirMenu();
    Console.Write("Opção: ");
    escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1":
            Depositar();
            break;
        case "2":
            Sacar();
            break;
        case "3":
            VerExtrato();
            break;
        default:
            Console.WriteLine($"Seu saldo é de R${saldo}");
            Console.WriteLine("Volte sempre! ;)");
            break;
    }
    Console.WriteLine("");
} while (escolha != "4");

void ExibirMenu()
{
    Console.WriteLine("1- Depositar");
    Console.WriteLine("2- Sacar");
    Console.WriteLine("3- Extrato");
    Console.WriteLine("4- Sair");
    Console.WriteLine("Digite a opção desejada: ");

}
;


decimal PedirValor()
{
    bool validaV = false;
    decimal valor;
    do
    {
        Console.Write("Digite o valor: R$");
        validaV = decimal.TryParse(Console.ReadLine(),out valor);
        if (!validaV || valor <0)
        {
            Console.WriteLine("Valor invalido!");
        }
    }while(!validaV || valor <0);

    return valor;
}


void Depositar()
{
    decimal valor = PedirValor();
    saldo += valor;
    extrato.Add(valor);

    Console.WriteLine($"Valor R${valor} depositado com sucesso");
}
;


void Sacar()
{
    bool validaV = false;

    decimal valor = PedirValor();

    while(valor > saldo){
        Console.WriteLine("Valor Invalido");
        valor = PedirValor();
    }

    saldo -= valor;
    extrato.Add(-valor);
    Console.WriteLine($"Valor R${valor} sacado com sucesso");
}
;

void VerExtrato()
{
    foreach(decimal valor in extrato)
    {
        Console.WriteLine(valor);
    }
    Console.WriteLine($"Seu Saldo atual é R${saldo}");
}
;
