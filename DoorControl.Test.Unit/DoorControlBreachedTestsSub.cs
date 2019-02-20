using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DoorControl.Test.Unit.Mocks;
using NSubstitute;
using NUnit.Framework;

namespace DoorControl.Test.Unit
{
    // Test Fixture for exception 2: Door breached (i.e. opened without prior validation)
    [TestFixture]
    public class DoorControlDoorBreachedTestsSub
    {
        private IDoorControlFactory _doorControlFactory;
        private DoorControl _uut;

        [SetUp]
        public void Setup()
        {
            _doorControlFactory = Substitute.For<IDoorControlFactory>();

            _uut=new DoorControl(_doorControlFactory);
        }

        [Test]
        public void DoorBreached_AlarmIsCalled()
        {
            _uut.DoorOpened();
            _doorControlFactory.Received().CreateAlarm();

        }
    }

}