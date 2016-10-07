# Angular 2 ASP.NetCore Multi-SPA framework

This repository holds the source of a framework in progress. 

Currently it uses an ASP.Net Core backend, Angular 2.0.0 front end, and will be styled with the latest Bootstrap 4.0.
Soon to be added tag helpers and code generation from the data model.


For further background details, see the Github Wiki here: https://github.com/RobertDyball/Angular2MultiSPA/wiki
or follow the blog posts here: http://dyball.wordpress.com

### Done so far: 

- Switched from standard Angular HTML template to a template created with an ASP.Net Core partial view 
  This allows use of razor syntax, since the templates are served from CSHTML files, and anything else ASP.Net / MVC programmers are used to including tag helpers
  i.e., inject server side smarts into otherwise plain flat-HTML client-side markup.
  (more CSHTML/HTML templates to come when Angular 2 routing is added)
- Switched from Bootstrap 3 to Bootstrap 4
- Add initial cut of Angular 2 routing, re-implemented Bootstrap navbar / menu
- Added EF Core, and a SQL backend (using Northwind) to demonstrate data model generation using database-first
- Main data model now separated into a separate project
- Set up an intial, separate View Model, and simple fetch of data and images from Web API through to an Angular 2 service
- Added Code first, to create database now, go to Package Manager console, type: Update-Database
 (note no sample data this drop, get the sql data insert if needed from Northwind.sql for now until seeding is added)

### TODO 
- Setup SQL seeding and database creation from code

(not necessarily in this order):

- Add JWT token authentication, probably using OpenIdDict
- Add Chuck Norris Roundhouse to create versioned SQL scripts generated by EF
- Add Tag Helpers to automatically create boiler-plate client code based on view models, attributes decorating view model properties will generate code directly, from one place in the code.
- Add Swagger (probably NSwag) to create a map of Web API calls, and be able to auto generate Typescript code for Angular 2 services + data classes
- Add native Angular 2 Bootstrap library; Perhaps ng-bootstrap or ng2-bootstrap.  

## Prerequisites

Download and install 1.0.0-preview2-003133 to suit your platform, see ASP.Net Core downloads here: http://asp.net 

If using Windows, use Visual Studio 2015 Update 3, with ASP.Net core tooling updates, 
or alternately use Visual Studio code.

Node.js and npm are essential to Angular 2 development and used by Visual Studio. 

Install Typescript and Typings globally, as these will be used by the application.

npm install -g typescript
npm install -g typings 
  

## Running

Pull a copy of the repo, load the solution into Visual Studio, build (which will restore dependencies), and hit F5 or ctrl-F5

Dependencies can be installed manually, using the command:

dotnet restore

this command will also automatically inostall any outstanding NPM packages, saving you the need of typing

npm install
npm install --save-dev

If you have any issues, try running both of these commands, in an admin command prompt, and look for any error messages.

So after you build and run, browse to: http://localhost:7010/ to see the Angular 2 using an ASP.Net partial page, with CSHTML running razor into the Angular template.

## Background

Here's a brief explanation of what happens, and a little of why.

All of us have seen code turn to spaghetti and think we're going to avoid it next time.

Ideally we're hoping to get a useful integration of the best of an ASP.Net Core backend with an Angular 2 front end, and not lose the strengths of both platforms. 

Some people use an ASP.Net or ASP.Net Core or other) back end platform to serve up their Angular scripts and views and provide data using Web API, however these tend to ignore tag helpers or many of the other benefits of ASP.Net core.

Others go the other way, making the server fulfil a complex range of tasks, often setting up pre-loaded data into views, but this can create quite a complex code base with a very steep learning curve.

Here we hope to experiment in collaboration and produce a framework that provides a starting point for many business scenarios.

We'll try and keep things using cross platform features of ASP.Net Core that is capable of being deployed to Windows or Linux servers or makeuse of Docker containers.

