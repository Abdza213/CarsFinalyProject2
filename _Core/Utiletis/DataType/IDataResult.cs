using System;
using System.Collections.Generic;
using System.Text;

namespace _Core.Utiletis.DataType
{
    public interface IDataResult<T> : IResult
    {

        public T Data { get; }
    }
}
