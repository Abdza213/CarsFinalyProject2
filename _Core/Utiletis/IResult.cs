using System;
using System.Collections.Generic;
using System.Text;

namespace _Core.Utiletis
{
    public interface IResult
    {

        public bool Success { get; }

        public string Message { get; }

    }
}
