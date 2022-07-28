
# Inventory Management System

This project is used to perform basic CRUD
operations on realworld problem i.e on Medical Shop's
Inventory. 

Firsly the user is prompted with the Login page. 
The user has to login in order to access the Inventory
of the shop. Once the user logs in he/she will be 
able to add new items, edit existing items and 
delete items.


## Run Locally

In order to run the project these are the steps
that must be followed:


Launch 
```bash
  Visual Studio 2022 (Preferably)
```
Click on 
```bash
  Clone a repository
```
Paste this link in the "Enter a Git repository URL"
```bash
   https://github.com/Suyashd999/InventoryManagement0
```
Open the "appsetting.json" file and make sure to change the Server name of the "DefaultConnection" Connection String.
```bash
   "DefaultConnection" : "Server='your server name';database=InventorySystem;Trusted_Connection=True;"
```
Open NuGet Package manager by performing following steps:
```bash
   "View > Other windows > PMC" and "Tools > NuGet Package Manager > PMC"
```
In the NuGet Package manager enter the command 
```bash
    update-database
```
Now click on the Run button in order to run the application.
