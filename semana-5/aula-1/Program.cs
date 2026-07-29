// using game;

// Personagem jogador = new Personagem("Aragorn", "Humano", "Skin1", "Guerreiro", 20);

// Personagem inimigo = new Personagem("Orc", "Orc", "Skin2", "Bárbaro", 15);


// jogador.Andar();

// while (jogador.Vida > 0 && inimigo.Vida > 0)
// {
//     jogador.Atacar(inimigo);
//     inimigo.Atacar(jogador);
// }

// Personagem outroInimigo = new Personagem("Goblin", "Goblin", "Skin3", "Ladrão", 10);

// while (jogador.Vida > 0 && outroInimigo.Vida > 0)
// {
//     jogador.Atacar(outroInimigo);
//     outroInimigo.Atacar(jogador);
// }

using ScBank;

Conta conta1 = new Conta("Bruno");
Conta conta2 = new Conta("Gislaine");

conta1.Depositar(-500);
conta1.Sacar(500);
conta1.Depositar(200);
conta1.Transferir(100,conta2);
conta1.Sacar(50);
conta1.Depositar(100);

conta1.DadosConta();