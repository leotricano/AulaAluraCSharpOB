
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

