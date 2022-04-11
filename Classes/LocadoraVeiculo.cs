using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class LocadoraVeiculo
    {
        public LocadoraVeiculo(int id, string nome, string placa, string categoria, string renavam)
        {
            Id = id;
            Nome = nome;
            Placa = placa;
            Categoria = categoria;
            Renavam = renavam;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Placa { get; set; }
        public string Categoria { get; set; }
        public string Renavam { get; set; }

        public virtual void Andar() { }
    }
}
