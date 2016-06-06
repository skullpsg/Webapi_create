# Webapi_create
In this project  i have created web api with entityframework(codefirst approach) and created basic framework or infrastructure for asp.net identity.
# Environments
1.vs 2013
2.Entity Framework 6.1
3.Asp.NET Identity Owin 2.2.1
# How to work with
1.download the Project.
2.change the connection string in Web.config

 <add name="DefaultConnection" connectionString="Server=**ServerName**;Database=BlogApiAuthenticationDB;User ID=UserId;Password=Password;" providerName="System.Data.SqlClient" />
 
 3.create database using package manager console.Run the following commands...
 step 1: initial create run 
 command1: enable-migrations
 command2:  add-migration InitialCreate
 
 4.verify whether its working fine using browser.
 http:localhost/xxxxxx/api/accounts/users
 
 
