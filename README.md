# Puzzle_Game
Find_The_Mafia is a logical puzzle solving game implemented using Microsoft's F# programming language

  This program implements simple logic game which can be played by single player. The player will be given four chances. There are 7 different criminals. The computer randomly chooses three of these (the "perpetrators"), but doesn't tell the players who are chosen. The computer then puts down three random criminals. 0, 1, or 2 of these may be the actual perpetrators. The computer also tells the player how many (but not who) of the three criminals are perpetrators. The players may either guess three criminals who they thing are the actual perpetrators or choose for the next hint/chance. If player guesses wrong, he/she is out of the game. Else in the next hint the computer puts down another three randomly chosen criminals (0, 1, or 2 of which may be actual perpetrators) and tells the players how many (but not who) of these are actual perpetrators. Player can again use logic to deduce the three actual criminals and may guess. Play continues until he/she guesses correctly or have guessed incorrectly in any of the four hints.

#An example play:
1) Assume the criminals are called "a", "b", "c", "d", "e", "f", and "g". The computer chooses three of these randomly say "b", "f" and "g". These criminals are the actual perpetrators. The computer does not reveal this to the players.

2) Now the computer chooses three criminals randomly and displays them to the players. Say "a", "d", and "f" are chosen and displayed. The computer also tells the players that 1 of these criminals is an actual perpetrator.

3) The player may guess who the actual three perpetrators are. Of course, at this point it's not possible to deduce who the actual perpetrators are, so player cannot guess.

4) Since player didn’t guess, the computer again chooses three criminals randomly and reveals them to the player. Say "a", "b", and "f". The computer tells the players that two of these criminals are actual perpetrators, but does not reveal which ones are the real perpetrators.

5) Using logic, the player try to deduce who the actual three perpetrators are and continues until hints complete or answers wrong.

#Logic:
1) In order to write the code for the game Finding Mafia, first create a list of 7 elements (a b c d e f g).

2) Then randomly select 3 elements which will be called "perpetrators" in the game and save those three chosen elements in a list, which in this case is called 'perpetrators'. 

3) The remaining elements are the "non-perpetrators" which are going to be saved in another list, say 'non_perpetrators'. 

4)Now create another list called 'no_of_perpetrators' of three elements by choosing either 0, 1 or 2 elements from the list 'perpetrators' and the remaining elements from the 'non-perpetrators'. 

5)As the game proceeds, with player turn display the items of the list 'no_of_perpetrators' as a hint. Also mention the count of the perpetrators among those 3 elements. 

6)The player will enter his/her guess in another list 'inputUser2' and check will be performed to see if the list is a subset of the list 'perpetrators'. If it is then Player wins, else he loses.
