using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace supermarket.Domain.Communication
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public BaseResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
