using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class LocadoraCaminhao: LocadoraVeiculo
    {
        public LocadoraCaminhao(int id, string nome, string placa, string categoria, string renavam) : base(id, nome, placa, categoria, renavam)
        {
        }

        public override void Andar()
        {
            Console.WriteLine("Anda devagar");
        }
    }
}
