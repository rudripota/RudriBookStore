2023-10-24
1452
Created README
Cecked out all the folders
commented out the ssl port
edited out this code in startup.cs
options => options.SignIn.RequireConfirmedAccount = true

1514
added readme.md

1523
completed part 1.0
starting part 1.1
went for a coffee

1530
observed and learnt pt 1.1
starting pt 1.2
randomly remembered that I had to try registering and logging in
applied migrations
works!

1537
triedout the breakpoints
tried to start pt 1.3 but decided to do it later
made sure that all the edits were pushed

2023-10-30
1719
started the project again
cleaned and rebuilt the solution
ran with 0 errors

1723
followed the slides, went to bootswatch and downloaded bootstrap.css file for "Morph"
went into www.root folder and navigated to the default bootstrap file
renamed it bootstrap_bk for backup purposes 

1729
added new bootstrap file
replaces he site.css file

1735
changed to bootstrap.css in _layout.cshtml
made some other changes

1742
went to _LoginPartial.cshtml and made changes
everything works
the theme looks gorgeous!

1748
checked out the third party tools

1804
added code for css and js in _layout.cshtml file

1823
editted the code and made sure it was complete and added it in
the dropdown menu code was added
it works!

1828
started 1.4
added three new projects
went to the solution explorer
added new class libraries
version 3.1

1841
added the data folder to data access and deleted the original
added some packages from nuget package manager
deleted migrations folder

1848
made the remaining changes
Modified the namespace to reflect the project
Deleted default Class1.cs file in all projects
Built the project

1855
MoveD THE Models in to RudrisBooks.Models 
deleted the original
Modified Views > Shared >  Error.cshtml
Renamed Models folder to ViewModels
Change the ErrorViewModels.cs namespace .Models.ViewModels
Build Project

1905
Install NuGet package:
Identity.EntityFrameworkCore
Modify the namespace to reflect the project
Delete default Class1.cs file in all projects
Build the project


1915
Added references to projects
name model folder to View Models
To solve error added using statements
change startup file

1916
in the utility project, create a static details class called SD.cs
modified the properties of the class
add project reference to the main project
copied _ViewImport and _ViewStart to Customer Area
modified the _ViewStart.cshtml

1741
rebiult the entire project
made a new github repo
redid all the steps
checked it everything works
it worked

1803
Reviewed appsettings.json
Created the migrations 
usied code-first, where changes are “pushed” to the database
modified the database name and saved
Used the NuGet Package Manager Console to add the migration (with a meaningful name).

1813
Changed to the correct default project (.DataAccess)
Ran the program again
Added the new migration file named: AddDefaultIdentityMigration
Created the migrations
modified the database name
everythng works

1822
Use the NuGet Package Manager Console to add the migration
Note what happens if the wrong default project is selected
Change to the correct default project (.DataAccess) and run again
Updated database

1828
Reviewed the file for the SQL-like syntax, statements, columns and primary key constraints
Note tables related the ASP.NET Identity
Once the migration is complete, the database needs to be updated
In the PM console, update the database now
Review the updated database in the SQL Server Object Explorer.
Check for errors, run the application

1833
Added migartion for category
updated database
Added a new folder named it ‘Repository’ and added an IRepository folder inside it
Added a new item of type interface to the folder and named it IRepository.cs 
Modified it so it can be used on the Category class to do all the CRUD operations
Updated most of the using statements
created two folder in .dataaccess
Created two files

1847
implemented a stored procedure repository and map multiple repositories in a Unit of Work
added a new interface in the IRepository folder - ISP_Call.cs – that extends IDisposable
Included the methods shown
installed the NuGet package for Dapper
implemented this with a new class in the Repository folder

1900
Added a new interface (IUnitOfWork) to the IRepository folder and updated the code
implemented this inside the UnitOfWork
Added a class
Modified the code
Made it accessible by the project
registered it Startup.cs in the ConfigureServices method
added using statements

1919
Added a new folder in the Areas/View with the same name as the Controller
Added a new ‘Index’ view to the folder
modifed the the generic HTML code from the Category Index View.txt file found in the Assignment 2 - Files folder 
application works
In _Layout.cshtml, moved the ‘Category’ link to the Content Management drop-down
Add the IAction result to the controller and add a View (as we did w/ Index)
Copied and added the html from the Category Upsert View.txt
Created a partial view for the EDIT | BACK.
Added the partial view for _CreateAndBackToListButton.cshtml and added the asp-action
Created another parital view for _EditAndBackToListButton

1930
Modified the Upsert.cshtml
Added the asp-action to the Index.cshtml page
added the @title that made the warning go away
took a break

2000
back at it
created an Upsert POST action method in the CategoryController.cs
Removed the _db.SaveChanges() method in the CategoryRepository.cs
moved the _unitOfWork.Save() method with the return RedirectToaction method

