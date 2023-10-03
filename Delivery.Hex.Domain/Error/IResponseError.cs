using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Hex.Domain.Error
{
    public interface IResponseError
    {
        string ResponseErrorMessage { get; }

        ResponseErrorCode ResponseErrorCode { get; }
    }
}
