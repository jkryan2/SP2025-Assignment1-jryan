namespace SP2025_Assignment1_jryan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            Console.WriteLine("Hello World!");

            app.Run();
        }
    }
}
