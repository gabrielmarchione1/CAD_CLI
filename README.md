# Sistema de Cadastro de Clientes - CadCli

Este projeto é um **sistema de cadastro de clientes** desenvolvido em **C#** utilizando **Windows Forms** e **SQL Server** para o armazenamento de dados. O sistema segue o padrão de **programação em camadas**, separando as responsabilidades em **interface**, **negócios**, **dados** e **entidades**. A arquitetura em camadas contribui para um sistema mais seguro e de fácil manutenção, garantindo que a lógica de negócios e o acesso aos dados estejam melhor protegidos.

## Funcionalidades

- Cadastro de clientes
- Cadastro de endereço do cliente
- Cadastro de telefones do cliente
- Cadastro de emails do cliente
- Visualização e gerenciamento de registros

Cada módulo do sistema possui uma interface dedicada para cadastro e edição de dados, garantindo uma interface intuitiva e organizada.

## Estrutura do Projeto

O projeto é dividido nas seguintes camadas:

1. **Interface (UI)**: Contém as telas do sistema desenvolvidas com **Windows Forms**.
2. **Negócios (Business Logic)**: Implementa as regras de negócio do sistema.
3. **Dados (Data Access)**: Gerencia o acesso ao banco de dados SQL Server (Consultas).
4. **Entidades**: Define as classes que representam as entidades das tabelas (Cliente, Endereço, Telefone, Email).

## Tecnologias Utilizadas

- **C#**
- **Windows Forms**
- **SQL Server**
- **Arquitetura em camadas**

**Vídeo do projeto:** https://www.linkedin.com/posts/gabriel-marchione_csharp-windowsforms-sql-activity-7245504798609854464-zj55?utm_source=share&utm_medium=member_desktop
