# Pastaruga Ninja

## Descrição

Pastaruga Ninja é uma aplicação console desenvolvida em C# (.NET Framework 3.5) para automatizar a criação de pastas em um diretório especificado pelo usuário. O projeto também implementa um sistema de log para registrar todas as operações realizadas, facilitando o acompanhamento e a identificação de possíveis erros.

## Funcionalidades

- Criação automática de uma nova pasta em um diretório existente.
- Registro detalhado das operações e erros em arquivos de log.
- Validação dos argumentos fornecidos na linha de comando.

## Download

Você pode baixar o executável compilado clicando no link abaixo:

[Download do Pastaruga Ninja](https://github.com/mayconwisley//PastarugaNinja/raw/refs/heads/master/exe/PastarugaNinja.exe)

## Como usar

1. **Pré-requisitos**  
   - .NET Framework 3.5 instalado.
   - Visual Studio 2022 ou compatível.

2. **Execução**  
   Execute o programa via linha de comando, fornecendo dois argumentos:
   - O caminho do diretório onde a nova pasta será criada.
   - O nome da nova pasta.

   **Exemplo:**
   - PastarugaNinja.exe "C:\MeusDocumentos" "NovaPasta"
  
3. **Logs**  
Os logs são gerados na mesma pasta do executável, com nome no formato: 
`yyyy-MM-dd HHh - Log Pastaruga Ninja.log`

## Estrutura do Projeto

- `Program.cs`: Ponto de entrada da aplicação. Valida os argumentos e chama os métodos principais.
- `CriarPasta.cs`: Responsável pela criação da nova pasta.
- `CriarLog.cs`: Gerencia a criação e escrita dos logs.

## Observações

- Se o diretório informado não existir, nenhuma pasta será criada.
- Caso ocorram erros, eles serão registrados no arquivo de log correspondente.
- O projeto foi desenvolvido para fins didáticos e pode ser expandido conforme a necessidade.

## Licença

Este projeto está sob a licença MIT.
