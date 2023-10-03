using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M03S09.Jogos.WebApi.DTOs.Estudios
{
    public class CreateEstudioDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereco { get; set; }
    }
}
