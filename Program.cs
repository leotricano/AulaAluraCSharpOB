//Importando do arquivo de classe
using bytebank;



// Criando Objeto contaDoAndre
ContaCorrente contaDoAndre = new ContaCorrente(); 

//Inserindo valores para os objetos
contaDoAndre.titular = "Andre Silva";
//Inserindo valores para os objetos
contaDoAndre.numero_agencia= 15;
//Inserindo valores para os objetos
contaDoAndre.conta = "1010-X";
//Inserindo valores para os objetos
contaDoAndre.saldo = 100;

//Mostrando o valor atravez do WriteLine
Console.WriteLine("Saldo conta do Andre = " + contaDoAndre.saldo);

//Utlizando o metodo Depositar
contaDoAndre.Depositar(100);

//Mostrando resultado depois de ter usado o metodo Depositar
Console.WriteLine("Saldo conta do Andre pós-deposito = " + contaDoAndre.saldo);

//Utilizando o metodo Saque
contaDoAndre.Saque(100);

//Mostrando resultado depois de ter usado o metodo Saque
Console.WriteLine("Saldo conta do Andre pós-saque = " + contaDoAndre.saldo);



/*

ContaCorrente conta = new ContaCorrente();
Console.WriteLine($"Titular da conta: {conta.titular}");
Console.WriteLine($"Número da conta: {conta.conta}");
Console.WriteLine($"Agência: {conta.numero_agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

Console.ReadKey();

*/
