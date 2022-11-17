using System;

namespace HelloWorldApplication
{
    internal class RestRequest
    {
        private object gET;

        public RestRequest(object gET)
        {
            this.gET = gET;
        }

        public RestRequest(Func<Type> getType)
        {
            GetType1 = getType;
        }

        public Func<Type> GetType1 { get; }
    }
}