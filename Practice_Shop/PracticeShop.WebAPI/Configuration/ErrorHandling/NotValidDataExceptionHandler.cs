using CardGame.WebAPI.Configuration.Error_Handling;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticeShop.WebAPI.Configuration.Exceptions;
using SendGrid.Helpers.Errors.Model;

namespace PracticeShop.WebAPI.Configuration.ErrorHandling
{
    public class NotValidDataExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<NotValidDataExceptionHandler> logger;
        public NotValidDataExceptionHandler(ILogger<NotValidDataExceptionHandler> logger)
        {
            this.logger = logger;
        }
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is not NotValidDataException notValidDataException)
            {
                return false;
            }
            logger.LogError(notValidDataException, notValidDataException.Message);

            var problemDetails = new ProblemDetails
            {
                Status = StatusCodes.Status400BadRequest,
                Title = "Not Found",
                Detail = notValidDataException.Message
            };

            httpContext.Response.StatusCode = problemDetails.Status.Value;

            await httpContext.Response
                .WriteAsJsonAsync(problemDetails, cancellationToken);

            return true;
        }
    }
}
