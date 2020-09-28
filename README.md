


# ProjetoEmpresas
## Sobre: 
**ProjetoEmpresas** é um sistema cuja a finalidade é o cadastro de empresas a partir de seu CNPJ, onde através do CNPJ inserido é realizado uma busca das informações restantes em um serviço web publico, para que com essas informações finalize o cadastro</p>

## Funcionalidades
- Cadastro de Empresas
	> - Validações antes do registro
- Consulta de Empresas
	> - Consulta geral (Listando todas empresas cadastradas)
	> - Consulta por CNPJ
	> - Consulta por Id
- Exclusão de Empresas
## Linguagens, dependências e libs utilizadas
- .NET Core 3.1
- Entity Framework
- React
- Axios
- Bootstrap
- Font-awesome
- React-Router
 
## Pré-requisitos

 - [x] Possuir Visual Studio (Execução da WebAPI)

 - [x] Ter instalado NODE.js (Execução da Pagina web feita em React)
 - [x] SqlServer e SqlManagment Studio (Gerenciamento do Banco de dados)

## Importando o banco de dados
Primeiramente acrescente o banco de dados em seu servidor local, através do SqlManagment Studio:
- Clique em "Importar Aplicativo da Camada de Dados..."

<img src = "https://ik.imagekit.io/ryanraul/print1_ZyxbRvgoh.jpg">

- Em seguida selecione o diretório onde esta o  banco de dados clicando no botão destacado:

<img src = "https://ik.imagekit.io/ryanraul/_55BC2230-E8D9-44F6-9EF7-EC944996AF97_.png_5JQu1bMyQL.jpg">

- Após encontrar o arquivo  **".bacpac"** referente ao banco das empresas, abra-o.

<img src = "https://ik.imagekit.io/ryanraul/_C1DB0D7D-24FA-40CF-9BCA-806A73AA7EE2_.png_1A-Nj7PGN.jpg">

- Em seguida renomeie o banco para "BDEmpresas":

<img src = "https://ik.imagekit.io/ryanraul/print2_KDiv_HwSb.jpg">

## Problemas de conexão
- Ao executar a API, verifique a porta em que esta sendo executada, certifique-se de que a porta é a mesma da que esta sendo referenciada na "baseURL" do arquivo api.js (.../empresaviews/src/Api/api.js).

<img src = "https://ik.imagekit.io/ryanraul/print3_2ddoLZKYfJ.jpg">

## Melhorias

- Aplicação do PascalCase nas propriedades da Classe Empresa
	> **Motivo:** Facilidade na leitura e atende aos regulamentos indicado pela Microsoft's .NET Framework
	
- Retirar algumas abreviações atribuidas em variaveis locais
	> **Motivo:** Prevenção de abreviações inconsistentes e atende aos regulamentos indicado pela Microsoft's .NET Framework
		
- Criação de um metodo para verificar se a empresa foi encontrada
	> **Motivo:** Evitar duplicação de código
			
- Retirar o uso do "_" (underline) nos nomes das variaveis
	> **Motivo:** Atende aos regulamentos indicado pela Microsoft's .NET Framework e torna o código mais natural para leitura
			
- Criação de um metodo para verificar se a CNPJ ja foi cadastrado
	> **Motivo:** Evitar duplicação de código
	
- Refatorar código de consulta por ID e CNPJ
	> **Motivo:** Evitar duplicação de código e melhorar leitura do codigo
	
- Criação de um método para realizar a requisicao para a ReceitaWS
	> **Motivo:** Melhorar estrutura do codigo e facilitar a leitura
	
- Criação de um método que retorne uma lista de empresas
	> **Motivo:** Evitar duplicação de código
	
- Alterando arquitetura do projeto
	> **Motivo:** Facilitar futuras manutenções e evitar acoplamentos
	
- Separar responsabilidades nas camadas:
	- Application
	- Domain
	- Infrastructure
	
- Camada Application:
	- APIController
	> - Requisições  (Post, Get e Delete)
	- Mapping
	> - Realizar mapeamento da classe que recebe as informações da requisição da WebService para a entidade que irá ser armazenada no banco


- Camada Domain:
	- Entities
	> - Entidades que serão refletidas no banco de dados
	- Models
	> - Classe que ira guardar as informações requisitadas no WebService externo para que depois seja mapeada para a entidade
	- Handlers
	> - Ira manipular algumas funcionalidades do dominio
	- Repository
	> - Chamada das operações realizadas no banco de dados (Repositorio)

- Camada Infrastructure: 
	- Queries
	> - Consultas realizadas no banco de dados indicado no DataContext
	- Services
	> - Utilização de serviço externo, nesse caso a Requisição ao WebService
	- DataContext
	> - Informções sobre o banco de dados a ser utilizado