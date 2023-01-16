
namespace API_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
                var builder = WebApplication.CreateBuilder(args);
            //string mySecret = string.Empty;
            //mySecret = builder.Configuration["secret"];
            //if (mySecret.Length < 1)
            //{
            //    Console.WriteLine("It is empty");
            //}
            //else
            //{
            //    Console.WriteLine(mySecret);
            //}
            
            var mySecret = new String(builder.Configuration["secret"]);
            Console.WriteLine(mySecret.Length);
            Console.WriteLine("Secrete is " + builder.Configuration["secret"]);
            Console.WriteLine("this should be JWT, but in code it is called jwtabc" + builder.Configuration["jwtabc"]);
            Console.WriteLine("this should be JWT, in code it is called jwt" + builder.Configuration["jwt"]);
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseAuthorization();


                app.MapControllers();

                app.Run();
           
        }
    }
}
