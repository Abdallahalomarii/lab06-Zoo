using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Interface
{
    public interface IHaveClaw
    {
        double ClawLength { get; set; }

        void Claw();
    }
}
