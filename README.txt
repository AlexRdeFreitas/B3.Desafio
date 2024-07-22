Investment Calculator
Descrição
Este projeto é uma aplicação web que calcula o resultado bruto e líquido de um investimento com base em um valor monetário e um prazo em meses. A aplicação é composta por um frontend Angular e um backend ASP.NET Core. O frontend coleta os dados do usuário e exibe os resultados, enquanto o backend realiza os cálculos e fornece as respostas.

Estrutura do Projeto
Frontend (Angular): Uma aplicação Angular que fornece a interface do usuário para inserir dados e visualizar os resultados.
Backend (.NET Core): Um serviço Web API construído com ASP.NET Core que processa os dados do investimento e retorna os resultados calculados.
Funcionalidades
Inserir valor monetário e prazo em meses para calcular o investimento.
Exibir o resultado bruto e líquido do investimento.
Validação de entradas para garantir que o valor seja positivo e o prazo maior que 1 mês.
Tecnologias Utilizadas
Frontend: Angular (TypeScript, HTML, CSS)
Backend: ASP.NET Core (C#)
Database: Não utilizado (dados calculados em tempo real)
Ferramentas de Construção: .NET CLI, Angular CLI
Pré-requisitos
Node.js (Para rodar o Angular)
.NET SDK (Para rodar o backend .NET Core)
Configuração e Execução
Backend (.NET Core)
Clone o repositório:

bash
Copiar código
git clone https://github.com/username/investment-calculator.git
cd investment-calculator/InvestmentCalculatorAPI
Restaure os pacotes e execute o backend:

bash
Copiar código
dotnet restore
dotnet run
O backend estará disponível em https://localhost:5001.

Frontend (Angular)
Navegue para o diretório Angular:

bash
Copiar código
cd ../investment-calculator
Instale as dependências do Angular:

bash
Copiar código
npm install
Inicie o servidor de desenvolvimento Angular:

bash
Copiar código
ng serve
O frontend estará disponível em http://localhost:4200.

Uso
Abra a aplicação Angular no navegador (http://localhost:4200).
Preencha o formulário com um valor monetário positivo e um prazo em meses maior que 1.
Clique em "Calcular Investimento" para obter o resultado bruto e líquido.
Veja os resultados exibidos na mesma página.
Testes
Backend (.NET Core)
Navegue até o diretório de testes:

bash
Copiar código
cd ../InvestmentCalculatorAPI.Tests
Execute os testes:

bash
Copiar código
dotnet test
Para verificar a cobertura de testes:

bash
Copiar código
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
Frontend (Angular)
Execute os testes do Angular:

bash
Copiar código
ng test
Contribuição
Sinta-se à vontade para abrir problemas e pull requests. Para contribuir, faça o fork do repositório e envie suas alterações.

Licença
Este projeto está licenciado sob a MIT License.