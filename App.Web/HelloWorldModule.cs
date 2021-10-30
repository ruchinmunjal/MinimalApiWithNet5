using Carter;
using Carter.ModelBinding;
using Microsoft.AspNetCore.Http;

namespace App.Web
{
    public class HelloWorldModule : CarterModule
    {
        public HelloWorldModule()
        {
            Get("/hello", async (req, res) =>
            {
                await res.WriteAsync("Hello World");
            });
            Post("/add", async (req, res) =>
            {
                var person = await req.Bind<Person>();
                await res.WriteAsJsonAsync(person);
            });
        }
    }

    public record Person(string FirstName, string LastName);
}