# guessing-game

## NSS Book 1 (Tabloid) Ch 12

Guessing Game
A C# Exercise
Write a console program in C# that invites the user to guess a number.

The program should be written in increments. Each phase will add a little more complexity.

Phase 1
The program should...

Display a message to the user asking them to guess the secret number.
Display a prompt for the user's guess.
Take the user's guess as input and save it as a variable.
Display the user's guess back to the screen.
Phase 2
The program should be updated to...

Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
No longer display the user's guess. They know what they guessed, right?
Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
Phase 3
The program should be updated to...

Give the user four chances to guess the number.
Continue to display the success or failure messages as in phase 2
Phase 4
The program should be updated to...

Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
End the loop early if the user guesses the correct number.
Phase 5
The program should be updated to...

Use a random number between 1 and 100 instead of a hard-coded number.
The prompt should display the number of guesses the user has left.
Phase 6
The program should be updated to...

Inform the user if their guess was too high or too low, when they guess incorrectly.
Phase 7
The program should be updated to...

Prompt the user for a difficulty level before they are prompted to guess the number.
The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
Easy - this gives the user eight guesses.
Medium - this gives the user six guesses.
Hard - this gives the user four guesses.
Phase 8
The program should be updated to...

Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.
