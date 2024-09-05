using Cueca.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cueca.Percistence
{
    internal class BD
    {
        public static List<IdeiaInovacao> mybd = new ();

        public static void SalvarBD(IdeiaInovacao i) => mybd.Add(i);

        public static List<IdeiaInovacao> RetomarBD() => mybd;
    }
}
