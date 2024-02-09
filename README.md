## About The Project

We are a team that developps software for the publisher ProSoft.
Our project name is “EasySaveHARG” which consist of a backup software.
Like any software in the ProSoft Suite, the software will fit into the pricing policy.
 - Unit price: 200 € HT
 - Annual maintenance contract 5/7 8-17h (updates included): 12% purchase price (tacit renewal annual contract with revaluation based on the SYNTEC index)

During this project we are responsible of the archiutecture of the application, the development and the managment of differents versions, but also the user documentation.
In order for our code to be reusable by another team, we have respected certain constraints and tools (cf <a href="#built-with">Built With</a>).


### Built With

This is the list of the major technologies that we used in this project.

 - [Visual Studio 2022]
 - [.Net Framework for C#]
 - [GitHub]


### Version 1.0 - Console Version

The specification for this version are the following :
 - The software use the .Net Core.
 - The software allow the user to do 5 backup works
 - One backup work is defined by : 
     - Name
     - Source
     - Destination
     - Type (Complete or Differential)
 - The user can request that one of the backup jobs run or that the jobs run sequentially.
 - The directories (sources and targets) should be on local disks.
 - All items in the source directory are affected by the backup.
 - A change of language between English and French.


### Log file

The software must write in real time in a daily log file the history of the actions of the backup jobs. The minimum information expected is:
 - Timestamp
 - Backup Job Name
 - Full address of the Source file (UNC format)
 - Full address of the Destination file (UNC format)
 - File Size


### State file

The essential information to be recorded includes:

 - Timestamp
 - Backup Job Name
 - Backup Job Status (e.g., Active, Not Active...)
 - If the job is active:
   - Total number of eligible files
   - Size of the files to be transferred
   - Progress
   - Number of remaining files
   - Size of the remaining files
   - Full address of the Source file being backed up
   - Full address of the destination file


### Getting Started

You need to follow the differents steps below to run the software properly.

### Prerequisites

In order to run this project you need to work with :

 - Visual Studio 2022 or the .NET SDK
 - Github 

### Installation

1. Clone the repo

   To clone the repository : https://github.com/hamzaajili1/ProjetEasySaveGHRA.git

2. You can now open the project on Visual Studio


### Usage

Now that you have clone the project, you can open it. To launch the software you need to execute the EasySave.exe file or use Visual Studio.
You can now display, add, remove and execute any backup work via the main menu interface.


### Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are  - -greatly appreciated - -.

1. Fork the Project
2. Create your Feature Branch
3. Commit your Changes
4. Push to the Branch
5. Open a Pull Request


### License Information

This project is private property of ProSoft and is distributed under the terms of the ProSoft licensing agreement.
