# NerdFlix
 NerdFlix is a movie streaming app built in ASP .NET Core MVC

# Steps to run the project locally

 1. Install Prerequisites(packages)
    -Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter
    - Microsoft.AspNetCore.Identity.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.Tools
    - Microsoft.VisualStudio.Web.CodeGeneration.Design
    
 3. Clone the Project
 4. Open Project in Code Editor (Visual Studio 2022)
 5. Restore Dependencies
    
         $ dotnet restore
    
 6. Build the Project
    
         $ dotnet build
    
 7. Run the project
 
         $ dotnet run
    
 8. Database Migrations

    
          $ dotnet ef migrations add InitialCreate
          $ dotnet ef database update


- After you run Database Migrations, Check the server to see if the database has been created and tables

  
## Authors

👤 **Brenda Wihogora**

- GitHub: [@Brenda309](https://github.com/Brenda309)
- Twitter: [@BrendaWihogora](https://twitter.com/BrendaWihogora)
- LinkedIn: [BrendaWihogora](https://linkedin.com/in/BrendaWihogora/)


      


