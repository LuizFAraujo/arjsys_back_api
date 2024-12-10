# 🌐 **Endpoints da API** 🌐

Este documento apresenta os endpoints iniciais da API projetados para gerenciar estoques, itens de venda, produções, produtos, projetos e vendas. Eles representam a estrutura básica do sistema e podem ser alterados ou expandidos à medida que o desenvolvimento do projeto avança e novas necessidades surgem.

A API segue uma abordagem RESTful, permitindo operações padrão como criação, leitura, atualização e exclusão (CRUD) para cada entidade descrita. Essas rotas iniciais servem como ponto de partida e serão ajustadas conforme o escopo e as funcionalidades evoluírem.

## **Endpoints por Entidade**

### **Estoques**

| Método      | Rota                  | Descrição                        |
|-------------|-----------------------|----------------------------------|
| **GET**     | `/api/estoques`       | Listar todos os estoques.        |
| **GET**     | `/api/estoques/{id}`  | Obter detalhes de um estoque.    |
| **POST**    | `/api/estoques`       | Criar um novo estoque.           |
| **PUT**     | `/api/estoques/{id}`  | Atualizar um estoque existente.  |
| **DELETE**  | `/api/estoques/{id}`  | Excluir um estoque.              |

---

### **Itens de Venda**

| Método      | Rota                     | Descrição                           |
|-------------|--------------------------|-------------------------------------|
| **GET**     | `/api/itensvenda`        | Listar todos os itens de venda.     |
| **GET**     | `/api/itensvenda/{id}`   | Obter detalhes de um item.          |
| **POST**    | `/api/itensvenda`        | Adicionar um novo item de venda.    |
| **PUT**     | `/api/itensvenda/{id}`   | Atualizar um item existente.        |
| **DELETE**  | `/api/itensvenda/{id}`   | Excluir um item de venda.           |

---

### **Produções**

| Método      | Rota                     | Descrição                           |
|-------------|--------------------------|-------------------------------------|
| **GET**     | `/api/producoes`         | Listar todas as produções.          |
| **GET**     | `/api/producoes/{id}`    | Obter detalhes de uma produção.     |
| **POST**    | `/api/producoes`         | Registrar uma nova produção.        |
| **PUT**     | `/api/producoes/{id}`    | Atualizar uma produção existente.   |
| **DELETE**  | `/api/producoes/{id}`    | Excluir uma produção.               |

---

### **Produtos**

| Método      | Rota                     | Descrição                           |
|-------------|--------------------------|-------------------------------------|
| **GET**     | `/api/produtos`          | Listar todos os produtos.           |
| **GET**     | `/api/produtos/{id}`     | Obter detalhes de um produto.       |
| **POST**    | `/api/produtos`          | Criar um novo produto.              |
| **PUT**     | `/api/produtos/{id}`     | Atualizar um produto existente.     |
| **DELETE**  | `/api/produtos/{id}`     | Excluir um produto.                 |

---

### **Projetos**

| Método      | Rota                     | Descrição                           |
|-------------|--------------------------|-------------------------------------|
| **GET**     | `/api/projetos`          | Listar todos os projetos.           |
| **GET**     | `/api/projetos/{id}`     | Obter detalhes de um projeto.       |
| **POST**    | `/api/projetos`          | Criar um novo projeto.              |
| **PUT**     | `/api/projetos/{id}`     | Atualizar um projeto existente.     |
| **DELETE**  | `/api/projetos/{id}`     | Excluir um projeto.                 |

---

### **Vendas**

| Método      | Rota                     | Descrição                           |
|-------------|--------------------------|-------------------------------------|
| **GET**     | `/api/vendas`            | Listar todas as vendas.             |
| **GET**     | `/api/vendas/{id}`       | Obter detalhes de uma venda.        |
| **POST**    | `/api/vendas`            | Registrar uma nova venda.           |
| **PUT**     | `/api/vendas/{id}`       | Atualizar uma venda existente.      |
| **DELETE**  | `/api/vendas/{id}`       | Excluir uma venda.                  |
