namespace Api.Middleware;

public class DateTimeHeader
{
    // the next delegate in the middleware pipeline
    private readonly RequestDelegate _next;

    public DateTimeHeader(RequestDelegate next)
    {
        _next = next;
    }

    // the actual logic of the middleware
    public async Task InvokeAsync(HttpContext context)
    {
        // stuff before next is executed on request
        // Call the next delegate/middleware in the pipeline.
        await _next(context);
        //stuff after next is used in the response
    }
}

// extension method to allow us to add this middleware using app.UseDateTimeHeader
public static class DateTimeHandlerExtensions
{
    public static IApplicationBuilder UseDateTimeHeader (this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<DateTimeHeader>();
    }
}