using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using M03S09.Jogos.WebApi.Domain;
using M03S09.Jogos.WebApi.DTOs.Estudios;
using M03S09.Jogos.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace M03S09.Jogos.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudiosController : ControllerBase
    {
        readonly EstudioRepository _estudioRepository;
        readonly IMapper _mapper;

        public EstudiosController(EstudioRepository estudioRepository, IMapper mapper)
        {
            _estudioRepository = estudioRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ViewEstudioDto>> Get()
        {
            List<Estudio> estudios = _estudioRepository.Get();
            if(estudios == null || estudios.Count == 0)
            {
                return NoContent();
            }

            var listDto = _mapper.Map<List<ViewEstudioDto>>(estudios);
            return Ok(estudios);
        }

        [HttpGet("{id}")]
        public ActionResult<ViewEstudioDto> Get(int id) 
        {
            Estudio estudio = _estudioRepository.Get(id);
            if(estudio == null)
            {
                return NotFound();
            }

            var dto = _mapper.Map<ViewEstudioDto>(estudio);
            return Ok(dto);
        }

        [HttpPost]
        public ActionResult Post(CreateEstudioDto dto)
        {
            var estudio = _mapper.Map<Estudio>(dto);

            _estudioRepository.Insert(estudio);

            var estudioviewdto = _mapper.Map<ViewEstudioDto>(estudio);

            return Ok(estudioviewdto);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, UpdateEstudioDto dto)
        {
            if(_estudioRepository.Get(id) == null)
                return NotFound();

            var estudio = _mapper.Map<Estudio>(dto);
            if(estudio.Id != id)
                return BadRequest();

            _estudioRepository.Update(estudio);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var estudio = _estudioRepository.Get(id);
            if(estudio == null)
                return NotFound();

            _estudioRepository.Delete(id);
            return NoContent();
        }
    }
}