# Technical-Test-Automation-Test

### Welcome to the UK Hydrographic Office (UKHO) Test Automation Technical Test!

This readme.md will give you an overview of the tasks we will be completing. The interviewers will state how much time can be spend on the task.

You will be pairing with a Engineer from UKHO who will guide you through the test. Please feel free to ask any questions or clarifications you require.

#### Set up
* You may be asked to clone the repo and build the solution.
* The Engineer will give you a brief overview of the solution and the scenarios.

#### Scenario 1

A developer has been given the task of writing some new GET endpoints for the UKHO.Navigation.Books.API that will return a specific navigation book based on the id, and an endpoint that will return all known navigation books.

However the Developer has not written any integration tests?! You task will be to write a basic integration for one of the new endpoints.

##### Tasks

* Go to the UKHO.Navigation.Books.API.Tests and use NuGet to pull in a test framework of your choosing. e.g. (NUnit, XUnit, MsTest)
* Go to the UKHO.Navigation.Books.API.Tests/IntegrationTests/BookGetApiTests.cs class.
* Write a new test to verify that the below book exists using the GetBook or GetBooks endpoint.

```csharp
var expectedBook = new Book
    {
        Id = "d0bf11de-b97b-4fcb-b84d-e0ff18119e08",
        Title = "Los Angeles and Long Beach Harbors",
        Author = "US Navy",
        ShortDescription = "Advice for safe docking in the Los Angeles harbours",
        PageCount = 500,
        ReleaseDate = new DateTime(2019, 04, 13),
    };
```




