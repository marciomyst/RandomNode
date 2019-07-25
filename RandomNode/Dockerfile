FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["RandomNode/RandomNode.csproj", "RandomNode/"]
RUN dotnet restore "RandomNode/RandomNode.csproj"
COPY . .
WORKDIR "/src/RandomNode"
RUN dotnet build "RandomNode.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RandomNode.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RandomNode.dll"]