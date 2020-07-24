

namespace MvvMUnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MvvM.Windows;
    using System.Runtime.Remoting.Channels;

    [TestClass]
    class ObservableObjectTests
    {
        [TestMethod]
        public void PropertyChangedEventHandlerIsRaised()
        {
            var obj = new StubObservableObject();

            bool raised = false;

            obj.PropertyChanged += (sender, e) =>
            {
                Assert.IsTrue(e.PropertyName == "ChangedProperty");
                raised = true;
            };
            obj.ChangedProperty = "Seom Value";
            if (!raised) Assert.Fail("PropertyChanged was never invoked");
        }
        class StubObservableObject : ObservableObject
        {
            private string changedProperty;
            public string ChangedProperty
            {
                get { return changedProperty; }
                set
                {
                    changedProperty = value;
                    NotifyPropertyChanged();
                }

            }
        }
    }
}
