using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M03S09.Jogos.WebApi.Domain.Enums;

namespace M03S09.Jogos.WebApi.Domain
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public ECategoriaJogo Categoria { get; set; }
        public int EstudioId { get; set; }
        public Estudio Estudio { get; set; }
    }
}