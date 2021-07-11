FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ConsoleProjectByHeadFirst/ConsoleProjectByHeadFirst.csproj", "ConsoleProjectByHeadFirst/"]
RUN dotnet restore "ConsoleProjectByHeadFirst/ConsoleProjectByHeadFirst.csproj"
COPY . .
WORKDIR "/src/ConsoleProjectByHeadFirst"
RUN dotnet build "ConsoleProjectByHeadFirst.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleProjectByHeadFirst.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleProjectByHeadFirst.dll"]
