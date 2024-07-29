global using Microsoft.EntityFrameworkCore;
using TransactionsAPI.Process;
using TransactionsAPI.DAL;
using TransactionsAPI.DAL.TransactionsDAL;
using TransactionsAPI.DAL.ProfilesDAL;
using AutoMapper;

namespace TransactionsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => c.IncludeXmlComments(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Swagger//TransactionsAPI.Service.xml")));
            builder.Services.AddDbContext<TransactionDbContext>(options => options.UseSqlServer
                (builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IProfileData, ProfileData>();
            builder.Services.AddScoped<ITransactionData, TransactionData>();
            builder.Services.AddScoped<IProfileProcess, ProfileProcess>();
            builder.Services.AddScoped<ITransactionProcess, TransactionProcess>();

            //#region Automapper
            //var mapperConfig = new MapperConfiguration(mc =>
            //{
            //    mc.AddProfile(new AutoMapperProfile());
            //});
            //IMapper mapper = mapperConfig.CreateMapper();
            //builder.Services.AddSingleton(mapper);
            //#endregion Automapper
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("AllowAll");
            app.MapControllers();

            app.Run();
        }
    }
}
