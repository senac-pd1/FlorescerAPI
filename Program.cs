using FlorescerAPI.Data;
using FlorescerAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using MiniValidation;
using NetDevPack.Identity;
using NetDevPack;
using NetDevPack.Identity.Jwt;
using NetDevPack.Identity.Model;
using System.Reflection;
using FlorescerAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

#region Configure Services

builder.Services.AddEndpointsApiExplorer(); //Gerador de metadados.
builder.Services.AddSwaggerGen( c=>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "FlorescerAPI",
        Description = "Desenvolvido por Wagner Souza de Paula",
        Contact = new OpenApiContact { Name = "Wagner", Email = "wagnersouzadepaula@gmail.com"},
        License = new OpenApiLicense { Name = "Uso Acad�mico", Url = new Uri("https://github.com/orgs/senac-pd1/repositories") }

    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Insira o token JWT desta maneira: Bearer {seu token}",
        Name = "Authorization", 
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[]{}
        }
    });
}
    );

// Passando o Contexto do DB para estabelecer a conex�o.
builder.Services.AddDbContext<MinimalContextDb>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Passando o Contexto do DB para estabelecer conex�o usando token de autentica��o.
builder.Services.AddIdentityEntityFrameworkContextConfiguration(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), 
    b => b.MigrationsAssembly("FlorescerAPI")));



builder.Services.AddIdentityConfiguration();
builder.Services.AddJwtConfiguration(builder.Configuration, "AppSetting");

var app = builder.Build(); 
#endregion

#region Configure pipeline
if (app.Environment.IsDevelopment())
{
    // usar swagger para facilitar e testar a api.
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseAuthConfiguration();

// Mapeando os endpoints
// USUARIOS
// Cadastro de usu�rio
app.MapPost("/registro", [AllowAnonymous] async (
    SignInManager<IdentityUser> signInManager,
    UserManager<IdentityUser> userManager,
    IOptions<AppJwtSettings> appJwtSettings,
    RegisterUser registerUser) =>
    {
        if (registerUser == null)
            return Results.BadRequest("Usu�rio n�o informado");
        if (!MiniValidator.TryValidate(registerUser, out var errors))
            return Results.ValidationProblem(errors);

        var user = new IdentityUser
        {
            UserName = registerUser.Email,
            Email = registerUser.Email,
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(user, registerUser.Password);

        if (!result.Succeeded)
            return Results.BadRequest(result.Errors);

        var jwt = new JwtBuilder()
            .WithUserManager(userManager)
            .WithJwtSettings(appJwtSettings.Value)
            .WithEmail(user.Email)
            //.WithJwtClaims()
            //.WithUserClaims()
            //.WithUserRoles()
            .BuildUserResponse();

        return Results.Ok(jwt);
    })
     .ProducesValidationProblem()
     .Produces(StatusCodes.Status200OK)
     .Produces(StatusCodes.Status400BadRequest)
     .WithName("RegistroUsuario")
     .WithTags("Usuario");

// Login de Usu�rio
app.MapPost("/login", [AllowAnonymous] async (
    SignInManager<IdentityUser> signInManager,
    UserManager<IdentityUser> userManager,
    IOptions<AppJwtSettings> appJwtSettings,
    LoginUser loginUser) =>
{
    if (loginUser == null)
        return Results.BadRequest("Usu�rio n�o informado");

    if (!MiniValidator.TryValidate(loginUser, out var errors))
        return Results.ValidationProblem(errors);

    var result = await signInManager.PasswordSignInAsync(loginUser.Email, loginUser.Password, false, true);

    if (result.IsLockedOut)
        return Results.BadRequest("Usu�rio bloqueado");

    if (!result.Succeeded)
        return Results.BadRequest("Usu�rio ou senha inv�lidos");

    var jwt = new JwtBuilder()
                .WithUserManager(userManager)
                .WithJwtSettings(appJwtSettings.Value)
                .WithEmail(loginUser.Email)
                //.WithJwtClaims()
                //.WithUserClaims()
                //.WithUserRoles()
                .BuildUserResponse();

    return Results.Ok(jwt);

})
  .ProducesValidationProblem()
  .Produces(StatusCodes.Status200OK)
  .Produces(StatusCodes.Status400BadRequest)
  .WithName("LoginUsuario")
  .WithTags("Usuario");

// PLANTAS
// Get de todas as plantas
app.MapGet("/planta", async
    (MinimalContextDb context) => 
    await context.Plantas.ToListAsync())
    .WithName("GetPlanta")
    .WithTags("Planta");

// Get de planta por ID
app.MapGet("/planta/{id}", [Authorize] async
    (Guid id, MinimalContextDb context) =>
    await context.Plantas.FindAsync(id)
        is Planta planta ? Results.Ok(planta) : Results.NotFound())
    .Produces<Planta>(StatusCodes.Status200OK)
    .Produces(StatusCodes.Status404NotFound)
    .WithName("GetPlantaPorId")
    .WithTags("Planta");

app.Run(); // Inicia a aplica��o.

#endregion