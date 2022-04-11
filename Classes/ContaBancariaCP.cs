using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ContaBancariaCP: ContaBancariaConta
    {
        public ContaBancariaCP(string id, string nome, string cPF, int numeroConta, float saldo, float Investimento) : base(id, nome, cPF, numeroConta, saldo)
        {
            Investimento = investimento;
        }

        private float investimento { get; set; }
    }
}
