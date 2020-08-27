


# ProjetoEmpresas
## Sobre: 
**ProjetoEmpresas** é um sistema cuja a finalidade é o cadastro de empresas a partir de seu CNPJ, onde através do CNPJ inserido é realizado uma busca das informações restantes em um serviço web publico, para que com essas informações finalize o cadastro</p>
## Pré-requisitos
- Possuir Visual Studio (Execução da WebAPI)
- Ter instalado NODE.js (Execução da Pagina web feita em React)
- SqlServer e SqlManagment Studio (Gerenciamento do Banco de dados

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
