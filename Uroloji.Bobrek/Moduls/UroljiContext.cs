using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uroloji.Bobrek.Moduls
{
    public class UroljiContext:DbContext
    {
        public UroljiContext():base("Uroloji")
        {

        }
    }
}
