# Developer Interview Exercise
Interview exercise for C# developers

__FileData__ is a console application.

FileData contains Program.cs which has a Main method <- this is the starting point for the app

Main takes in an array `args` which is a set of arguments passed in from the Console app

It also contains __ThirdPartyTools__ <-- this is a third party app that cannot be changed

ThirdPartyTools contains `FileDetails.cs` which has 2 functions
1. `Version` which returns a random version number
2. `Size` which returns a random number

We are not looking to test if you know how to access the file system and manage files.

As such, you do not need to check if file exists etc. just pass the string into `Version` and `Size`

To setup test arguments:
* Go to __FileData__ -> Properties
* In the _Debug_ tab, enter arguments in 'Command line arguments' start with '-v C:/test.txt'

---------

## Task 1
There is a need for a prototype Console app that :
* Takes 2 arguments
* If the first argument is `-v`, pass the second argument to `FileDetails.Version`
* Write the response from `FileDetails.Version` to the Console

---------

## Task 2
The prototype has been well received by the business who now want a full version of the app.

The new requirements are (in no particular order):
* To call `FileDetails.Version` if the first argument is either of `-v`, `--v`, `/v`, `--version`
* To call `FileDetails.Size` if the first argument is either of `-s`, `--s`, `/s`, `--size`

---------
```diff
- Please ensure proper unit tests are in place for your code changes. 
- You can add additional packages(XUnit,NUnit etc) in the project to support unit tests
```
* You need to ensure the console app is Production ready (TDD, unit tests, extensible, error handling etc. )
* Use SOLID principles


**NOTE:** Once test is completed please push your code to your github account and submit your github repo link to the email id shared in the breifing.
