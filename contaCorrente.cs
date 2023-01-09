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
        public void Saque(double valor)
        {
            //Definindo o comportamento do metodo
            this.saldo -= valor;
        }
    }
}
