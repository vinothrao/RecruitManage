FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["RecruitManageAPI/RecruitManageAPI.csproj", "RecruitManageAPI/"]
RUN dotnet restore "RecruitManageAPI/RecruitManageAPI.csproj"
COPY . .
WORKDIR "/src/RecruitManageAPI"
RUN dotnet build "RecruitManageAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RecruitManageAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RecruitManageAPI.dll"]