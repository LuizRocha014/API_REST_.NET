using Microsoft.EntityFrameworkCore;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Data.Repository;
using WEB_REST_PRO.Data.Repository.SmartStorege;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionMysql"));
});

//builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
//builder.Services.AddScoped<IAgendaRepository, AgendaRepository>();
//builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
//builder.Services.AddScoped<IMidiaRepository, MidiaRepository>();
//builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
//builder.Services.AddScoped<ICategoriaAgendaRepository, CategoriaAgendaRepository>();
//builder.Services.AddScoped<IAcessoRepository, AcessoRepository>();
//builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
//builder.Services.AddScoped<IEstoqueRepository, EstoqueRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<ICustomersRepository, CustumerRepository>();
builder.Services.AddScoped<IFileRepository, FileRepositoy>();
builder.Services.AddScoped<IPermissionRepository, PermissionRepository>();
builder.Services.AddScoped<IProductFileRepository, ProductFileRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IRolePermissionRepository, RolePermissionRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IShopRepository, ShopRepository>();
builder.Services.AddScoped<IShopUserRepository, ShopUserRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<IUserPermissionRepository, UserPermissionsRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();







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
