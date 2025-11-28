using ECommerce.Domain.Exceptions;
using ECommerce.Shared.ErrorModels;

namespace ECommerce.Web.CustomMiddleWares
{
    public class CustomExceptionMiddleWare 
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomExceptionMiddleWare> _logger;

        public CustomExceptionMiddleWare( RequestDelegate Next , ILogger<CustomExceptionMiddleWare> logger)
        {
            _next = Next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);

                if (context.Response.StatusCode == StatusCodes.Status404NotFound)
                {
                    var Response = new ErrorsToReturn()
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        Message = $"End point {context.Request.Path} is not found"
                    };

                    await context.Response.WriteAsJsonAsync(Response);

                }
            }
            catch (Exception e)
            {
               _logger.LogError(e , e.Message);
               var Response = new ErrorsToReturn()
               {
                 
                   Message = e.Message
               };


                context.Response.StatusCode = e switch
               {
                   NotFoundException => StatusCodes.Status404NotFound,
                   UnAuthorizedcs =>StatusCodes.Status401Unauthorized,
                   BadRequestException BadRequestException => GetBadRequest(BadRequestException , Response) ,
                   _ => StatusCodes.Status500InternalServerError
               };
                Response.StatusCode = context.Response.StatusCode;

                context.Response.ContentType = "application/json";

                await context.Response.WriteAsJsonAsync(Response);
            }
        }

        private int GetBadRequest(BadRequestException exception, ErrorsToReturn response)
        {
            response.Errors = exception.Errors;
            return StatusCodes.Status400BadRequest;
        }

    }
}
