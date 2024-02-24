# HTTP-5125-RNA
## JERRY BORGES JACOB | n01665068
## Assignment 2 
The files for assignment-2 can be found in this repository.

### File path:
HTTP5125-Assignment2 --> Controllers

### Questions Attempted (given in detail below)
* J1 - CCC 2022
* J2 - CCC 2012
* J3 - CCC 2011

### NOTES:
- All the questions in the assignment have been attempted.
- All the files have been verified to run.
- All the answers were verified to give correct answers.

## Questions
### Problem J1: Cupcake Party
**Problem Description**
<br/>
A regular box of cupcakes holds 8 cupcakes, while a small box holds 3 cupcakes. There are
28 students in a class and a total of at least 28 cupcakes. Your job is to determine how many
cupcakes will be left over if each student gets one cupcake.
<br/>
**Input Specification**
<br/>
The input consists of two lines.
• The first line contains an integer R ≥ 0, representing the number of regular boxes.
• The second line contains an integer S ≥ 0, representing the number of small boxes.

**Output Specification**
<br/>
Output the number of cupcakes that are left over.

**Sample Input**
<br/>
GET : localhost.xx/api/J1/Cupcakes/4/2 

**Output for Sample Input**
<br/>
"There are 10 cupcakes leftover.

### Problem J2: Sounds fishy!
**Problem Description**  

A fish-finder is a device used by anglers to find fish in a lake. If the fish-finder finds a fish, it will
sound an alarm. It uses depth readings to determine whether to sound an alarm. For our purposes,
the fish-finder will decide that a fish is swimming past if:<br/>
• there are four consecutive depth readings which form a strictly increasing sequence (such as
3 4 7 9) (which we will call “Fish Rising”), or <br/>
• there are four consecutive depth readings which form a strictly decreasing sequence (such as
9 6 5 2) (which we will call “Fish Diving”), or <br/>
• there are four consecutive depth readings which are identical (which we will call “Constant
Depth”). <br/>
All other readings will be considered random noise or debris, which we will call “No Fish.”
Your task is to read a sequence of depth readings and determine if the alarm will sound.
<br/>
**Input Specification**  
<br/>
The input will be four positive integers, representing the depth readings. Each integer will be on
its own line of input.

**Output Specification**
<br/>
The output is one of four possibilities. If the depth readings are increasing, then the output
should be **Fish Rising**. <br/>If the depth readings are decreasing, then the output should be **Fish
Diving**. <br/>If the depth readings are identical, then the output should be **Fish At Constant
Depth.** Otherwise, the output should be **No Fish**.

**Sample Input**
<br/>
GET : localhost.xx/api/J2/FishFinder/1/2/3/4

**Output for Sample Input**
<br/>
 "Fish Rising"

### Problem J3: Sumac Sequences
**Problem Description**
<br/>
In a sumac sequence, t1, t2, .., tm, each term is an integer greater than or equal 0. Also, each term,
starting with the third, is the difference of the preceding two terms (that is, tn+2 = tn − tn+1 for
n ≥ 1). The sequence terminates at tm if tm−1 < tm.

For example, if we have 120 and 71, then the sumac sequence generated is as follows:
120, 71, 49, 22, 27.
<br/>
This is a sumac sequence of length 5.

**Input Specification**
<br/>
The input will be two positive numbers t1 and t2, with 0 < t2 < t1 < 10000.

**Output Specification**
<br/>
The output will be the length of the sumac sequence given by the starting numbers t1 and t2.

**Sample Input**
<br/>
GET : localhost.xx/api/J3/Sumac/120/71

**Output for Sample Input**
<br/>
"There are 5 numbers in the sequence."

-------END OF README-------
