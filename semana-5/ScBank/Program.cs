using ScBank;



Funcionario funcionarioObj = new Funcionario();

funcionarioObj.Preencher();
funcionarioObj.Imprimir();

Cliente clienteObjeto = new Cliente();
clienteObjeto.Preencher();
clienteObjeto.Imprimir();




var conta1 = new Conta(clienteObjeto,funcionarioObj);

conta1.Depositar(1000);
conta1.Sacar(500);
conta1.imprimirExtrato();

// quero obter o saldo da conta do Arthur, mas não posso acessar diretamente, então vou criar um método para isso
var saldoConta1 = conta1.ObterSaldo();
Console.WriteLine($"Saldo da conta do {conta1.Titular.Nome}: {saldoConta1:C}");


conta1.Depositar(5000);
conta1.imprimirExtrato();


