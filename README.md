# api-dotnet8-docker (RASPBERRY PI 4B)
API utilizando dotnet8 + docker

### 📋 Pré-requisitos
```
Visual Studio / Visual Code*
Docker 
Kubernetes
```

## 🔧 Execução utilizando Docker.
```
Ao baixar o projeto na pasta raiz, digite: 

docker build -t apidocker:1.0 .

Com a imagem criada execute o comando abaixo.
docker run --name apidocker -p 5003:5003 -e ASPNETCORE_URLS=http://+:5003 -e ASPNETCORE_ENVIRONMENT="Development" apidocker:1.0

OU

docker run --name apidocker -p 5003:8080 -e ASPNETCORE_ENVIRONMENT="Development" apidocker:1.0

No navegador utilize o link 
http:localhost:5003/swagger/index.html

```

## 🔧 Execução utilizando Docker Compose
```

Ao baixar o projeto na pasta raiz, digite:

docker-compose up

No navegador utilize o link 
http:localhost:5003/swagger/index.html


```

## 🔧 Execução kubectl 

```
Na pasta pipeline/k8s, digite:

kubectl apply -f .

```


## 🛠️ Construído com

* [ASPNET.CORE 8]
* [DOCKER]

## ✒️ Autores
* **Everton Souza** 

## 🎁 Expressões de gratidão
* Valeu pessoal, dúvidas é só chamar 📢;
* Um forte abraço 🎈;

---
⌨️ com ❤️ por [Everton Souza]