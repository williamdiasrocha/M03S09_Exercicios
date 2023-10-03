using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M03S09.Jogos.WebApi.TesteInstancias
{
    public class ServiceTeste
    {
        readonly TesteTransient _testeTransient;
        readonly TesteScopped _testeScopped;
        public ServiceTeste(TesteTransient testeTransient, TesteScopped testeScopped)
        {
            _testeTransient = testeTransient;
            _testeScopped = testeScopped;
        }

        
    }
}