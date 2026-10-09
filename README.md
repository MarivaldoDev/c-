# System Register CLI

Aplicação de linha de comando desenvolvida em C# para cadastrar e consultar
usuários. Os registros são armazenados localmente no arquivo `registers.txt`,
usando um formato simples separado por vírgulas.

## Funcionalidades

- Cadastrar um usuário com nome e idade.
- Listar todos os usuários cadastrados.
- Exibir a quantidade total de usuários.
- Excluir todos os registros.
- Pesquisar usuários pelo nome.
- Gerar IDs sequenciais para os usuários.

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) ou superior.
- Um terminal compatível com a execução de aplicações .NET.

O framework-alvo do projeto está definido como `net10.0` no arquivo
`csharp.csproj`.

## Como executar

1. Clone o repositório e acesse a pasta do projeto:

   ```bash
   git clone <URL_DO_REPOSITORIO>
   cd system_register_CLI
   ```

2. Execute a aplicação:

   ```bash
   dotnet run
   ```

Também é possível compilar o projeto antes de executá-lo:

```bash
dotnet build
dotnet run --no-build
```

## Uso

Ao iniciar, a aplicação exibe o menu principal:

```text
[1] Create user
[2] View users
[3] View total users
[4] Delete all
[5] Search user
[6] Exit
```

## Persistência dos dados

Os dados são gravados no arquivo `registers.txt` no diretório de execução.
Cada linha segue o formato:

```text
id,nome,idade
```

Exemplo:

```text
1,Mariva,19
```

O arquivo `registers.txt` está listado no `.gitignore`, portanto os dados
locais não são enviados ao repositório. Caso o arquivo não exista, ele será
criado automaticamente ao cadastrar o primeiro usuário.

## Estrutura do projeto

```text
.
├── Main.cs       # Fluxo do menu e interação com o usuário
├── Person.cs     # Modelo de usuário e controle dos IDs
├── Program.cs    # Operações de persistência e consulta dos registros
├── csharp.csproj # Configuração do projeto .NET
└── README.md     # Documentação
```

## Limitações atuais

- Os dados são armazenados em arquivo texto, sem banco de dados.
- O formato separado por vírgulas não permite tratar vírgulas no nome.
- A interface e as mensagens estão atualmente em inglês.
- A exclusão de todos os registros não pode ser desfeita.

