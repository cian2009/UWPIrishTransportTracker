<a href="https://imgur.com/9NAtgPC"><img src="https://imgur.com/9NAtgPC.png" height="75" width="450" title="Bus Adding Test"/></a>

A UWP application that allows the user to add any transport type from the TFI API.

## Table of contents
* [Getting Started](#getting-started)
	* [Prerequisites](#prerequisites)
	* [Installing](#installing)
* [Running the tests](#running-the-tests)
  * [Adding Transport](#adding-transport)
  * [Viewing transport type before adding ID](#viewing-transport-type-before-adding-id)
  * [Transport ID Examples](#transport-id-examples)
  	* [Bus](#bus)
	* [Train](#train)
	* [Luas](#luas)
* [Windows Store Report](#windows-store-report)
	* [Submission 1](#submission-1-passed)
		* [Automatic Windows Review](#automatic-windows-review)
		* [Manual Windows Review](#manual-windows-review)
		* [Certification Analysis](#certification-analysis)
	* [Submission 2](#submission-2-passed)
		* [Automatic Windows Review](#automatic-windows-review-1)
		* [Manual Windows Review](#manual-windows-review-1)
		* [Certification Analysis](#certification-analysis-1)
* [Built With](#built-with)
* [Installing](#Installing)
* [License](#license)

## Getting Started

- Create blank visual studio UWP application
- Right click on project folder
- Git init
- Git remote add origin https://github.com/cian2009/UWPIrishTransportTracker.git
- Git pull origin master

### Prerequisites

Json parser for c#:
[Newtonsoft Json.NET](https://www.newtonsoft.com/json)

### Installing

A step by step series of examples that tell you have to get a development env running

1.Create Visual Studio 2017 Project

```
File > New > Project > Visual c# > Blank App (Universal Windows)
```

2.Set-up Git Repository

```
Git init
Git remote add origin https://github.com/cian2009/UWPIrishTransportTracker.git
Git pull origin master
```

3. Refresh Visual Studio project

## Running the tests

### Adding Transport

Adding a transport is the first phase of the program

1. Launch application
2. Click 'Add Transport'
3. Type in a valid stopID
	- Bus example: 	 522691
	- Train example: galwy
	- Luas example:  luas10

<a href="https://imgur.com/Uy8LRjL"><img src="https://imgur.com/Uy8LRjL.gif" title="Bus Adding Test"/></a>

### Viewing transport type before adding ID

Trying to view trasnport that hasn't been added

1. Launch application
2. Click 'View Luas'

<a href="https://imgur.com/LSu8tZ0"><img src="https://imgur.com/LSu8tZ0.gif" title="Luas Fail Test"/></a>

### Transport ID Examples

#### Bus

Bus Eireann:
- 522691 - gHotel Dublin Road (Galway)
- 522811 - GMIT Dublin Road (Galway)
- 524351 - Opposite Glenina Heights (Galway)

Dublin Bus:
- 1234 - Ballyshannon Ave (Dublin)
- 2456 - St. James's Road (Dublin)
- 3851 - Station Road (Dublin)

#### Train

- HSTON - Heuston Station (Dublin)
- GALWY - Céannt Station (Galway)
- CORK - Kent Station (Cork)

#### Luas

- LUAS1 - Tallaght (Dublin)
- LUAS10 - Drimnagh (Dublin)
- LUAS16 - Heuston (Dublin)

## Windows Store Report

### Submission 1 (Passed)

#### Automatic Windows Review

The manual review is generated by Visual Studio 2017 after the application is built.

<a href="https://imgur.com/a/AFuHq"><img src="https://imgur.com/qDNoE4A.png" title="Automatic Test"/></a>

#### Manual Windows Review

Windows Store report shows the application passed certification, with a tip for future submission. 

Submission:                |  Certification:
:-------------------------:|:-------------------------:
![](https://imgur.com/zOj6hP6.png)  |  ![](https://imgur.com/GdTz0JL.png)

#### Certification Analysis

Reading the tip about what should be changed is purely a cosmetic change, for the store page of the application.

Image Submitted:           |  Image Change Requested:
:-------------------------:|:-------------------------:
![](https://imgur.com/anhJhIH.png)  |  ![](https://imgur.com/SeAWBEv.png)

Note the change in the picture. The program header in the second is not present and the debug drop down is gone.
This small change is the one which was requested, and why the submission still passed.
Have changed this and resent the project for re-certification.

### Submission 2 (Passed)

The manual review is generated by Visual Studio 2017 after the application is built.

#### Automatic Windows Review

<a href="https://imgur.com/a/W45y4"><img src="https://imgur.com/k0oh3ve.png" title="Automatic Test 2"/></a>

#### Manual Windows Review

After getting feedback about the image change, I created a second submission to correct this.
Even though the problem didn't stop it from reaching the store, I still wanted to rectify the problem.

Submission:                |  Store Page:
:-------------------------:|:-------------------------:
![](https://imgur.com/pZwGPEo.png)  |  ![](https://imgur.com/s7YOoGv.png)

#### Certification Analysis

Passed without any notes

## Built With

* [Visual Studio](https://www.visualstudio.com/) - IDE used
* [Newtonsoft Json.NET](https://www.newtonsoft.com/json) - Json parser for c#
* [StackOverflow](https://stackoverflow.com/) - Community forum for troubleshooting
* [TFI API](https://data.gov.ie/dataset/real-time-passenger-information-rtpi-for-dublin-bus-bus-eireann-luas-and-irish-rail) - API used to access transport status
* [json2csharp](http://json2csharp.com/) - Converts a JSON object to a c# object
* [Prototype](https://github.com/cian2009/IrishBusStopTracker) - Built a prototype to test code functionality before UWP development

## Authors

* **Cian Gannon** - *All source code and UI* - [Github](https://github.com/cian2009)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details

## Acknowledgments

* StackOverflow - How did people code before you existed

## Store Page Details

* **[Irish Transport Tracker](https://www.microsoft.com/en-ie/store/p/irish-transport-tracker/9nzt79c9v0cl)** - Store page for application
