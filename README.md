# :computer: MySQL Best Buy Database - ORM & DAPPER

By using Dapper, we can significantly reduce the amount of coding required for database writes. In this instance, I am using MySQL - Best Buy database (totally made up fields of course :robot: ) as an example.

I created a .Net Core Console Application, added appsettings.json (with Git ignore), then added 3 Nuget packages: Dapper, Microsoft.Extensions.Configuration.Json package, 
and MySql.Data to config and connection string. I then created using C# the Class, IEnumerable Repository Interface, Repository Class, and Methods. 

Dapper is a .NET compatible, NuGet library ORM that you can add to your project that will extend your IDbConnection interface. The Dapper Execute is designed for any database 
writes, like INSERT, UPDATE, and DELETE.

<h2> Reduce the amount of Code you write with Dapper: </h2>
Here is a side by side comparison of just using MySqlConnection (left) vs using Dapper (right):
You might notice how much code is reduced by using the Dapper implementation!

![sql vs dapper](https://user-images.githubusercontent.com/107009879/187290213-ba053a08-a34b-4236-8fe8-9076e072a3eb.jpg)

<h2> Here's a snippet of the command when run: </h2>

![console1](https://user-images.githubusercontent.com/107009879/187292177-981508cf-88d5-42ab-989e-6a43434fdc4b.jpg)
![console2](https://user-images.githubusercontent.com/107009879/187292184-be2a3604-de72-437f-a0f0-3870b0edf4f5.jpg)


<h2> Here's a snippet of My SQL: </h2>

![sql](https://user-images.githubusercontent.com/107009879/187290419-66c5aba1-77fe-42a2-bc65-44d6f7ed396c.jpg)

<h2> Here's a snippet of my C# Code: </h2>

![code](https://user-images.githubusercontent.com/107009879/187290975-f2ff9d66-175f-4d2b-8210-e4234985aa03.jpg)


I implemented ORM Dapper into my final project so please check it out! https://github.com/nancylee1/FinalProject.ASP.NET.CoreMVC-LoveLeeLuxWebStore

Feel free to connect with me here on GitHub or on LinkedIn (www.linkedin.com/in/nancylee7). Thanks for checking this out! 
