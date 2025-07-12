Mastermind Game

Mastermind is a simple console game built with C#. The player tries to guess a secret 4digits code. Each digit must be from 0 to 8, and the player has a limited number of attempts.

---
 ## How to Play?

•⁠  ⁠A random 4-digit secret code is generated at the start.
•⁠  ⁠On each turn, the player enters a 4digits guess.
•⁠  ⁠After each guess, the game gives feedback:
  - Well placed : number of digits that are rignt and in the right position.
  - Misplaced: number of right digits but in the wrong place.
•⁠  ⁠If the guess is correct, the message shows:
You cracked the code!
•⁠  ⁠If the attempts run out, it displays:
Out of attempts! The code was:xxxx

## How to Run the Game

1.⁠ ⁠Open terminal.
2.⁠ ⁠Run the command:dotnet run –project MasterMindGame.cspro

## Optional

You can run the game with custom settings:

•⁠  ⁠⁠ -c [CODE]⁠ : set your own 4digits secret code (⁠ -c 1234 ⁠)
•⁠  ⁠⁠ -t [ATTEMPTS] ⁠ : set number of allowed attempts (⁠ -t 15 ⁠)