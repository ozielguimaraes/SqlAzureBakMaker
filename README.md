# SqlAzureBakMaker
This project is designed to provide a simple framework to create a .BAK File from a SQL Azure database. 

## Native Support?
The platform doesn't have native support to create .bak files from SQL Azure databases, today. If you would like to see native support please up vote it here: https://feedback.azure.com/forums/217321-sql-database/suggestions/10460739-backup-restore-to-from-bak-file

## How it works
The project utilized a bit of SQL Server Management Objects (SMO) magic to automate the following steps:

1. Create a local database
2. Copy the schema from SQL Azure to the local db
3. Copy the data from SQL Azure to the local db
4. Create a backup of the local db to the local disk

## Getting Started

### Requirements
1. SQL Server LocalDb instance

### Run this tool
1. Download the source from this repo, compile it
2. Execute the following command (it will prompt for any missing switches)
```
SqlAzureBakMaker.exe -SourceServer "" -SourceUser "" -SourcePassword "" -SourceDatabase "" -DestinationServer "" -DestinationDatabase "" -PathToLocalMdf "" -BakPath ""

Example:
SqlAzureBakMaker.exe -SourceServer "my-db.database.windows.net" -SourceUser "aplicMain" -SourcePassword "As@VeYJhjazz_GY4" -SourceDatabase "GuardarGrana" -DestinationServer "(LocalDB)\MSSQLLocalDB" -DestinationDatabase "ProdErp" -PathToLocalMdf "C:\Users\admin" -BakPath "C:\Temp"

SqlAzureBakMaker.exe -SourceServer "the-right.database.windows.net" -SourceUser "aplicSiger" -SourcePassword "#As@VeYJhzz_GYe4" -SourceDatabase "GuardarGrana" -DestinationServer "(LocalDB)\MSSQLLocalDB" -DestinationDatabase "GuardarGrana" -PathToLocalMdf "C:\Users\admin" -BakPath "C:\Temp"


SqlAzureBakMaker.exe -SourceServer "the-right.database.windows.net" -SourceUser "aplicSiger" -SourcePassword "#As@VeYJhzz_GYe4" -SourceDatabase "GuardarGrana" -DestinationServer "bd.asp.hostazul.com.br,3533" -DestinationDatabase "9295_prod_gtech_erp" -PathToLocalMdf "C:\Users\admin" -BakPath "C:\Temp"
```

  * -SourceServer: The full server name for the source SQL Azure DB (ex. something.database.windows.net,1433)
  * -SourceUser: The username for the source SQL Azure DB
  * -SourcePassword: The password for the source SQL Azure DB
  * -SourceDatabase: The database name for the source SQL Azure DB
  * -DestinationServer: The destination server
  * -DestinationDatabase: The database name you want to use on the destination server *CAUTION:* If this database already exits it will be dropped!
  * -PathToLocalMdf: the path to where you want to put the MDF file
  * -BakPath: the path to where you want to put the .bak file
  
## How it was tested
This project was tested against the sample AdventureWorks database that the Azure portal will inject into a new database for you. 

## Warranty
This code is a sample, use at own risk. Please submit a pull request if you find a bug. 

## Copyright and License
- Copyright (c) Microsoft Corporation
- Released under the MIT License (MIT)
- Please see LICENSE for more information.
