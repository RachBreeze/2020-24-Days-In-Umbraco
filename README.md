# Configuration files: Testing,Transforming and Deploying
Code in this repository supports an article I have written for 24 days in Umbraco that discusses how to test, transform and deploy configuration files for .NET Framework.

## Solution contents
The solution utilise Umbraco 8.9.1.  You can read more about Umbraco here https://umbraco.com/

Umbraco is referenced because deployments of ClientDependency.config requires a transform to ensure that the latest scripts and css are visible on Umbraco websites.

The front end of the Umbraco website is empty, only the back office is avaialble on /Umbraco.

### Login to the Umbraco Backoffice
The credentials for the Umbraco Backoffice are:
- Username: hello@breeze.me.uk (this is an unmonitored email address)
- Password: Advent2020!
The database used is SQLServerCe.  There is no data in Umbraco as the article is about configuration fikes :-) and this database has been used to ensure quick builds of the site for anyone running the project.

## Maintenance and Warranties
As the code in this repository is written to support an article which talks about configuration files, there are currently no plans to upgrade the versions of the NuGet packages referenced with in the code base.
