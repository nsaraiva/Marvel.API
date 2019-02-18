using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface.Models
{
    public class Personagem
    {
        // ID do personagem
        public int Id { get; set; }
        // Nome do personagem
        public string Nome { get; set; }
        // Descricao do personagem
        public string Descricao { get; set; }
        // URL da imagem do personagem
        public string Imagem { get; set; }
        // Quantidade de HQs em que o personagem apareceu
        public int Hqs { get; set; }
        public int Time { get; set; }
    }
}
