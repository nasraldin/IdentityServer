#  <copyright file="Dockerfile" project="WebApi" solution="IdentityService">
#      Copyright (c) 2020 Nasr Aldin.  All rights reserved.
#      Licensed under the MIT License, See LICENSE in the project root for license information.
#  </copyright>
#  <author>Nasr Aldin</author>
#  <email>nasr2ldin@gmail.com</email>
#  <github>https://github.com/nasraldin/IdentityServer</github>
#  <date>31/05/2020 01:00 AM</date>

#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["IdentityService.WebApi/IdentityService.WebApi.csproj", "IdentityService.WebApi/"]
RUN dotnet restore "IdentityService.WebApi/IdentityService.WebApi.csproj"
COPY . .
WORKDIR "/src/IdentityService.WebApi"
RUN dotnet build "IdentityService.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityService.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IdentityService.WebApi.dll"]