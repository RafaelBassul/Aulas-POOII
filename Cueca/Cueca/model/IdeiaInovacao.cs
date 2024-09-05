using Cueca.Percistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cueca.model
{
    internal class IdeiaInovacao
    {
        public string Area { get; set; } = "";
        public string Ideia { get; set; } = "";
        public float Custo { get; set; } = 0;

        public Boolean CadastrarIdeiaInovacao(IdeiaInovacao i)
        {
            BD.SalvarBD(i);
            return true;
        }

    }
}
