# ЭТАП 1: КУХНЯ (Сборка)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копируем списки покупок
COPY ["TaskProgresser.Api/TaskProgresser.Api.csproj", "TaskProgresser.Api/"]
COPY ["TaskProgresser.Core/TaskProgresser.Core.csproj", "TaskProgresser.Core/"]

# Идем в магазин за ингредиентами
RUN dotnet restore "TaskProgresser.Api/TaskProgresser.Api.csproj"

# Приносим всё остальное (сам код)
COPY . .

# Готовим и упаковываем по коробкам
WORKDIR "/src/TaskProgresser.Api"
RUN dotnet build "TaskProgresser.Api.csproj" -c Release -o /app/build
RUN dotnet publish "TaskProgresser.Api.csproj" -c Release -o /app/publish

# ЭТАП 2: ВИТРИНА (Запуск)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Переносим готовые коробки с кухни на витрину
COPY --from=build /app/publish .

# Вывеска "Мы открыты"
ENTRYPOINT ["dotnet", "TaskProgresser.Api.dll"]
