# Technical-Test-Automation-Test

### Welcome to the UK Hydrographic Office (UKHO) Test Automation Technical Test!

This readme.md will give you an overview of the tasks we will be completing over the next 30 minutes.

You will be pairing with a Test Engineer from UKHO who will guide you through the test. Please feel free to ask any questions or clarifications you require.

#### Set up
* After pulling the solution you will be asked to build and run the API - this is to ensure the API runs as expected and is not part of the assessment.
* The Test Engineer will give you a brief overview of the solution and the scenarios.

#### Scenario 1

A developer has been given the task of writing some new Book functions for the UKHO.Navigation.Books.API. 
The developer has created the UKHO.Navigation.Books.API/BookHelpers.cs class and the UKHO.Navigation.Books.API/Services/FleetService.cs class.

However the Developer has not written any unit tests?! You first task will be to write some happy path unit tests for the new code.

##### Tasks

* Go to the UKHO.Navigation.Books.API.Tests and use Nuget to pull in a test framework of your choosing. e.g. (NUnit, XUnit, MsTest)
* Go to the BookHelpersTests.cs class and finish the unit test IsValidPageCount_WhenValidInteger_ReturnsTrue().
* Go to the FleetServiceTests.cs class and finish the  ValidateFleet_WhenValidCollectionOfShips_ThenFleetIsNotNull().

#### Scenario 2

To ensure the API responses correctly a developer has written an integration test for the API.

##### Tasks

* Review the API test with the Test engineer and see if it can be improved. 


