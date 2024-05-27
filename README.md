# laococoblazor

This is a system using Blazor as the frontend framework. It was talked to use the Microsoft stack as part of this system. Therefore, the system will be written in C#, ASP.NET, and Blazor as the main stack. If other technologies are needed, they will be implemented. （這個系統使用Blazor框架， 是一個前端的框架。 討論的時候同意使用微軟軟體堆疊。所以這個系統會使用C#， ASP.NET， Blazor，都是主要的堆疊。 如果別的程式語言或者框架需要用， 我們會使用。）

## How to try it on your machine (怎麼安裝在你的電腦)

1. Clone this repository into your local machine
2. Open your cloned repository using Visual Studio (You can use Visual Studio Code, but Visual Studio is recommended)
3. Install Entity Framework Tools
4. Add a file into your main directory, at the level of Program.cs, and named it as "appsettings.json".

Then, add the following: 
```
  {
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DatabaseConnection": "Server=yoursqlservername;Database=yourdatabase;User=yourusername;Password=yourpassword;TrustServerCertificate=True"
  },
  "AllowedHosts": "*"
}
```

Please change the information in "DatabaseConnection" to your database information.

### Note
If my database and your database are not the same. Please delete the "Models" folder. After deleting the "Models" folder, in your Visual Studio, go to Tools, NuGet Package Manager, and Package Manager Console.

#### Run the following command
```
Scaffold-DbContext -Connection "Server=yoursqlservername;Database=yourdatabase;User=yourusername;Password=yourpassword;TrustServerCertificate=True" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context LaococoDbContext
```

After running this command, you will get a folder called Models. Now, your database and Blazor application will be linked.
