FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY Vote.csproj .
RUN dotnet restore "Vote.csproj"
COPY . .

FROM build AS publish
RUN dotnet publish "Vote.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf
