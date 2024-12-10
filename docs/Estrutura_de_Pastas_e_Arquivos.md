# 📁 Estrutura de Pastas e Arquivos 📁

A estrutura abaixo apresenta como o projeto **ArjSys** está organizado, facilitando a navegação e o entendimento das principais camadas e responsabilidades do sistema.

Cada seção está cuidadosamente dividida para manter a separação de responsabilidades, como **Controllers** para gerenciar as requisições, **Models** para representar as entidades de dados, e **Services** para a lógica de negócio.

```plaintext
ArjSYS/
├── docs/
│   ├── Como_Baixar_Instalar_e_Executar.md
│   ├── Estrutura_de_Pastas_e_Arquivos.md
│   └── Rotas_da_API.md
│
├── src/
│   ├── # Dependências #
│   │   └── Pacotes
│   │       ├── Microsoft.EntityFrameworkCore.Sqlite
│   │       ├── Microsoft.EntityFrameworkCore.Tools
│   │       └── Swashbuckle.AspNetCore
│   │
│   ├── Properties
│   │   └── launchSettings.json
│   │
│   ├── Controllers/
│   │   ├── EstoquesController.cs
│   │   ├── ItensVendaController.cs
│   │   ├── ProducoesController.cs
│   │   ├── ProdutosController.cs
│   │   ├── ProjetosController.cs
│   │   └── VendasController.cs
│   │
│   ├── Data/
│   │   ├── DataSeed/
│   │   │   ├── Estoque/
│   │   │   │   ├── EstoqueSeed.cs
│   │   │   │   └── EstoqueSeed.json
│   │   │   ├── ItemVenda/
│   │   │   │   ├── ItemVendaSeed.cs
│   │   │   │   └── ItemVendaSeed.json
│   │   │   ├── Producao/
│   │   │   │   ├── ProducaoSeed.cs
│   │   │   │   └── ProducaoSeed.json
│   │   │   ├── Produto/
│   │   │   │   ├── ProdutoSeed.cs
│   │   │   │   └── ProdutoSeed.json
│   │   │   ├── Projeto/
│   │   │   │   ├── ProjetoSeed.cs
│   │   │   │   └── ProjetoSeed.json
│   │   │   ├── Vendas/
│   │   │   │   ├── VendasSeed.cs
│   │   │   │   └── VendasSeed.json
│   │   │   └── DataSeed.cs
│   │   ├── Repositories/
│   │   │   ├── Interfaces/
│   │   │   │   ├── IEstoqueRepository.cs
│   │   │   │   ├── IItemVendaRepository.cs
│   │   │   │   ├── IProducaoRepository.cs
│   │   │   │   ├── IProdutoRepository.cs
│   │   │   │   ├── IProjetoRepository.cs
│   │   │   │   └── IVendaRepository.cs
│   │   │   ├── EstoqueRepository.cs
│   │   │   ├── ItemVendaRepository.cs
│   │   │   ├── ProducaoRepository.cs
│   │   │   ├── ProdutoRepository.cs
│   │   │   ├── ProjetoRepository.cs
│   │   │   └── VendaRepository.cs
│   │   └── ApplicationDbContext.cs
│   │
│   ├── DTOs/
│   │   ├── EstoqueDto.cs
│   │   ├── ItemVendaDto.cs
│   │   ├── ProducaoDto.cs
│   │   ├── ProdutoDto.cs
│   │   ├── ProjetoDto.cs
│   │   └── VendaDto.cs
│   │
│   ├── Models/
│   │   ├── Shared/
│   │   │   └── BaseEntity.cs
│   │   ├── Estoque.cs
│   │   ├── ItemVenda.cs
│   │   ├── Producao.cs
│   │   ├── Produto.cs
│   │   ├── Projeto.cs
│   │   └── Venda.cs
│   │
│   ├── Services/
│   │   ├── Interfaces/
│   │   │   ├── IEstoqueService.cs
│   │   │   ├── IItemVendaService.cs
│   │   │   ├── IProducaoService.cs
│   │   │   ├── IProdutoService.cs
│   │   │   ├── IProjetoService.cs
│   │   │   └── IVendaService.cs
│   │   ├── EstoqueService.cs
│   │   ├── ItemVenda.cs
│   │   ├── ProducaoService.cs
│   │   ├── ProdutoService.cs
│   │   ├── ProjetoService.cs
│   │   └── VendaService.cs
│   │
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── ArjSys.csproj
│   ├── ArjSys.csproj.user
│   ├── ArjSys.http
│   ├── ArjSys.sln
│   └── Program.cs
│   
├── .gitattributes
├── .gitignore
└── README.md
