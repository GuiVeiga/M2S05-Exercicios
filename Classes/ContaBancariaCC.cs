using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ContaBancariaCC: ContaBancariaConta
    {
        public ContaBancariaCC(string id, string nome, string cPF, int numeroConta, float saldo, float ChequeEspecial) : base(id, nome, cPF, numeroConta, saldo)
        {
            ChequeEspecial = chequeEspecial;
        }

        private float chequeEspecial { get; set; }
    }
}
