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