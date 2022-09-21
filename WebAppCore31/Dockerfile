FROM mcr.microsoft.com/dotnet/sdk:3.1-alpine AS publish
ARG NEXUS_USER_NAME
ARG NEXUS_USER_PASSWORD

WORKDIR /src
COPY . ./
# COPY ./nuget.config.template ./nuget.config

RUN dotnet restore "./ClassLibStandard.sln" --runtime alpine-x64
COPY . .
RUN dotnet publish "./WebAppCore31/WebAppCore31.csproj" -c Release -o /app/publish \
  --no-restore \
  --runtime alpine-x64 \
  --self-contained true \
  /p:PublishTrimmed=true \
  /p:PublishSingleFile=true

FROM mcr.microsoft.com/dotnet/runtime-deps:3.1-alpine AS final

# upgrade musl to remove potential vulnerability
RUN apk upgrade musl

WORKDIR /app
EXPOSE 80
COPY --from=publish /app/publish .

ENTRYPOINT ["./WebAppCore31", "--urls", "http://*:80"]