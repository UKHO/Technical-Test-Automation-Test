# Technical-Test-Automation-Test

### Welcome to the UK Hydrographic Office (UKHO) Test Automation Technical Test!

This readme.md will give you an overview of the tasks we will be completing over the next 30 minutes.

You will be pairing with a Test Engineer from UKHO who will guide you through the test. Please feel free to ask any questions or clarifications you require.

#### Set up
* The Test Engineer will give you an overview of the API and the endpoints it provides.
* In the root folder UKHO.Navigation.Books.API we will open a command prompt and run 'dotnet run -c release'. - this is to ensure the API runs as expected and is not part of the assessment.

#### Scenario 1

A developer has been given the task of writing some new validation rules for the UKHO.Navigation.Books.API. 

The developer has created some new validation rules, they are located in UKHO.Navigation.Books.API/Validators/BookRules.cs.

However the Developer has not written any unit tests?! You first task will be to write a unit test for the IsPageCountValid() function.

##### Tasks

* Go to the UKHO.Navigation.Books.API.Tests and use Nuget to pull in a test framework of your choosing. e.g. (NUnit, XUnit, MsTest)
* Go to the BookRulesTests.cs class and finish the unit test IsValidPageCount_WhenValidInteger_ReturnsTrue().

#### Scenario 2

To ensure the UKHO.Navigation.Books.API performs as expected we would like you to write some Integration tests.

##### Tasks

* Go to UKHO.Navigation.Books.API.Tests/IntegrationTests/BooksApiTests.cs
* Write a test that makes a GET request to the /books endpoint and assert that the response is a HttpStatusCode.OK (200);
* Write a test that makes a GET request to the /books{id} endpoint and assert that the response contains the Shetland Islands book title.


