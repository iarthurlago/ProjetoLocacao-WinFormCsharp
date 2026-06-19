# Sistema de Gestão de Locações (RBAC)

## O que é este projeto
Este projeto é um sistema de software desktop para gestão de locações, construído em C# com Windows Forms. Ele representa a evolução de um CRUD em memória para um produto de software real, implementando persistência de dados definitiva, autenticação de usuários e um rigoroso Controle de Acesso Baseado em Papéis (RBAC).

O domínio do sistema permite o cadastro de Clientes, a gestão de Itens e o registro de Locações (unindo cliente e item com cálculo de diárias).

---

## Arquitetura em Camadas
O projeto foi estritamente desenhado utilizando uma arquitetura em camadas para separar responsabilidades, garantindo um código limpo e manutenível:

* **Models (Classes):** Representação pura do domínio (Cliente, Item, Locacao, Usuario) e regras estruturais.
* **Repositories:** Camada exclusiva para comunicação com o banco de dados. Nenhum comando SQL vaza para as regras de negócio.
* **Services:** O "cérebro" do sistema. Concentra todas as regras de negócio e validações de segurança antes de permitir qualquer persistência.
* **Forms (UI):** Interfaces visuais responsáveis apenas por capturar e exibir dados, reagindo ao estado da sessão atual.
* **Data:** Gerenciamento da string de conexão e infraestrutura do banco.

---

## Controle de Acesso (RBAC)
O sistema implementa o padrão *Role-Based Access Control* (RBAC). A segurança não depende apenas de botões desabilitados na interface; ela é validada ativamente na camada de `Service` antes de qualquer transação no banco. 

O sistema conta com três papéis fixos:

| Papel | Permissões no Sistema |
| :--- | :--- |
| **Visualizador** | Apenas lê os dados. Vê as listagens de clientes, itens e locações, mas não cria, edita ou exclui nada. |
| **Operador** | Lê e escreve no domínio. Faz o CRUD completo de locações, clientes e itens, mas não gerencia usuários. |
| **Admin** | Controle total. Faz tudo do Operador e ainda possui acesso exclusivo para cadastrar novos usuários e definir seus papéis. |

---

## Segurança e Persistência

* **Banco de Dados Embutido:** Utiliza o **SQLite** (`Microsoft.Data.Sqlite`). O banco de dados vive em um único arquivo local (`.sqlite`), sem necessidade de servidor externo, operando de forma perfeitamente integrada à aplicação desktop.
* **Criptografia de Senhas:** Em nenhum momento o sistema guarda senhas em texto puro. A autenticação utiliza a biblioteca **BCrypt** para aplicar *hashing* e *salting* criptográfico no momento do cadastro e da verificação de login.

---

## Tecnologias Utilizadas
* C# (.NET)
* Windows Forms (WinForms)
* SQLite
* BCrypt.Net-Next

---

## Como Executar o Projeto

1. Faça o clone deste repositório em sua máquina local.
2. Abra o arquivo `.sln` no Visual Studio.
3. Certifique-se de restaurar os pacotes NuGet (o Visual Studio geralmente faz isso automaticamente ao compilar).
4. Execute o projeto (`F5`). O banco de dados SQLite será gerado automaticamente na pasta `bin/Debug` caso seja a primeira execução.
5. Utilize as credenciais de um usuário Administrador para acessar o sistema completo e cadastrar novos operadores ou visualizadores. 
