# 🚀 **Como Baixar, Instalar e Executar** 🚀

## Pré-requisitos

1. Instale o **.NET SDK 8.0** ou superior:
   - [Download do .NET SDK](https://dotnet.microsoft.com/download/dotnet/8.0).
   - Verifique a instalação:

     ```bash
     dotnet --version
     ```

2. Instale o **Git**:
   - [Download do Git](https://git-scm.com/).
   - Verifique a instalação:

     ```bash
     git --version
     ```

3. Opcional: Instale uma ferramenta para gerenciar dependências (por exemplo, `NuGet` CLI).

---

## Passo a Passo

1. **Clone o repositório para sua máquina**:

   ```bash
   git clone https://github.com/LuizFAraujo/arjsys_back_api.git
   cd arjsys_back_api
   ```

2. **Restaure as dependências do projeto**:

   ```bash
   dotnet restore
   ```

   Esse comando baixa todas as bibliotecas necessárias para o funcionamento do projeto.

3. **Configure o banco de dados SQLite**:
   - Localize o arquivo `appsettings.json` e ajuste o caminho do banco de dados, caso necessário:

     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Data Source=arjsys.db"
       }
     }
     ```

4. **Aplique as migrações e inicialize o banco de dados**:

   ```bash
   dotnet ef database update
   ```

5. **Execute a aplicação**:

   ```bash
   dotnet run
   ```

6. **Acesse a API no navegador ou no Postman**:
   - A URL padrão para a API está definida no arquivo `launchSettings.json`, que pode ser encontrada em `/src/Properties/launchSettings.json`. O valor padrão geralmente é `https://localhost:7040` e `http://localhost:5136`. Certifique-se de verificar a porta correta.
   - Para acessar a documentação interativa via Swagger, utilize:

     ```url
     https://localhost:7040/swagger/index.html
     ```

---

## Problemas Comuns e Soluções

- **Erro ao executar o comando `dotnet ef`**:
  Certifique-se de que a ferramenta Entity Framework está instalada:

  ```bash
  dotnet tool install --global dotnet-ef
  ```

- **Banco de dados não inicializado**:
  Verifique o arquivo `appsettings.json` para garantir que o caminho do banco de dados está correto.

---
