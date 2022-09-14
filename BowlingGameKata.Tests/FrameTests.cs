using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
namespace BowlingGameKata.Tests
{
    public class FrameTests
    {
        private Frame _frame;
        [SetUp]
        public void Setup()
        {
            _frame = new Frame();
        }

        [Test]
        public void Should_Throw_Exception_When_Invalid_Pin_Number_Provided()
        {
            try
            {
                _frame.FirstGo(11);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [Test]
        public void Should_Set_Frame_First_Turn_Score_When_Valid_Data_Provided()
        {
            _frame.FirstGo(9).Should().Be(9);
        }
    }
}
