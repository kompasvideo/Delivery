using Delivery.Hex.Domain.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Hex.Drive
{
    public class InputHandlerResponseError<TResult> : InputHandlerResponse<TResult>
    {
        private string _GetSystemMessage(Exception? ex)
        {
            Exception? ex1 = ex;
            StringBuilder sb = new StringBuilder();

            while (ex1 != null)
            {
                sb.AppendFormat("\n{0}", ex1.Message);

                ex1 = ex1.InnerException;
            }

            return sb.ToString();
        }

        public override bool HasError { get; } = true;

        public ResponseErrorCode? CustomErrorCode { get; set; }

        public string ErrorMessage { get; private set; } = string.Empty;

        public string SystemErrorMessage { get; private set; } = string.Empty;

        public InputHandlerResponseError(TResult? result, Exception exception)
            : base(result)
        {
            SystemErrorMessage = _GetSystemMessage(exception); /// exception.Message;

            if (exception is IResponseError responseError)
            {
                CustomErrorCode = responseError.ResponseErrorCode;
                ErrorMessage = responseError.ResponseErrorMessage;
            }
            else
            {
                CustomErrorCode = ResponseErrorCode.IntrenalServerError;
                ErrorMessage = "Ошибка при выполнениии запроса";
            }
        }
    }
}
