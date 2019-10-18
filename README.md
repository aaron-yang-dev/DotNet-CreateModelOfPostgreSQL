# DotNet-CreateModelOfPostgreSQL

參考: https://github.com/arichika/EFCore2.0-Scaffold-DBContext-CustomCandidateNamingService/tree/master/src/ScaffoldMyDb

需安裝 Npgsql.EntityFrameworkCore.PostgreSQL


Scaffold-DbContext -Connection "Server=your server;Port=your port;Database=your db;User id=your id;Password=your password;" -Provider  Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir EntityModels -Force
