using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas

{// Definição de Classe "Conta Corrente"
    public class ContaCorrente
    {  //Campos do objeto
        public int numero_agencia;
        public string conta;
        public double saldo;

        public Cliente titular; //  Com isso estamos criando uma referência. Esse campo vai receber, na verdade,
                                //  uma referência para um objeto do tipo Cliente.
                                //  Assim, relacionamos as duas classes através desse campo.


        // Criando metodo Depositar
        public void Depositar(double valor)
        {
            //Definindo o comportamento do metodo
            saldo += valor;
        }
        // Criando metodo Saque
        public bool Saque(double valor)
        {
            //Uma validação para ser possivel sacar a quantia real do dinheiro depositado,
            //se o valor for menor ou igual ao saldo ele ira fazer o deposito
            //Se não retorna false
            if (valor <= saldo)
            {
                //Definindo o comportamento do metodo
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Criando metodo transferir
        public bool Transferir(double valor, ContaCorrente destino) //declarando o valor e qual conta corrente utilizar, apelidando de "destino"
        {
            if (saldo < valor) // Se o saldo for menor do que o valor a ser depositado não acontece nada, pois ira ficar negativo
            {
                return false; // Acontece nada se acontecer o If
            }
            else
            {
                saldo -= valor;    // Valor ira retirar o dinheiro do saldo (ex: saldo 500 - Valor 300 = Saldo 200)
                destino.saldo += valor; // Ira somar ao destinatario no caso seria uma soma

                return true;
            }
        }
    }
}
