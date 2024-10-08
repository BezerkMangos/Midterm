Controls
LMB - Shoot
W - Up
S - Down
A - Left
D - Right

I made my scene similar to that within the image shown, i did leave out a few items for the sake of time
i added enemy takes, didn't make a spawner, i instead placed them acround the map, i had a player that could move rotate and fire
i also had a base where the player could die from or if the player took 20 hits it would be destroyed but i didn't add a death screen 
because of the time limit.



The singleton pattern within my game is used to make sure there is always a base heatlh. The square at the
Top of my scene is where my base is to i attached a singleton onto that to ensure a component script of "base health"
would always spawn

Next i had my observer pattern, this pattern look at the player, it then notified its subscribers whenever the players health changes
The UI Text at the top left is updated anytime the players gets hit but my UI does not 
talk to the player instead it goes through my UI Observer script.

I also accidentantly submitted my theoricical exam before i finished by pressing the submit
instead of next question so if my mark is really low for that part, that is the reason unforunaly.