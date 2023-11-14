2023-10-30 1415
I'm starting the 2nd Assignment. 
I create a new project in Visual Studio 2019 and then

selected ASP.NET Core Web Application, then configured the project by giving
it the name as SukhmanBookStore.

Web App (Model-View-Controller) and the core should be 5.0 as well as change the authentication 
to Individual User Accountsclick on the Enable Razor runtime compilation and create the project.

1435
linked to the _Layout in Views/shared folder. Then there are Controllers, Modeles and Views folder which has default controllers,
models, homecontroller, erroeviewmodel.cs, _ViewImorts.cshtml and _ViewStart.cshtml.

deletd the migrations folder.

1505
Downloaded the bootstrap.css file
Went to the wwwroots folder>dist>css>Changed the name of the default boostrap.css file
Added the downloaded Bootstrap.css for my theme.Changed the content from site.css file from the provided assignment 2 folder
In the views folder>_layout.cshtml>changed the file name to bootstrap.css
Changed the nav (navbar-dark bg-primary)
Removed text-dark from line 23 and 25
Added dropdown menu in _layout.cshtml.

Error: I ran into an error it is not working.
Solution: Didn't completed the code that is why it was not running
	<li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                Content Management
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <a class="dropdown-item" href="#">Action</a>
                                <a class="dropdown-item" href="#">Another Action</a>
                                <div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="#">Something else here</a>
                            </div>
                        </li>
1505
did changes in Validation script

1505
in the next part did debugging
checked HomeControllers.cs and then tested the page 
it worked of it will i have not did anything yet

1530
Then in next part added bootstrap
from bootswatch.com, I choose Darkly theme for my webpage
then replaced existing site.css file 
did changes in _Layout.cshtml also changed navbar to dark from light
and then tested the file it worked  

1535
In this step have to add links to navigation in cshtml file
and write a li with information related to dropdown 
then tested the code which showed a new bar named as dropdown and that contain various other information
after that changed the dropdown name to Content Management

1845
Added projects and modified
three new projects
SukhmanBookStore.DataAccess
SukhmanBookStore.Models
SukhmanBookStore.Utility

1903
After this copyed some files and then deleted which were not needed as instructed 
got some errors while modifying
changed the namespace so have to change the information given before in other file
corrected the errors
then build all the 2 files asked

2001
after testing the file 
created new class called SD.cs
did the changes in that and then added the project reference to models and utitlity.
added customers to area folder
changed startup.cs routes and then scaffolding
edit homecontrollers
run the application and it worked yayyy!

2025
did the whole testing and then got one error
in startup.cs didnt write this code /{controller=Home} 
after writting it error closed and then
tested it worked 
everything good my assignment done!

2023-10-31
updated my README.txt

2023-11-3
part 2
started by adding the new migration file

2023-11-02 1054
back to work!!
Updated database and checked sql server.

1106
Added new class to .Models project named Category.cs.
Then add migration through console .DataAccess project with command: add-migration AddCategoryToDb
Now modify the new migration.
Also added namespace and content to ApplicaionDbContext.cs
        public DbSet<Category> Categories { get; set; }

1121
Try to readd the migration but there is a dulplication error to resolve it I delete and recreated the migration.
Commint it to Github.

1124
Now let's move to part 2.
Created new folder in .DataAccess project named Respository then further a subfolder name IRespository.
Then added a new interface name IRepository.cs and modify it to add accordingly.

1225
Created files in subfolder namely ICategoryRepository.cs that is an interface and a new file in folder CategoryRepository.cs and modify data.

1304
Created ISP_Call interface and SP_Call.cs class and made alterations.
Updated SP_Call.cs.

2023-11-06 1800
Added UnitOfWork class and interface
modeiffied it and linked it through StartUp.cs

1606
Added a new controller named CategoryController.cs

1619
Added a new index page for category added the content provided in CategoryIndex.txt.
Modified the _Layout.cshtml to show in the notification.

Moving forward added new editing and creating concept to the file by editing to work on it.

1720
Now added content to category.js and commit the code.

2023-11-14 1503
I was getting an error in migration where I miss-spelled the column Name to "Nmae".

solution was change to the correct name added the new migration -20231114195032_AddCategoryToDb2 and updated the database 
and the column name got changed to "Name". Rerun the project and everything went successfully. 