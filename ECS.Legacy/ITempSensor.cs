using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
        void SetTemp(int temp);
        void WasItCalled(bool status);

        int Temp { get; set; }
        bool Status { get; set; }
    }
}
