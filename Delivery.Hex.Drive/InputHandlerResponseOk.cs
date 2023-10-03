using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Hex.Drive
{
    public class InputHandlerResponseOk<TResult> : InputHandlerResponse<TResult>
    {
        public InputHandlerResponseOk(TResult? result) : base(result) { }
    }
}
