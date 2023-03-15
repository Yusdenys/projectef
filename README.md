# projectef
dotnet ef migrations add InitialCreate
dotnet ef migrations add MyMigration
dotnet ef database update 

dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef

dotnet ef database update - Comando para ejecutar cada vez que deseamos actualizar la migracion a bd