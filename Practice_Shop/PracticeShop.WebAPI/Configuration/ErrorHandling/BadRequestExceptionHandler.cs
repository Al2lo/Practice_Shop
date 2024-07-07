using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SendGrid.Helpers.Errors.Model;

namespace CardGame.WebAPI.Configuration.Error_Handling
{
    public class BadRequestExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<BadRequestExceptionHandler> logger;
        public BadRequestExceptionHandler(ILogger<BadRequestExceptionHandler> logger)
        {
                this.logger = logger;
        }
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if(exception is not BadRequestException badRequestException)
            {
                return false;
            }

            logger.LogError(badRequestException, badRequestException.Message);

            var problemsDetails = new ProblemDetails()
            {
                Status = StatusCodes.Status400BadRequest,
                Title = "Bad Request",
                Detail = badRequestException.Message
            };

            httpContext.Response.StatusCode = problemsDetails.Status.Value;
            await httpContext.Response.WriteAsJsonAsync(problemsDetails,cancellationToken);
            return true;
        }
    }
}
