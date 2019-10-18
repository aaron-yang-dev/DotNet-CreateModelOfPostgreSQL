using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateModelOfPostgreSQL
{
    public class MyScaffoldingDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection services)
        {
            // override the defautlt naming service
            services.AddSingleton<ICandidateNamingService, MyScaffoldingCandidateNamingService>();
        }
    }

    // Not officially supported. Using this is "I know what I'm doing" territory
    public class MyScaffoldingCandidateNamingService : CandidateNamingService
    {
        public override string GenerateCandidateIdentifier(DatabaseColumn originalColumn)
        {
            Console.WriteLine("Naming request: " + originalColumn.Name);

            // original will be the table name, column name, index name, etc.
            // In this override, you are free to do whatever you want.
            // the base class will return PascalCase
            //var pascalCaseify = base.GenerateCandidateIdentifier(original);
            //return pascalCaseify;
            
            return originalColumn.Name;
        }
    }
}
