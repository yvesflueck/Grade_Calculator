FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Grade_Calculator/Grade_Calculator.csproj", "Grade_Calculator/"]
RUN dotnet restore "Grade_Calculator/Grade_Calculator.csproj"
COPY . .
WORKDIR "/src/Grade_Calculator"
RUN dotnet build "Grade_Calculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Grade_Calculator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Grade_Calculator.dll"]
