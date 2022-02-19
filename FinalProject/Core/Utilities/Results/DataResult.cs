using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult : IDataResult<Result>
    {

        public bool IsSuccess { get; }

        public string Message { get; }

        Result IDataResult<Result>.Data { get; }
    }
}
