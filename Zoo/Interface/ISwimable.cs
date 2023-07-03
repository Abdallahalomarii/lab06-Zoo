using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Interface
{
    public interface ISwimable
    {
         int SwimmingSpeed { get; set; }

         void Swimmable();
            
    }
}
