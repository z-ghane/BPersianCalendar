## To create a .dll file

Maybe in bellow situations you want to create a .dll file with different settings:
- you have problems using .dll files that are prepared by us 
- you want to create one with differente settings so that it will be compatible with your .Net Framework, device, etc.

The step by step guide for creating a .dll file (based on Microsoft Visual Studio 2022):

1- Open source code project

2- Select project name

2- RIGHT CLICK on it

3- choose Properties

3- Application

4- Output type: "Class Library"

5- Build > Platform target: << x86 / x64 / Any cpu >>

6- Save

Note: Don't Run it Or you will get Error 

7- Go to "Build" tab

8- Select "Build Solution"

9- Your .dll file is now ready here: "bin > release > BPersianCalendar.dll"
