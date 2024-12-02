# Estrutura de Pastas e Arquivosssss

``` plaintext
ArjSys/
├── # Dependências #
│   └── Pacotes
│       ├── Microsoft.EntityFrameworkCore.Sqlite
│       ├── Microsoft.EntityFrameworkCore.Tools
│       └── Swashbuckle.AspNetCore
│
├── Controllers/
│   ├── EstoquesController.cs
│   ├── ItensVendaController.cs
│   ├── ProducoesController.cs
│   ├── ProdutosController.cs
│   ├── ProjetosController.cs
│   └── VendasController.cs
│
├── Data/
│   ├── DataSeed/
│   │   ├── Estoque/
│   │   │   ├── EstoqueSeed.cs
│   │   │   └── EstoqueSeed.json
│   │   ├── ItemVenda/
│   │   │   ├── ItemVendaSeed.cs
│   │   │   └── ItemVendaSeed.json
│   │   ├── Producao/
│   │   │   ├── ProducaoSeed.cs
│   │   │   └── ProducaoSeed.json
│   │   ├── Produto/
│   │   │   ├── ProdutoSeed.cs
│   │   │   └── ProdutoSeed.json
│   │   ├── Projeto/
│   │   │   ├── ProjetoSeed.cs
│   │   │   └── ProjetoSeed.json
│   │   ├── Vendas/
│   │   │   ├── VendasSeed.cs
│   │   │   └── VendasSeed.json
│   │   └── DataSeed.cs
│   ├── Repositories/
│   │   ├── Interfaces/
│   │   │   ├── IEstoqueRepository.cs
│   │   │   ├── IItemVendaRepository.cs
│   │   │   ├── IProducaoRepository.cs
│   │   │   ├── IProdutoRepository.cs
│   │   │   ├── IProjetoRepository.cs
│   │   │   └── IVendaRepository.cs
│   │   ├── EstoqueRepository.cs
│   │   ├── ItemVendaRepository.cs
│   │   ├── ProducaoRepository.cs
│   │   ├── ProdutoRepository.cs
│   │   ├── ProjetoRepository.cs
│   │   └── VendaRepository.cs
│   └── ApplicationDbContext.cs
│
├── DTOs/
│   ├── EstoqueDto.cs
│   ├── ItemVendaDto.cs
│   ├── ProducaoDto.cs
│   ├── ProdutoDto.cs
│   ├── ProjetoDto.cs
│   └── VendaDto.cs
│
├── Models/
│   ├── Shared/
│   │   └── BaseEntity.cs
│   ├── Estoque.cs
│   ├── ItemVenda.cs
│   ├── Producao.cs
│   ├── Produto.cs
│   ├── Projeto.cs
│   └── Venda.cs
│
├── Services/
│   ├── Interfaces/
│   │   ├── IEstoqueService.cs
│   │   ├── IItemVendaService.cs
│   │   ├── IProducaoService.cs
│   │   ├── IProdutoService.cs
│   │   ├── IProjetoService.cs
│   │   └── IVendaService.cs
│   ├── EstoqueService.cs
│   ├── ItemVenda.cs
│   ├── ProducaoService.cs
│   ├── ProdutoService.cs
│   ├── ProjetoService.cs
│   └── VendaService.cs
│
├── appsettings.json
├── ArjSys.http
└── Program.cs
```
