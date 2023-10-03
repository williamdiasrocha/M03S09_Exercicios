using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M03S09.Jogos.WebApi.TesteInstancias;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace M03S09.Jogos.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {
        readonly TesteSingleton _testeSingleton;
        readonly TesteScopped _testeScopped;
        readonly TesteTransient _testeTransient;

        readonly ServiceTeste _serviceTeste;

        public TesteController(TesteSingleton testeSingleton, TesteScopped testeScopped, TesteTransient testeTransient, ServiceTeste serviceTeste)
        {
            _testeSingleton = testeSingleton;
            _testeScopped = testeScopped;
            _testeTransient = testeTransient;
            _serviceTeste = serviceTeste;
        }


        [HttpGet]
        public ActionResult Get()
        {
            var singleton = _testeSingleton.GetGuid();
            var scopped = _testeScopped.GetGuid();
            var transient = _testeTransient.GetGuid();

            

            return Ok(new { singleton, scopped, transient });
        }

        
    }
}