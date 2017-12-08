Skip to content


This repository
 
Pull requests 
Issues 
Marketplace 
Explore 



Sign out 


 Watch 
1 
 Star 
0 
 Fork 
0 

sabeersulaiman/InternsBackend 
 Code 
 Issues 0 
 Pull requests 0 
 Projects 0 
 Wiki 
 Insights 
Branch: master 
Find file 
Copy path
InternsBackend/WeekTwoAPI/Program.cs 
6a6bd81 14 days ago 
 sabeersulaiman Added Week Two Web API 
1 contributor 
 
Raw
Blame
History
   
26 lines (23 sloc) 602 Bytes 

using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore;

using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.Logging;



namespace WeekTwoAPI

{

    public class Program

    {

        public static void Main(string[] args)

        {

            BuildWebHost(args).Run();

        }



        public static IWebHost BuildWebHost(string[] args) =>

            WebHost.CreateDefaultBuilder(args)

                .UseStartup<Startup>()

                .Build();

    }

}
