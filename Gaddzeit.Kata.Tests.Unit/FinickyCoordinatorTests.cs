using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gaddzeit.Kata.Utils;
using NBehave.Spec.NUnit;
using NUnit.Framework;
using Rhino.Mocks;

namespace Gaddzeit.Kata.Tests.Unit
{
    [TestFixture]
    public class FinickyCoordinatorTests
    {
        private MockRepository _mockRepository;
        private IFinickyWrapper _finickyWrapper;

        [SetUp]
        public void SetUp()
        {
            _mockRepository = new MockRepository();
            _finickyWrapper = _mockRepository.StrictMock<IFinickyWrapper>();
        }

        [TearDown]
        public void TearDown()
        {
            _mockRepository.VerifyAll();
        }

        [Test]
        public void DoMyCustomActionMethod_NoInputParams_ReturnsExpectedString()
        {
            const string someValue = "Some value returned";
            Expect.Call(_finickyWrapper.DoSomethingProprietary()).Return(someValue);

            _mockRepository.ReplayAll();

            var sut = new FinickyCoordinator(_finickyWrapper);
            var result = sut.DoMyCustomAction();

            result.ShouldEqual(someValue);
        }
    }
}
