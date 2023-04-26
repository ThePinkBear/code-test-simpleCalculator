# SECTRA – PROGRAMMING

-------------------------------------------------------------------
To run on windows, make sure you have .Net sdk 7.0.200 installed.
- clone the repo
- cd into the folder
- run these commands: "dotnet restore" and "dotnet build"
- To launch the program: "dotnet run"
- To test against a file: "dotnet run <path to file>"
-------------------------------------------------------------------

***Disclaimer***
I did not manage to solve all the things I needed to in order to satisfy all the requirements, thus I didn't have time to do all the refactors I wanted to either, I'm currently working fulltime as an instructor and had to manage my time to the best of my abilities but I will continue on this test for my own amusement when time permits as I found it a good brain tickler.


## ASSIGNMENT – SIMPLE CALCULATOR

Your task is to write a simple calculator that can add, subtract and multiply values in a set of registers.
The syntax is quite simple

```html
<register> <operation> <value>
print <register>
quit
```

Allowed operations are add, subtract and multiply. Here is a simple example:

- A add 2
- A add 3
- print A
- B add 5
- B subtract 2
- print B
- A add 1
- print A
- quit

The output will be:

- 5
- 3
- 6
  
The calculator should also support using registers as values, with lazy evaluation (evaluated at print), e.g. A multiply B. Here is two more examples:

- a add 10
- b add a
- b add 1
- print b
- QUIT
  
The output should be: 11

- result add revenue
- result subtract costs
- revenue add 200
- costs add salaries
- salaries add 20
- salaries multiply 5
- costs add 10
- print result
- QUIT
The output should be:
- 90

Additional requirements:

- Any name consisting of alphanumeric characters should be allowed as register names.
- All input should be case insensitive.
- The program should either take its input from the standard input stream, or from a file.
- When the program is launched with one command line argument, input should be read from the file specified in
  the argument. When accepting input from file, it should not be necessary to include quit to exit the
program.

## Invalid commands can be ignored, but should be logged to the console

You are allowed to use any programming language of your choice, provided you send us information on
how to build and test your program on Windows. Don't hesitate to come back with questions if you feel
anything is unclear. You are free to make assumptions regarding details, but please document them in
the code or a supplied readme file.
You will be evaluated on the readability, simplicity and maintainability of the code. We will also test your
program for major bugs and problems. The program should be easy to understand and make changes or
additions to, e.g adding a division operator.
Please keep all files anonymized!
