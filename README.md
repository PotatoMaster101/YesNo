# Yes No
A clone of [yesno.wtf/api](https://yesno.wtf/api) in [.NET 8](https://dotnet.microsoft.com/en-us/download).

## Running (Docker)
1. Create dotnet dev cert
```sh
dotnet dev-certs https -ep "$HOME/.aspnet/https/auth.pfx" -p "Password123!"
dotnet dev-certs https --trust
```
2. Compose container: `docker compose up -d --build`
3. Visit `https://localhost/api`
