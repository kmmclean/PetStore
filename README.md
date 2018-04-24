# PetStore
A basic web API for pet store orders

# Instructions
1. If you don't already have it, install the current .NET Core SDK for your operating system from https://www.microsoft.com/net/.
2. In your terminal or command prompt, navigate to the src/Web project and run the following command to pull down all dependencies from NuGet: `dotnet restore`
3. While still in the src/Web project, create the SQLite database and relevant tables by running the Entity Framework Core migrations using the following command: `dotnet ef database update`
4. Start the application by running `dotnet run`. The web API will start on port 5000 by default.
5. Using whatever tool you'd like (e.g. Postman, or even cURL), you can send JSON requests to the following endpoints:
    1. Adding a new order: POST http://localhost:5000/api/orders
    2. Viewing an existing order: GET http://localhost:5000/api/orders/{orderId}

# To Do/Improvements
1. Fix a bug that seems to occur when saving orders that have attached items.
2. Did not have enough time to implement the code that calls the product web service to get pricing info due to unfamiliarity with the `HttpClient` class.
3. Add a non-mapped property to the `Order` entity called `Total` that would return the total cost of each `OrderItem` in the `Items` collection.
4. Write a unit test to test the logic of the `Total` property by creating a few in-memory `OrderItem` objects that are added to the `Items` collection of a test `Order` object.
5. Make the `OrderDate` property on the `Order` entity read-only.