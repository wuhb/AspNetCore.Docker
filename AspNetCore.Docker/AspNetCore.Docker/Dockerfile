# --- build ---

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 as publish

ADD . /src

WORKDIR /src

RUN dotnet publish -c Release -o /app

# --- prod ---

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 as prod

MAINTAINER v7lin <v7lin@qq.com>

COPY --from=publish /app /app

WORKDIR /app

EXPOSE 80

ENTRYPOINT ["dotnet", "AspNetCore.Docker.dll"]
