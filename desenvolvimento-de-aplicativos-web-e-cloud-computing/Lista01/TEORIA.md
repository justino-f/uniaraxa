1 - a) Um controller é o componente de uma API que expõe as rotas para acessar o serviço específico determinado no código, usa-se para expor operações HTTP que interagem com outros componentes dentro do código-fonte da aplicação; Um model é o componente de um objeto dentro da lógica de negócio que persiste na aplicação durante a execução, é a especificação da classe do objeto. No contexto da Aula01, o ControllerBase permite com que os métodos da classe do controller retornem um status HTTP em suas responses.

b) A rota GET é read-only, majoritariamente retorna elementos visuais de front-end, para a execução de um POST sem interação com componentes gráficos em um web app, é necessário um Swagger que faça a requisição via console.

2 - a) POST | b) DELETE | c) GET | d) GET | e) PUT | f) PUT

3 - OK (200) é quando a request foi processada e houve uma response adequada;
Bad Request (400) é quando a sintaxe da request está incorreta, e o servidor não compreende;
Not Found (404) é quando o endpoint que a request chama não existe ou está incorreto.

4 - https:// é o procolo HyperText Transfer Protocol Secure, atua na porta 443, a versão com criptografia assimétrica em trânsito do protocolo HTTP.

minhaapi.com.br é o domínio (minhaapi) e o controlador (.com.br), é o DNS legível para usuários que posteriormente será convertido para um endereço de IP.

/api/vendas é o endpoint da API Vendas, provavelmente de um arquivo VendasController, é como o usuário interage com a API de Vendas naquela rota específica.

