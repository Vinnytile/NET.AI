# NET.AI
Repository for the .NET AI experiment

# Unit Tests Description

1. StudentConverter
These unit tests are designed to verify the functionality of the StudentConverter class in our project, specifically the ConvertStudents method. This method processes a list of Student objects, adjusting their statuses based on their age and grade. We have multiple tests in place to ensure the robustness of this functionality.

ConvertStudents_ShouldSetHonorRollForStudentsOver21WithGradeOver90 tests whether the method correctly identifies students who are over 21 years old and have a grade over 90, marking them as part of the Honor Roll.
ConvertStudents_ShouldSetExceptionalForStudentsUnder21WithGradeOver90 checks that students under 21 with a grade over 90 are correctly marked as exceptional.
ConvertStudents_ShouldSetPassedForStudentsWithGradeBetween71And90 ensures students with grades between 71 and 90 are marked as having passed, while ConvertStudents_ShouldSetPassedToFalseForStudentsWithGrade70OrLess verifies that students with a grade of 70 or less are correctly identified as not having passed.
Two additional tests, ConvertStudents_ShouldReturnEmptyListWhenGivenEmptyList and ConvertStudents_ShouldThrowArgumentNullExceptionWhenGivenNull, are designed to check the behavior of the method when given an empty list or a null value, ensuring the method can handle such edge cases without failing.

2. PlayerAnalyzer
The provided unit tests are primarily designed to validate the CalculateScore method in the PlayerAnalyzer class. This method analyzes a list of Player objects, each with properties for name, age, experience, and a list of skills, and calculates a score for each player or set of players.

CalculateScore_GivenSinglePlayer_ReturnsExpectedScore, CalculateScore_GivenYoungSinglePlayer_ReturnsExpectedScore, and CalculateScore_GivenExperiencedPlayer_ReturnsExpectedScore are test cases intended to ensure that the score is calculated correctly for individual players based on their age, experience, and skill set.
CalculateScore_GivenMultiplePlayers_ReturnsSumOfTheirScores validates that the method correctly aggregates the scores of multiple players, providing an accurate total score.
Additionally, CalculateScore_GivenPlayerWithNullSkills_ThrowsException and CalculateScore_GivenEmptyArray_ReturnsZero are tests engineered to handle edge cases where a player has no defined skills, or where the list of players is empty. These ensure that the method responds correctly to such scenarios without causing unhandled exceptions or errors.

# Running Tests Locally
To run these tests locally, you will need a .NET environment and the xUnit framework installed on your local machine. Please follow these steps:

1) Prerequisites: Ensure you have the .NET Core SDK installed. You can download it from here: https://dotnet.microsoft.com/download. Also, make sure you have installed xUnit using NuGet. If you haven't installed xUnit, you can do so using the following command in the NuGet Package Manager console:

    Install-Package xunit -Version 2.4.1 (or the latest version)

2) Clone the repository: Clone the git repository to your local machine using the git clone command. This will make a local copy of the codebase.

3) Navigate to the test project: Open a terminal window and navigate to the directory of the test project. This is typically a folder named "Tests" or similar in the main project directory.

4) Run the tests: Run the tests using the .NET CLI (Command Line Interface) with the following command:
    dotnet test

After running the command, the tests will execute, and the results will appear in your terminal window. The output will show whether each test passed or failed and provide a summary once all tests have completed.

Remember, unit tests are a vital part of software development, allowing us to ensure our software is reliable and behaves as expected. So, it's a good practice to run these tests after any significant code changes.