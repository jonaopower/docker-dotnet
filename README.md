# .NET Core em Docker
## Exemplo de como utilizar


#### Passos

Clone o repositório git docker-dotnet  
`$ git clone https://github.com/jonaopower/docker-dotnet.git`

Crie a imagem com o nome desejado utilizando o arquivo Dockerfile.
Neste exemplo, chamamos nossa imagem de "***meu_app_dot_net***" cuja versão será "***v1.0***"
`$ docker build -t meu_app_dot_net:v1.0 .`

Crie um container utilizando a imagem recém criada. 
Este container será publicado na porta 8000/tcp do host.

`$ docker run -d -it --rm -p 8000:80 --name dot_net_app mcr.microsoft.com/dotnet/core/samples:aspnetapp`
