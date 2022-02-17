dotnet new webapp -o TheGardenRoom
code -r TheGardenRoom
dotnet dev-certs https --trust
dotnet watch run
crtl+c
dotnet new page --name Flower --namespace TheGardenRoomFlower.Pages --output Pages
dotnet --list-sdks

dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.13
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.13
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.13
dotnet-aspnet-codegenerator razorpage -m Flower -dc RazorPagesFlowerContext -udl -outDir Pages/Flowers --referenceScriptLibraries -sqlite
dotnet watch run
ctrl+c
dotnet-aspnet-codegenerator razorpage -h

dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet watch run
ctrl+c

 