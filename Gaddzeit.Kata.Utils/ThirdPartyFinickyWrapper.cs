namespace Gaddzeit.Kata.Utils
{
    class ThirdPartyFinickyWrapper : IFinickyWrapper
    {
        public string DoSomethingProprietary()
        {
            var finickyThirdPartyApp = new FinickyThirdPartyApp();
            return finickyThirdPartyApp.DoSomethingProprietary();
        }
    }
}