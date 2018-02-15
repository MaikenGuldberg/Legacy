using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture]
    public class Class1
    {
        private ECS _uut;
        private IHeater _Heater;
        private ITempSensor _TempSensor;


        [SetUp]
        public void SetUp()
        {
            _Heater = Substitute.For<IHeater>();
            _TempSensor = new FakeTempSensor();
            _uut = new ECS(20,_TempSensor,_Heater);
            
        }

        [Test]
        public void CheckIfHeaterTurnsOn_TurnsOn_20Degrees()
        {
            _TempSensor.SetTemp(20);
            _uut.SetThreshold(19);
            _uut.Regulate();

            Assert.That(_TempSensor.Status,Is.EqualTo(true));
        }
    }
}
