using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Unit.Test
{
    class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public bool RunSelfTest()
        {
            throw new NotImplementedException();
        }
    }

    public class FakeTempSensor : ITempSensor
    {
        public int Temp { get; set; }
        public bool Status { get; set; }

        public FakeTempSensor()
        {
            Status = false;
        }

        public int GetTemp()
        {
            Status = true;
            return Temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }

        public void SetTemp(int temp)
        {
            Temp = temp;
        }

        public void WasItCalled(bool status)
        {
            Status = status;
        }
    }
}
