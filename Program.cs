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
if(contaDoAndre.Saque(400))
{   //Mostrando resultado depois de ter usado o metodo Saque
    Console.WriteLine("Saldo conta do Andre pós-saque = " + contaDoAndre.saldo);
}
else
{   //Mostrando resultado depois de ter usado o metodo Saque
    Console.WriteLine("Saldo inuficiente para saque");
}




// Criando Objeto contaDaMaria
ContaCorrente contaDaMaria = new ContaCorrente();

//Inserindo valores para os objetos
contaDaMaria.titular = "Maria Souza";
//Inserindo valores para os objetos
contaDaMaria.numero_agencia = 17;
//Inserindo valores para os objetos
contaDaMaria.conta = "1010-5";
//Inserindo valores para os objetos
contaDaMaria.saldo = 350;
//Mostrando o saldo da Maria no programa
Console.WriteLine("Saldo da conta da Maria =" + contaDaMaria.saldo);

//Utilizando o metodo Transferir 
contaDaMaria.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo do Andre = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);
/*

ContaCorrente conta = new ContaCorrente();
Console.WriteLine($"Titular da conta: {conta.titular}");
Console.WriteLine($"Número da conta: {conta.conta}");
Console.WriteLine($"Agência: {conta.numero_agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

Console.ReadKey();

*/
