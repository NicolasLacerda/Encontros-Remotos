using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontros_Remotos.Classes
{
    public class Endereco
    {
        public string? CEP { get; set; }

        public string? rua { get; set; }

        public string? numero { get; set; }

        public string? complemento { get; set; }

        public bool endComercial { get; set; }

    }
}