2023
Added the API (Application Programming Interface) call for HTTPDelete in the CategoryController.cs
Then implement the HTTPDelete with a delete method in category.js to add functionality to the application and call the API
Add the delete functionality in category.js with including the onclick event to the Delete function

2035
everything works perfectly
the project is succesful
added some data
saved

2023-11-21
1215
went back to part 2 of assignment 2 to check and make sure that I am making the new crud correctly
added covertype as a folder accidentally
deleted it
added covertype in model folder
edited to make sure that there is id and name included
did not find repo for a while
added covertype to repo
instructions unclear, added both files in repo

1233
edited things 
shifted them to go in the right folders
added covertype to unitofwork and iunitofwork
made sure to make all the classes public

1244
tried ro add migrations
the build failed
made some edits and retried
it did not work

1256
realized that I had forgotten to change the category to covertype in unitofwork module
felt stupid
still did not work
took a break

0109
added Cover Type to NavBar
messed up a little
readded it
added CoverType Controller with all Action Methods
added Cover Type Index View to use DataTables

0357
added migrations after multiple trials and erros
keep note: services.AddScoped<UnitOfWork, UnitOfWork>(); startup.cs
20231120205024_AddCoverTypeToDb
the stamp^

0414
added a new class (Product) in the .Models project
added the code to build the blueprint of this class 
made sure it’s public and that any errors are resolved

0427
added all the code that we had to from slide 6

0437
Added reference to the new Products piece to the database in the ApplicationDbContext.cs file
In the PM Console, run the add-migration command for an  ‘addProductToDb’ migration and update-database
Note the new migration file in the Migrations folder and put this timestamp in the README
In the SOE review the newly created Products table
Updated the Product class so Title, ISBN and Author are [Required], create a new migration (addValidationToProduct) and update the database

0445
Added Product to the Repository
Added IProductRepository Interface
Added ProductRepository Class (note modifications to the Update method)
Added Product to UnitOfWork and IUnitofWork
Builded and checked for errors,
Build was successfull and application works fine

0502
Added Product Controller To the Areas > Admin > Controllers to perform the CRUD operations
Added the IWebHostEvironment call and its using statement to the Microsoft.AspNetCore.Hosting 
Created a ViewModel in the Models project to hold the Product object and select list for Category and CoverType

0515
Modified the ProductVM class so it is public and intalled the Microsoft.AspNetCore.Mvc.ViewFeatures package.
Modified the ProductController so the IActionResult Upsert calls to the ProductVM view model, include the using statements to the ViewModels folder and Microsoft.AspNetCore.Mvc.Rendering
Commented out the Upsert post method for now
Modified the API call to include the Category and CoverType properites
product migration file: 20231120231928_addProductToDb


0528
Added an Index view
Copied the Index.cshtml code from Views/Category and modified to the Product List header, Created New Product and added the following properties – Title / ISBN / Price / Author / Category and reference a new product.js file.
Copy/Pasted the category.js and renamed to product.js 
Modify the _Layout.cshtml to added a new link to Product.
Validation migration file: 20231120232616_addValidationToProduct

0535
Getting an error in the ProductController.cs 
ohh right, I didn't see the instuctin in slide to press continue in case of error.
Application works fine after pressing continue.
Section-2 is completed

0550
Created an Upsert.cs for Products and modified in Areas > Admin > Views > Product and Added content from Assignment-2 files
Added a rich textbox to the textarea inside Product with tiny.cloud Crated an account and got a <script> from code snippet using the API key provided, initialize and add a function to validate input and if empty, display a Sweet Alert.
Runned the application and see what happens when you select ‘Create new Product’.

0605
Added a new folder and subfolder in wwwroot > images/products
In the ProductController configure the Product Upsert Post action method.
Uncommented the method and modify There is no file to update Upsert method assignment 2 files
Checked for errors, runned the application and test.

0615
Getting an error.
Tried to solve it but nothing seems to working

2023-11-27
1214
started theproject
compared my repo to the provided one
Updated Product.cs
Added New fields Price, Price50, Price100 with validations
Changed Foreign key for CovertypeId

1226
could not solve the error for product previously
tried adding breakpoints, did not work
starting to build migration

1231
used the command: add-migration UpdateProductTable
made sure that default project in package console manager is dataaccess
20231127173054_UpdateProductTable
Updated database
there are errors
error 1: Column names in each table must be unique. Column name 'CoverTypeId' in table 'Products' is specified more than once
error 2: Failed executing DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
ALTER TABLE [Products] ADD [CoverTypeId] int NOT NULL DEFAULT 0;

2023-11-28
0925
Navigated to product controller
Changed category to coverlist in the function
Read over the thing
Updated SD.cs in Utility Project