Deploy on : http://fazben-001-site1.htempurl.com/

# Issues 
	- Viewing :
		-Add Time
		-Add Validation of the seller
		-Restriction on the date (exclude week-end and date in the past)
		-Date should be updated when you book a viewing on the same property
	- Offers :
		-the offer should be updated when you make on offer on the same property

﻿# Refactoring Code :

 -  We need to use the Factory pattern to create the builder and Handler class, because at the moment the creation of these class 
	can be difficult to maintain if we want to expand the website.And it can cause a lot of problem in team environment.
	The idea is to create an interface to define the mandatory methods to create the class, for example IHttpHandler and IHttpHandlerFactory 
 -  Implement Builder pattern to create the  modelview

# Update the unit test by using the previous changes

# Security recommandation:
	- Dont use cookies to store user's password and consider encrypting information in cookies.
	- Use error handling. Include a finally block in which you release resources in case of failure
	- Test size limits of user input before using or storing it
	- Test the size of the number of queries, if there are unreasonable number o records 
	- Use the Secure Socket Layer (SSL), if we send sensitive information.
	- Verify the email when a user register
	- SQL injection : filter user input by verifying throught validation example: Int32.Parse to verify if its an integer
	  and apply HTml encoding to string to avoid HTML interpretation
	- Use Windows event logging and examine the logs frequently for suspicious activity

# Get a Bigger website:

	-Use TDD 
	-Add Continuous Integration Build to manage the different release
	-Need to use Deployment tool like Octopus and teamCity
	-Use Javascript Framework like AngularJs, React.js ..
	-Move to cloud computing like Azure, to manage the scalability of the website, performance, high availability 
   -Can use cassandra if we have massive amount of Data
