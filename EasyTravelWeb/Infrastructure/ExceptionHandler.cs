using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace EasyTravelWeb.Infrastructure
{
    public class GlobalErrorHandling : ExceptionHandler
    {
        private readonly Logger logger = Logger.GetInstance();

        public override Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            logger.AsyncLogException(context.Exception);

            HttpResponseMessage response = context.Request.CreateResponse(HttpStatusCode.InternalServerError, new
            {
                Message = "An unexpected error occured"
            });
            context.Result = new ResponseMessageResult(response);
            return Task.CompletedTask;
        }
    }
}