using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M03S09.Jogos.WebApi.TesteInstancias
{
    public class TesteScopped
    {
        private readonly Guid _instancia;
        public TesteScopped()
        {
            _instancia = Guid.NewGuid();
        }

        public Guid GetGuid()
        {
            return _instancia;
        }
    }
}