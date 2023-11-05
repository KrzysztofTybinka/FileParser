# About The Project
FileParser is a command-line utility designed for data management and processing. It empowers users to  load structured data files, such as JSON or CSV, 
into memory and execute data manipulation tasks with supported commands. This application supports concurrent loading of multiple files, offering users 
the ability to switch between datasets during the processing workflow.
# Getting Started
### Downloading the source code
You can download the source code for this application by clicking the "Clone or download" button on the GitHub repository page and then selecting 
"Download ZIP." Extract the contents of the ZIP file to a location of your choice.
### Building the Application
1. Run the following command to restore the NuGet packages:
```
dotnet restore
```
2. Run the following command to build the application:
```
dotnet build
```
### Running the Application
4. Open a command prompt or terminal window and navigate to the directory where you extracted the source code.
5. Run the following command to start the application:
``` 
dotnet run
```
The application should now be running, to use the application follow the ons-screen instructions or type --help.
# Usage
### User Interface
Applications supports various commands: 
**upload**
```
upload [-collection | --c] <collection_name> <source>
```
Upload commad uploads file from _source_, which is a URL or dir path into a memory, 
data stored in file must match given _collectionname_ supported by the application.
**download**
```
download [-name | --n] <name> <path>
```
Downloads file from the memory, _name_ is file name that has been uploaded,
_path_ is a directory path you want the file to be downlaoded.
**greater**
```
greater [-than | --t] <property_name> <value>
```
Greater command parses a file you're currently working on,
and filters it by comparing _propertyname_ to a _value_,
returning objects with greater property values.
**smaller**
```
smaller [-than | --t] <property_name> <value>
```
Smaller command parses a file you're currently working on,
and filters it by comparing _propertyname_ to a _value_, 
returning objects with smaller property values.
**switch**
```
switch [-name | --n] <file_name> 
```
Switches a working directory into a directory
specified by a _filename_.

--help - displays help menu
--exit - exits the application



### Code
The application operates as follows: the user inputs the data in the correct format, which is then processed 
by a Phrase object. The methods within the Phrase object get the file content from FileDownloader static class, interpret the user input and determine the appropriate FileParser object to be instantiated. The resulting FileParser object is then passed as a parameter to the FileService 
object. The extracted data within the FileParser object is then filtered by methods within the FileService object according to specified parameters, 
resulting in a list that is subsequently output to the console. This pipeline of object interactions and method invocations enables the application 
to efficiently and accurately process user input and produce the desired output.

![This is an image](https://imagizer.imageshack.com/img923/9422/I6bNik.jpg)


The problem of extracting nested keys from JSON and XML files has been resolved through the utilization of LINQ query capabilities. 
The method first obtains the descendants of the data, performs parsing operations, and retrieves the values.

![This is an image](https://imagizer.imageshack.com/img924/1332/50KHqx.jpg)


FileService class methods use LINQ, to select the desired values from the data set and output the results in the form of a list.

![This is an image](https://imagizer.imageshack.com/img924/1696/lCHp0y.jpg)

The application has been developed adhering to SOLID, software design principles, allowing for modular and flexible design with the ability to easily 
extend and add new functionalities for data filtering and other file types.
### Unit Testing
This project includes unit tests written using the xUnit testing library to verify the behavior of the FileParser and FileService classes. The tests ensure that the ParseFile method of the FileParser class returns the correct list of values for a given key, and that the methods of the FileService class filters data correctly.

The unit tests can be run using a test runner or from the command line, and are located in the FileAnalyzerTests folder. The test classes use a naming convention of [ClassUnderTest]Tests to indicate which class is being tested, and each test method uses a naming convention of MethodName_Scenario_ExpectedBehavior to describe what is being tested.

To run the tests, navigate to the FileAnalyzerTests folder in the command line and execute the command dotnet test. The output will show which tests passed and which failed, along with any error messages or stack traces for failing tests.
# Contributing
If you wish to contribute to this project, please feel free to create a pull request with your changes.
# License
This project is licensed under the MIT License - see the LICENSE file for details.

