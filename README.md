# CMPG-323-Project-2---41505212

This project is an API designed to manage telemetry data, allowing users to create, retrieve, update, and delete telemetry entries in a database. The API includes endpoints to calculate and retrieve cumulative time and cost savings for specific projects or clients, based on specified criteria. It also features authentication to ensure secure access and includes built-in checks to validate telemetry entries before they are modified or deleted.

To use the API, new users have to register,login to the the token. The user will use the the token as authentication. Afterwards, the user can then safely perform or test the API functionalities.

## **ENDPOINTS AND ASPECTS IMPLEMENTED** ##

GET: Retrieve all Telemetry entries.

GET: Retrieve a specific Telemetry entry by ID.

POST: Create a new Telemetry entry.

PATCH: Update an existing Telemetry entry.

DELETE: Delete an existing Telemetry entry.

GET GetSavings (by Project): Calculate and retrieve cumulative time and cost savings based on Project ID and date range.

GET GetSavings (by Client): Calculate and retrieve cumulative time and cost savings based on Client ID and date range.

## **References** ##

[Tutorial: Create a web API with ASP.NET Core | Microsoft Docs](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio)

[Create a web API with ASP.NET Core controllers - Learn | Microsoft Docs](https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/)

[Publish an ASP.NET Core web API to Azure API Management with Visual Studio | Microsoft Docs](https://learn.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-6.0)

[Flutter copilot](https://chatgpt.com/g/g-cZPwvslfA-flutter)

Code Copilot

