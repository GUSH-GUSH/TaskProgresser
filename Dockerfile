FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["TaskProgresser.Api/TaskProgresser.Api.csproj", "TaskProgresser.Api/"]
COPY ["TaskProgresser.Core/TaskProgresser.Core.csproj", "TaskProgresser.Core/"]

RUN dotnet restore "TaskProgresser.Api/TaskProgresser.Api.csproj"

COPY . .

WORKDIR "/src/TaskProgresser.Api"
RUN dotnet build "TaskProgresser.Api.csproj" -c Release -o /app/build
RUN dotnet publish "TaskProgresser.Api.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "TaskProgresser.Api.dll"]
