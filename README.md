AdventureWorksPortal
====================

ASP.NET MVC 4 reference application built around the AdventureWorks sample database.

Projects in solution:

-	AdventureWorksPortal (MVC 4 Web application)
	
	Generated UI modified/enhanced:
	- Bootstrap (CSS)
	- Knockout (table paging)
	- JQuery (validations, date select, etc.)
	- MVC sitemap

-	ModelObjects (class library)
	
	Entity layer. Contains entities and DbContext generated from AdventureWorks database
	using Entity Framework and EF 5.x Designer Code Generation templates. 
	(http://msdn.microsoft.com/en-US/data/JJ613116)

	Note: I added annotations to the generated entity classes which is not a good idea. I will
	probably change this to use "buddy" classes.

	Update: removed all annotations from generated entity classes. All annotations put in "buddy"
	classes (see: EntityMetadata.cs in Model/Entities).

-	DataAccessObjects (class library)
	
	Data Access Layer. Encapsulates database access and CRUD behavior.

-	ServiceObjects (class library)

	Service layer. Encapsulates access to DAO's.

Projects added:

-	AdventureWorksServices
	
	A WCF project that shows how to expose Service layer (ServiceObjects) functions
	as SOAP services. Implements the service contracts. The data contracts are defined
	in DTO's (data transfer objects) in the entity layer (ModelObjects).

-	AdventureWorkSL

	A simple Silverlight control that uses the Product Catalog service from AdventureWorksServices
	to access product data.

-	AdventureWorksSL.Web

	Web site to test/show AdventureWorksSL controls.	

