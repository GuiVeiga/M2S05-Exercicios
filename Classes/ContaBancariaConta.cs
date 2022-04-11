using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ContaBancariaConta
    {
        public ContaBancariaConta(string id, string nome, string cPF, int numeroConta, float saldo)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public string Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int NumeroConta { get; set; }
        private float Saldo { get; set; }
    }
}
