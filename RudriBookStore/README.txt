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

1528
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

Create the migrations (using code-first, where changes are “pushed” to the database), modify the database name and save.

Use the NuGet Package Manager Console to add the migration (with a meaningful name).
Note what happens if the wrong default project is selected.
Change to the correct default project (.DataAccess) and run again.

Updated database


Added migartion for category

updated database

created two folder in .dataaccess

Created teo files