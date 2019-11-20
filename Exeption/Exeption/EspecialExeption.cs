using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
    class EspecialExeption: ApplicationException
    {
        public ExpecialExeption()
        {

        }

        public ExpecialExeption(string arg): base (arg)
        {

        }

    }
}
