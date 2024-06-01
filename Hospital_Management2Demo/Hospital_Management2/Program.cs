using FluentValidation;
using Hospital_Management2.Data;
using Hospital_Management2.Models;
using Hospital_Management2.Repositories.Doctor;
using Hospital_Management2.Repositories.Habitacion;
using Hospital_Management2.Repositories.Paciente;
using Hospital_Management2.Validations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
			builder.Services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connectionString));
			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<ApplicationDbContext>();
			builder.Services.AddControllersWithViews();

			// Register your services before building the application
			builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
			builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
			builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
            builder.Services.AddScoped<IHabitacionRepository, HabitacionRepository>();

            // Validaciones
            builder.Services.AddScoped<IValidator<PacienteModel>, PacienteValidator>();
            builder.Services.AddScoped<IValidator<HabitacionModel>, HabitacionValidator>();

            var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=home}/{action=Index}/{id?}");
			app.MapRazorPages();

			app.Run();
		}
	}
}
