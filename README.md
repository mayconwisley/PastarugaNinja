# Pastaruga Ninja

## Descrição
Pastaruga Ninja é uma aplicação de console escrita em C# (.NET Framework 3.5) para automatizar operações simples de pastas — principalmente criação e remoção — e registrar todas as ações em arquivos de log para auditoria e diagnóstico.

## Funcionalidades
- Criar uma pasta em um diretório especificado.
- Excluir uma pasta de um diretório especificado.
- Registro (log) detalhado de operações e erros em arquivo.
- Validação básica dos argumentos passados pela linha de comando.

## Requisitos
- Windows com .NET Framework 3.5 instalado.
- Visual Studio 2022 (opcional, para abrir/compilar o código-fonte).

## Download

Você pode baixar o executável compilado clicando no link abaixo:

[Download do Pastaruga Ninja](https://github.com/mayconwisley//PastarugaNinja/raw/refs/heads/master/exe/PastarugaNinja.exe)

## Como executar
Abra o Prompt de Comando e execute o binário `PastarugaNinja.exe` com os argumentos apropriados.

Comandos disponíveis:
- Criar pasta:
  - `PastarugaNinja.exe create <caminho> <nomeDaPasta>`
  - Atalhos aceitáveis: `cri`, `c`
  - Exemplo:
    - `PastarugaNinja.exe create "C:\MeusDocumentos" "NovaPasta"`
- Excluir pasta:
  - `PastarugaNinja.exe delete <caminhoDaPasta>`
  - Atalhos aceitáveis: `del`, `d`
  - Exemplo:
    - `PastarugaNinja.exe delete "C:\MeusDocumentos\NovaPasta"`
- Excluir pasta e arquivos:
  - `PastarugaNinja.exe delete a <caminhoDaPasta>`
  - Atalhos aceitáveis: `del`, `d`
  - Exemplo:
    - `PastarugaNinja.exe delete a "C:\MeusDocumentos\NovaPasta"`    

Opções de ajuda:
- `PastarugaNinja.exe help`
- `PastarugaNinja.exe -h` ou `--help`

Observações:
- Os exemplos acima assumem que o executável está no diretório atual ou presente no PATH.
- Se o diretório base informado não existir, a operação de criação não será executada e um log será gerado.

## Logs
Os logs são gravados na mesma pasta do executável com o padrão de nome:
`yyyy-MM-dd HHh - Log Pastaruga Ninja.log`

Cada entrada de log inclui timestamp e mensagem para facilitar diagnóstico.

## Estrutura do projeto
- `Program.cs` — ponto de entrada e parse dos argumentos/ comandos.
- `CriarPasta.cs` — lógica de criação de diretórios e validações.
- `CriarLog.cs` — responsável pela escrita segura dos logs no disco.
- `LICENSE.txt` — licença do projeto (MIT).

## Boas práticas e recomendações
- Execute com permissões suficientes ao criar/excluir pastas em locais protegidos (ex.: `Program Files`).
- Faça backup ou verifique o conteúdo antes de executar exclusões automatizadas.
- Ao evoluir o projeto, considere migrar para uma versão mais recente do .NET e adotar um framework de logging (ex.: Serilog) para maior flexibilidade.

## Contribuição
Contribuições são bem-vindas. Abra uma issue para discutir mudanças ou envie um pull request com descrições claras das alterações.

## Licença
Este projeto está licenciado sob a licença MIT — consulte `LICENSE.txt` para mais detalhes.
