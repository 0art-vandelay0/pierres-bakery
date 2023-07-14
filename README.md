# 🇫🇷 **Pierre's Bakery** 🇫🇷

#### **By Casey Hill**

#### A simple console app that will let you choose bakery items and calulate the total of your order. &#x2615; &#x1F35E; &#x1F365;

#### ...._"With enough butter, anything is good."_ - Julia Child

## **Technologies Used**

-   C#
-   .NET 6.0.402
-   dontnet CLI
-   MSBuild
-   VS Code
-   git
-   GitHub

## **Description**

This is a console app that gives you two bakery options to order. There are buy 3 get one free or buy 4 get one free deals. The program takes your input for each question and return the total of you order based on what you input and the number of each items, taking the deals into consideration.

## **Setup/Installation Requirements** &#x1F4BB;

### **In IDE** (this serves as instructions for VS Code)

-   Clone this repository to your local machine.
-   Open VS Code.
-   Open the top level directory you just cloned.
-   In your terminal:

    -   Change directory (cd) to Bakery.
    -   Enter `dotnet build` into your terminal.
    -   If you would like to run the test files.
        -   cd to Bakery.Tests.
        -   enter `dotnet build` into your terminal.
    -   Enter `dotnet run`.
    -   The program should start and you will see a welcome menu followed by a prompt.
    -   Follow the prompts and carriage return after each entry.

    That's it!

#### Debugging

If the program does not run, try the following:

-   Check that you have the appropriate .NET packages installed to run dotnet
-   Try creating a `global.json` file in the Bakery.Tests dir that contains the following code to override the default version:<br>
    {<br>
    &emsp;&emsp; "sdk": {<br>
    &emsp;&emsp;&emsp;&emsp;"version": "6.0.402"<br>
    &emsp;&emsp;}<br>
    }

## **Known Bugs**

-   Console Background colors may bleed if console/terminal activity is not cleared before rerunning the program.

## License

Please contact [caseyfhill1@gmail.com](mailto:caseyfhill1@gmail.com?subject=Hello%20Casey,&body=You%20are%20amazing...) with any the following:

-   Found bugs &#x1F41E;
-   Alterations and improvements
-   General Questions
-   Any contributions you would like to make! &#x1F5DD;

Copyright (c) 06/16/2023 Casey Hill
