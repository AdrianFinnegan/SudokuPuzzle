# Print a Soduku Puzzle

### Senior Interview Question

Offline assessment

Time allowed: 20-30mins

#### The Game

A Soduku Puzzle is a logic-based puzzle game that starts with a 9x9 tiled-square - illustrated below. 

To play Sudoku the player must use the numbers from 1-9 inclusive and place each number only once 

1. Within a row left-to-right
1. Vertically top to bottom
1. Within each 3x3 square

#### The problem

Presented with a pattern of 81 digits, draw the initial Sudoku puzzle board.

1. Each row should start with a bar |
1. Each row should end with a bar |
1. Every three rows should be separated with a row of hyphens
1. The header and footer of the puzzle should be closed with a row of hyphens

For example a puzzle may look like this:

The Pattern: 120098357764000000589000000120098357764000000589000000120098357764000000589000000

|- - -|- - -|- - -|
|1 2  |  9 8|3 5 7|
|7 6 4|     |     |
|5 8 9|     |     |
|- - -|- - -|- - -|
|1 2  |  9 8|3 5 7|
|7 6 4|     |     |
|5 8 9|     |     |
|- - -|- - -|- - -|
|1 2  |  9 8|3 5 7|
|7 6 4|     |     |
|5 8 9|     |     |
|- - -|- - -|- - -|

Zeros have been used in the Pattern string to represent a space or non-number. You can use whichever you need.

Note this is for illustrative purposes only. The puzzle will not be solvable with the numbers from this pattern. The objective is just to draw the board. You maybe use this pattern and output as a guide.


#### Observation

This follows the same concept of a FizzBuzz test. I have included a FizzBuzz Test for reference.

Given the numbers 1..N, for every number that is divisible by 3, write "Fizz". For every number divisible by 5, write "Buzz". For any number that is both divisible by 3 and 5, write "FizzBuzz". A number should only have one output.