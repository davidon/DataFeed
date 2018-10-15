# Introduction 
This project is to take out runners name and prices from different formats of data feed source files, for now XML and JSON, and sort them by prices ascending order.

# Installation process
1. Extract the EasyFeed.zip into a folder, e.g. `c:\EasyFeed`
2. Open Console (CLI), run command:    
`cd c:\EasyFeed\App\bin`
3. Run this application by typing command:  
`dotnet DataFeed.dll`
4. watch the console output for sorted result; You can also view the sorted result in generated log file: `C:\EasyFeed\App\bin\Logs\FeedDataProcess.log`.
# Continuous development in Visual Studio
* Open solution file `c:\EasyFeed\DataFeed\DataFeed.sln`
* Use Nuget package manager to install and update dependencies
* Rebuild and Run from Debug menu, and watch the console output for sorted result; You can also view the sorted result in generated log file: `C:\EasyFeed\DataFeed\bin\Debug\netcoreapp2.0\Logs\FeedDataProcess.log`
* To make unit test in Visual Studio,  open Test Explorer, you should be able to see two test cases. Click `Run All` and the marks should turn green indicating all test passed.

# Feed data source files:
The XML and JSON source files are under `c:\EasyFeed\DataFeed\FeedData\`, with file name `Demo_Race.xml` and `Demo_Race.json` respectively. You can replace the data content, however files name cannot be changed.

# Architecture Solution and Tech Specification:
* Software development S.O.L.I.D principles and Design Pattern are adopted.
* DI (Dependency Injection) in use.
* Use unit test from early stage to adopt TDD (Test Driven Development) principle. 
* Modular progamming methodology to make it extendable for further development
* Adopt Settings, for example, the data source files directory, the XML nodes of horse nodes and price nods can be easily changed even without looking into code. 





