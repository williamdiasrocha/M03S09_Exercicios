using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M03S09.Jogos.WebApi.DTOs.Estudios
{
    public class UpdateEstudioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}