# 🔐 Autenticação JWT - API REST

## Implementação Completa de Autenticação JWT

Esta implementação adiciona autenticação JWT completa ao seu projeto .NET 6 Web API.

## 📋 Pré-requisitos

1. **Execute o script SQL** para criar a tabela de usuários:
   ```sql
   -- Execute o arquivo: Scripts/CreateUsuariosTable.sql
   ```

2. **Restaure os pacotes NuGet**:
   ```bash
   dotnet restore
   ```

## 🚀 Endpoints Disponíveis

### 1. Registrar Usuário
```http
POST /api/auth/register
Content-Type: application/json

{
  "nome": "João",
  "sobrenome": "Silva",
  "email": "joao@exemplo.com",
  "password": "123456",
  "userId": "joao-001"
}
```

**Resposta de Sucesso:**
```json
{
  "message": "Usuário criado com sucesso!",
  "userId": 1,
  "email": "joao@exemplo.com"
}
```

### 2. Login
```http
POST /api/auth/login
Content-Type: application/json

{
  "email": "joao@exemplo.com",
  "password": "123456"
}
```

**Resposta de Sucesso:**
```json
{
  "success": true,
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "expiresAt": "2024-08-13T12:33:00Z",
  "email": "joao@exemplo.com",
  "message": "Login realizado com sucesso."
}
```

### 3. Obter Perfil (Protegido)
```http
GET /api/auth/profile
Authorization: Bearer {seu_token_aqui}
```

**Resposta:**
```json
{
  "id": 1,
  "nome": "João",
  "sobrenome": "Silva",
  "email": "joao@exemplo.com",
  "userId": "joao-001",
  "createdAt": "2024-08-13T11:30:00Z"
}
```

### 4. Validar Token (Protegido)
```http
GET /api/auth/validate
Authorization: Bearer {seu_token_aqui}
```

## 🔧 Como Usar em Outros Controllers

Para proteger outros endpoints, adicione o atributo `[Authorize]`:

```csharp
[HttpGet]
[Authorize] // <- Adicione esta linha
public IActionResult GetDados()
{
    // Obter email do usuário logado
    var userEmail = User.Identity?.Name;
    
    // Obter ID do usuário
    var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    
    return Ok(new { message = "Dados protegidos", user = userEmail });
}
```

## 🛡️ Configurações de Segurança

### JWT Settings (appsettings.json)
```json
{
  "JwtSettings": {
    "SecretKey": "MySecretKeyForJWTTokenGeneration2024!@#$%",
    "Issuer": "WEB_REST_PRO_API",
    "Audience": "WEB_REST_PRO_CLIENT",
    "ExpirationInMinutes": 60
  }
}
```

**⚠️ IMPORTANTE:** Em produção, use uma chave secreta mais forte e armazene-a de forma segura!

## 🧪 Testando com Swagger

1. Execute a aplicação: `dotnet run`
2. Acesse: `https://localhost:7xxx/swagger`
3. Registre um usuário usando `/api/auth/register`
4. Faça login usando `/api/auth/login`
5. Copie o token retornado
6. Clique em "Authorize" no Swagger
7. Digite: `Bearer {seu_token}`
8. Teste os endpoints protegidos

## 📁 Arquivos Criados/Modificados

### Novos Arquivos:
- `Models/JwtSettings.cs`
- `Models/LoginRequest.cs`
- `Models/LoginResponse.cs`
- `Models/RegisterRequest.cs`
- `Models/Usuario.cs`
- `Services/IJwtService.cs`
- `Services/JwtService.cs`
- `Services/IUsuarioService.cs`
- `Services/UsuarioService.cs`
- `Data/ApplicationDbContext.cs`
- `Controllers/AuthController.cs`
- `Scripts/CreateUsuariosTable.sql`

### Arquivos Modificados:
- `Program.cs` - Configuração JWT
- `WEB_REST_PRO.csproj` - Pacotes NuGet
- `appsettings.json` - Configurações JWT

## 🔍 Funcionalidades Implementadas

✅ **Registro de usuários** com hash de senha (BCrypt)  
✅ **Login** com validação de credenciais  
✅ **Geração de tokens JWT** com claims personalizados  
✅ **Validação de tokens** automática  
✅ **Middleware de autenticação** configurado  
✅ **Swagger** com suporte a JWT  
✅ **Endpoints protegidos** por autorização  
✅ **Estrutura de banco de dados** para usuários  

## 🚨 Próximos Passos

1. Execute o script SQL para criar a tabela
2. Teste os endpoints no Swagger
3. Implemente autorização baseada em roles (se necessário)
4. Configure refresh tokens (opcional)
5. Adicione rate limiting para segurança adicional

---

**🎉 Sua API agora está protegida com autenticação JWT completa!**
