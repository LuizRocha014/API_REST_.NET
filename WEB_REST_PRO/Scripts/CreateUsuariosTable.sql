-- Script para criar tabela Usuarios
-- Execute este script no seu banco de dados SQL Server

CREATE TABLE [dbo].[Usuarios](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Nome] [nvarchar](100) NOT NULL,
    [Sobrenome] [nvarchar](100) NOT NULL,
    [Email] [nvarchar](255) NOT NULL,
    [PasswordHash] [nvarchar](255) NOT NULL,
    [UserId] [nvarchar](50) NULL,
    [CreatedAt] [datetime2](7) NOT NULL,
    [UpdatedAt] [datetime2](7) NULL,
    [IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Criar índice único para Email
CREATE UNIQUE NONCLUSTERED INDEX [IX_Usuarios_Email] ON [dbo].[Usuarios]
(
    [Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

-- Inserir usuário de teste (senha: 123456)
INSERT INTO [dbo].[Usuarios] ([Nome], [Sobrenome], [Email], [PasswordHash], [UserId], [CreatedAt], [IsActive])
VALUES 
('Admin', 'Sistema', 'admin@teste.com', '$2a$11$8K1p/a0dL2LkzjkjGgHoAOxSQdyEXvuTkjcKgFGdvxvGFGdvxvGFG', 'admin-001', GETUTCDATE(), 1);

-- Nota: A senha hash acima é para '123456' usando BCrypt
-- Em produção, use senhas mais seguras!
