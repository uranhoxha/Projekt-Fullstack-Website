# Projekt-Fullstack-Website

To run the app you should:

1. Go to appsettings.json file
   At the "PlantConnectionString" change the server name to your SSMS server name

2. Delete Migrations folder and do your migration to database
   To do migration we should go to: Tools > NuGet Package Manager > Package Manager Console
   At the cosole run command: Add-Migration "\[a name for the migration\]"
   After that run command: Update-Database  
