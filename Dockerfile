FROM microsoft/dotnet:latest

COPY . /app

WORKDIR /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build", "src/Calc"]

EXPOSE 5000/tcp

WORKDIR /app/src/Calc

CMD ["dotnet", "run", "--server.urls", "http://*:5000"]
