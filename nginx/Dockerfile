FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src

COPY RecruitManage/RecruitManage.csproj RecruitManage/
COPY RecruitManage.Domain/RecruitManage.Domain.csproj RecruitManage.Domain/
COPY RecruitManage.IRepositories/RecruitManage.IRepositories.csproj RecruitManage.IRepositories/
COPY RecruitManage.Repository/RecruitManage.Repository.csproj RecruitManage.Repository/
COPY RecruitManage.Services/RecruitManage.Services.csproj	RecruitManage.Services/

RUN dotnet restore RecruitManage/RecruitManage.csproj

COPY . .

# set up node
RUN apt-get update -yq && apt-get upgrade -yq && apt-get install -yq curl git nano
RUN curl -sL https://deb.nodesource.com/setup_8.x | bash - && apt-get install -yq nodejs build-essential

WORKDIR /src/RecruitManage

RUN dotnet publish -c release -o /publish

FROM base as Final
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet","RecruitManage.dll"]