# Demo Modelando Domínios Ricos em .NET Core

1. Introdução
2. Linguagem Obíquoa
3. Domínios ricos vs Domínios Anêmicos
4. Sub Domínios
5. Separação em Contextos Delimitados
6. Organizando a Solução
7. Definindo as Entidades
8. Corrupção no Código
9. SOLID e Clean Code
10. Primitive Obssesions
11. Value Objects
12. Implementando Validações
13. Design By Contracts
14. Testando as Entidades e VOs
15. Commands
16. Fail Fasdt Validations
17. Testando os Commands
18. Repository Pattern
19. Handlers
20. Testando os Handlers
21. Queries
22. Testando as suas Queries
23. Exemplo Prático


## Exemplo prático

Os passos abaixo foram realizados na plataforma MacOS.

- Abrir Visual Studio Code
- Criar pasta PaymentContext
- Abrir terminal dentro da pasta
- Criar o arquivo da Solution (.sln)

```
dotnet new sln
```
- criar as pastas abaixo:
```
mkdir pasta Paymentcontext.Domain
mkdir pasta Paymentcontext.Shared
mkdir pasta Paymentcontext.Tests
```
- Entrar dentro de cada pasta e criar o csproj do projeto
```
cd Paymentcontext.Domain
dotnet new classlib
cd ..

cd Paymentcontext.Shared
dotnet new classlib
cd ..

cd Paymentcontext.Tests
dotnet new mstest
cd ..
```
- Na raiz, adicionar os projetos criados na solution
```
dotnet sln add PaymentContext.Domain/PaymentContext.Domain.csproj
dotnet sln add PaymentContext.Shared/PaymentContext.Shared.csproj
dotnet sln add PaymentContext.Tests/PaymentContext.Tests.csproj 
```
Restaurar os pacotes
```
dotnet restore
```
Compilar para ver se esta ok
```
dotnet build
```
Adicionar referencia do projeto PaymentContext.Shared no PaymentContext.Domain

```
cd PaymentContext.Domain
dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj
cd ..
```
Adicionar referencias dos projetos PaymentContext.Shared e PaymentContext.Domain no PaymentContext.Tests
```
cd PaymentContext.Tests
dotnet add reference ../PaymentContext.Shared/PaymentContext.Shared.csproj 
dotnet add reference ../PaymentContext.Domain/PaymentContext.Domain.csproj
cd ..
```
Entrar na pasta PaymentContext.Domain e excluir o arquivo Class1.cs
```
cd PaymentContext.Domain
rm Class1.cs
```
Criar a pasta Entities
```
mkdir Entities
```
Entrar na pasta Entities e criar os arquivos:
```
touch Student.cs
touch Subscription.cs
touch Payment.cs
touch BoletoPayment.cs
touch CreditCardPayment.cs
touch PayPalPayment.cs
cd ..
```
Criar a pasta ValueObjects
```
mkdir ValueObjects
```
Entrar na pasta e criar os arquivos:
```
cd ValueObjects
touch Address.cs
touch Name.cs
touch Document.cs
tpuch Email.cs
cd ..
```
Criar a pasta Enums
```
mkdir Enums
```
Entrar na pasta e criar os arquivos:
```
touch EDocumentType.cs
```
Baixar o pacote Flunt executando comando na raiz do PaymentContext.Domain
```
dotnet add package flunt
```
Ir para a Pasta PaymentContext.Shared
```
cd ..
cd ..
mkdir Entities
cd Entities
touch Entity.cs
cd ..
```
Criar a pasta ValueObjects
```
mkdir ValueObjects
```
Entrar na pasta e criar os arquivos:
```
cd ValueObjects
touch ValueObject.cs
```
Baixar o pacote Flunt executando comando na raiz do PaymentContext.Shared
```
dotnet add package flunt
```
Ir para a Pasta PaymentContext.Tests
```
cd ..
cd ..
mkdir Entities
cd Entities
touch StudentTests.cs
```
Baixar o pacote Flunt executando comando na raiz do PaymentContext.Tests
```
dotnet add package flunt
```
