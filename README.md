# Dependency Injection Example Solution

## Overview
This .NET solution provides examples of how to implement simple dependency injection.  Dependency Injection is based on the Data Access Classes that implement an interface that can be assigned to a private class variable within a manager class.  This method keeps a seperation between the User Interface and the Data implementation.

For unit testing the Manager classes are instantiated with an overloaded constructor that contains the data access class that will be used for testing.

## Application Layers

1. UI - This layer can contain console applications, asp.net applications, web api, etc.  This layer is only able to access the Business Layer and should not have any knowledge of the Data Layer.  The only project that is shared between all projects is the DTO layer which is used as a transport mechanism for moving data from the UI layer to the Business layer and then to the Data layer.

2. Business - A Managers project is contained in this folder and should contain management of calling CRUD operations as well as any business logic that is implemented in the solution.  Creating this layer allows reuse of business logic between different User Interfaces

3. DTO - This layer represents encapsulated properties that are used to move data between layers.  A DTO object can represent data returned from a database, file, restful service or any external dependency that contains dynamic data.

4. Data - The data layer is split up into multiple classes that each implement their own interface.  The advantage of this is that when unit testing a manager class can be instantiated with a specific data implementation.  The allows decoupling of the data access classes and allows the developer to inject stub classes that contained mocked-up data.
