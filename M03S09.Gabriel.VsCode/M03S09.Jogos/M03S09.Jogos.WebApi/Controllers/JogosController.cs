using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using M03S09.Jogos.WebApi.Domain;
using M03S09.Jogos.WebApi.DTOs.Jogos;
using M03S09.Jogos.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace M03S09.Jogos.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogosController : ControllerBase
    {
        private readonly JogoRepository _jogoRepository;
        private readonly IMapper _mapper;

        public JogosController(JogoRepository jogoRepository, IMapper mapper)
        {
            _jogoRepository = jogoRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<ViewJogoDto>> Get()
        {
            List<Jogo> jogos = _jogoRepository.Get();
            if(jogos == null || jogos.Count == 0)
            {
                return NoContent();
            }

            var listDto = _mapper.Map<List<ViewJogoDto>>(jogos);
            return Ok(listDto);
        }

        [HttpGet("{id}")]
        public ActionResult<ViewJogoDto> Get(int id) 
        {
            Jogo jogo = _jogoRepository.Get(id);
            if(jogo == null)
            {
                return NotFound();
            }

            var dto = _mapper.Map<ViewJogoDto>(jogo);
            return Ok(dto);
        }

        [HttpPost]
        public ActionResult<ViewJogoDto> Post(CreateJogoDto dto)
        {
            var jogo = _mapper.Map<Jogo>(dto);

            _jogoRepository.Insert(jogo);

            var jogoviewdto = _mapper.Map<ViewJogoDto>(jogo);

            return Ok(jogoviewdto);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, UpdateJogoDto dto)
        {
            if(_jogoRepository.Get(id) == null)
                return NotFound();

            var jogo = _mapper.Map<Jogo>(dto);
            if(jogo.Id != id)
                return BadRequest();

            _jogoRepository.Update(jogo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var jogo = _jogoRepository.Get(id);
            if(jogo == null)
                return NotFound();

            _jogoRepository.Delete(id);
            return NoContent();
        }
    }
}