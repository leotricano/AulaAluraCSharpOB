using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank

{// Definição de Classe "Conta Corrente"
    public class ContaCorrente
    {  //Campos do objeto
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;

        // Criando metodo Depositar
        public void Depositar(double valor)
        {   
            //Definindo o comportamento do metodo
            this.saldo += valor;
        }
        // Criando metodo Saque
        public bool Saque(double valor)
        {
            //Uma validação para ser possivel sacar a quantia real do dinheiro depositado,
            //se o valor for menor ou igual ao saldo ele ira fazer o deposito
            //Se não retorna false
            if (valor <= this.saldo)
            {
                //Definindo o comportamento do metodo
                this.saldo -= valor;
                return true;
            }
            else 
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                destino.saldo += valor;

                return true;
            }
        }
    }
}
