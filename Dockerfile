FROM mcr.microsoft.com/dotnet/core/sdk:2.1
WORKDIR /

# copy csproj and restore as distinct layers
COPY appdotnet/*.sln .
COPY appdotnet/Puc.Atividade7.Application/*.csproj Puc.Atividade7.Application/
COPY appdotnet/Puc.Atividade7.Domain/*.csproj Puc.Atividade7.Domain/
#COPY appdotnet/Puc.Atividade7.Frontend/*.csproj ./Puc.Atividade7.Frontend/
COPY appdotnet/Puc.Atividade7.Infra.Data/*.csproj Puc.Atividade7.Infra.Data/
COPY appdotnet/Puc.Atividade7.Service/*.csproj Puc.Atividade7.Service/

RUN dotnet restore

# copy everything else and build app
COPY appdotnet/. .
WORKDIR /Puc.Atividade7.Application/
RUN dotnet publish -c Release -o out


#FROM mcr.microsoft.com/dotnet/core/runtime:2.1
WORKDIR /Puc.Atividade7.Application/out/
#COPY --from=jonas out ./
ENTRYPOINT ["dotnet", "Puc.Atividade7.Application.dll"]
#ENTRYPOINT ["bash"]
#CMD ["watch", "-n1", "ls"]
#CMD ["dotnet", "out/dotnetapp.dll"]

