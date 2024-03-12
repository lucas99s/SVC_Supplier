# Introdução

Nosso projeto visa oferecer uma solução baseada em software para o setor de vendas entre comércios, facilitando a comunicação entre empresas de pequeno e médio porte e os fornecedores. Como metodologia, nós realizamos pesquisas envolvendo o setor de vendas e identificamos que negócios de pequeno e médio porte encontram dificuldades em encontrar fornecedores que ofereçam um valor acessível e que disponibilizem a mercadoria em menor quantidade, com isto em mente nós desenvolvemos o SVC Supplier, cujo objetivo é facilitar a interação entre empresa e fornecedor. Escolhemos desenvolver uma aplicação em web que irá ser executada direto nos navegadores de internet, sendo acessível a partir de computador desktop ou smartphone. A versão apresentada neste projeto da aplicação tem como função demonstrar a funcionalidade de pesquisa e compra de mercadoria, tomando como exemplo uma loja de construção que precisa repor seu estoque, a partir deste cenário nós conseguimos demonstrar o processo de cadastro na ferramenta, de pesquisa e de compra da mercadoria desejada.

# Abstract

Our project aims to provide a software-based solution for the B2B sales sector, streamlining communication between small and medium-sized businesses and their suppliers. In our methodology, we conducted research within the sales sector and identified challenges faced by small and medium-sized enterprises in finding affordable suppliers that offer goods in smaller quantities. With this insight, we developed SVC Supplier, with the goal of facilitating the interaction between companies and suppliers. We chose to create a web application that runs directly in internet browsers, making it accessible from both desktop computers and smartphones. The version presented in this project focuses on demonstrating the functionality of searching and purchasing merchandise. Using the example of a construction supply store needing to replenish its inventory, we illustrate the tool's registration, search, and purchase processes within this specific scenario.

# Instruções para execução da aplicação

- Abrir o arquivo SVC_Supplier.sln, no Visual Studio.
- Executar o código através do botão "IIS Express", localizado na parte superior da ferramenta.
- A aplicação ira ser iniciada no browser.

# Requisitos necessários para execução

- Instalação do Visual Studio 2022.
- Versão 7 do SDK.NET (Disponível em: <https://dotnet.microsoft.com/pt-br/download/visual-studio-sdks>).

# Vídeo Demonstrativo

Link: ([https://www.youtube.com/watch?v=ScKFXl6FtBo](https://www.youtube.com/watch?v=ScKFXl6FtBo ))

# Funcionalidades Implementadas

### Tela inicial

Através dessa tela duas opções serão habilitadas ao usuário

- Efetuar o Login através do botão "Entrar"
- Caso não possua cadastro, o usuário poderá cadastrar um usuário através da opção "Cadastrar".

### Tela de login

Através dessa tela o usuário irá efetuar o acesso à ferramenta, esta tela ira permitir ao usuário. Efetuar acesso à ferramenta, informando e-mail e senha cadastrados previamente. Caso o e-mail informado não esteja cadastrado, a ferramenta irá alertar que o perfil não existe. Caso a senha informada seja diferente da cadastrada, a ferramenta irá alertar que a senha informada é invalida.
### Tela de cadastro

Através dessa tela o usuário ira efetuar o cadastro na ferramenta, esta tela possui as seguintes funções. Cadastro do usuário informando (Nome da Empresa, CNPJ, E-mail e Senha). Caso o usuário informe um e-mail já cadastrado, a ferramenta irá mostrar um alerta informando o usuário. Caso o usuário coloque uma senha diferente no campo "Confirmar Senha" da senha informada anteriormente, a ferramenta irá mostrar um alerta, informando o usuário que a informação esta divergente. A senha informada pelo usuário deve conter no mínimo 8 caracteres, caso esse critério não seja atendido a ferramenta irá mostrar um alerta, informando que a senha não se encaixa no padrão estabelecido.

### Tela de menu principal

No menu principal do aplicativo será apresentada uma barra de pesquisa e uma seção listando as categorias mais acessadas no app. Na parte inferior é apresentado um menu de navegação para o usuário com as opções "Inicio", "Pedidos", "Ofertar", "Perfil".

### Tela de listagem de produtos

Ao utilizar a barra de pesquisa, ou selecionar umas das opções de categorias de produto mais procurados o usuário é apresentado uma lista dos produtos sendo ofertados dentro da categoria ou produto pesquisado.

###  Tela de detalhes do produto

Após ser selecionado o produto desejado o aplicativo irá apresentar uma tela com os detalhes do produto, Nesta etapa o usuário deve informar a quantidade desejada e selecionar uma das duas opções disponibilizadas “Efetuar Pedido” ou “Enviar Mensagem”.

### Tela de mensagem ao vendedor

Ao selecionar a opção de “Enviar mensagem” na tela de detalhe do produto será apresentada uma tela para que a mensagem seja digitada para o vendedor e em seguida enviada.

 ### Confirmação de compra e seleção dos métodos de pagamento

Ao selecionar a opção de “Efetuar pedido” na tela de detalhe do produto, será apresentada uma tela com os detalhes do pedido, e os métodos de pagamento serão apresentados ao usuário.

### Tela de Preenchimento dos dados de entrega e pagamento

Após a seleção do método de pagamento será apresentado um formulário onde o usuário deverá preencher os dados solicitados, no exemplo que iremos abordar, o método implementado foi o de pagamento por cartão de crédito.

### Tela de confirmação do pagamento

Após o pagamento ser realizado, irá aparecer uma tela informando que o pagamento foi efetuado com sucesso. Esta tela oferece uma opção ao usuário para ir diretamente para a sessão onde os produtos são listados.

### Tela de histórico de pedidos

Através da parte inferior o usuário tem acesso a uma opção chamada “Pedidos” esta opção traz um histórico das compras realizadas.

### Tela de Detalhes do pedido

Ao selecionar um dos pedidos apresentado na tela de histórico de pedidos irá ser apresentado os detalhes da compra que foi realizada.

### Tela de cadastro de pedidos

Através da parte inferior o usuário tem acesso a uma opção chamada “Ofertar” esta opção traz uma tela onde é possível iniciar o cadastro de uma oferta de produto.

### Tela de Perfil

Através do menu inferior, ao selecionar o botão “Perfil”, o usuário é direcionado a tela com as opções de perfil do usuário, através dessa tela é disponibilizada a opção “Sair”, para que o usuário possa fechar a aplicação.



# Integrantes 

#### Grupo 06

- Daiane Dias Alves
- Danilo Sanchez Pereira
- Henrique Silva Torres
- Juliana Zanella Sanches
- Lucas Rodrigues da Silva
- Luis Gustavo Pinheiro da Silva
