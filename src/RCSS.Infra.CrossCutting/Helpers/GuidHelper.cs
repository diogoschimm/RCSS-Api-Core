using System;

namespace RCSS.Infra.CrossCutting.Helpers
{
    public class GuidHelper
    {
        public string Generate()
        {
            return Guid.NewGuid().ToString().ToLower();
        }
    }
}
