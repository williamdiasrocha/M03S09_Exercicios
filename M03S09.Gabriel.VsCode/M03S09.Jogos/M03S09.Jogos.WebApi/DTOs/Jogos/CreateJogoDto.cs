using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using M03S09.Jogos.WebApi.Domain.Enums;

namespace M03S09.Jogos.WebApi.DTOs.Jogos
{
    public class CreateJogoDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataLancamento { get; set; }
        [Required]
        public ECategoriaJogo Categoria { get; set; }
        [Required]
        public int EstudioId { get; set; }
    }
}