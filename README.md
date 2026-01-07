# ClinicaMedica
Uma API web para gerenciamento de médicos e consultas de uma clinica


# Técnologias utilizadas
    - .NET Core 8;
    - Banco de dados em memória;

# Arquitetura/Organização Seguida
    A API foi organizada em uma estrutura simples com base no DDD, onde temos as controllers, os useCases(Casos de uso), os serviços, a infra e os modelos.
    Quando ocorre uma chamada na controller, a API segue o seguinte fluxo:
        Controller -> UseCase -> Service -> Infra
    
    A controller recebe a requisição e utiliza os DTOs para chamar os UseCases. O UseCase aplica as regras de negócio e valida as requisições.
    Com isso, a requisição chega aos Serviços, onde por fim é chamado o banco de dados (Infra).

# Regras de Negócio
    - Uma consulta só pode ser registrada se o medico e o paciente já existirem no banco de dados. Caso negativo, retorna um BadRequest.
    - Uma consulta só pode ser registrada se o médico e o paciente estiverem livres na data informada. Caso negativo, retorna um BadRequest.
    - As atualizações só refletem nos campos informados na requisição, e se eles estiverem diferentes dos valores atuais.

# Como Rodar o Projeto
    Como a API utiliza de um banco de dados em memoria, ao rodar a aplicação no seu Visual Studio ele será automaticamente iniciado.