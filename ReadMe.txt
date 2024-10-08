LMB - Shoot
W - Up
S - Down
A - Left
D - Right



The singleton works by adding iit to a gameobject 
then selecting the gameobject i needed within my game. In this case 
it was my base heatlh


My observer pattern worked by observing the player in the scene, grabbing
the players health and notifying its subscribers of its changes.

The singleton is similar to the one in the lecture because it is for a manager,
In the lecture the singleton is for a UI manager and in my game it is for the base health or a 
single key componenet

the observer is similar to the ones we've made in class, it reads from a player and tells the other
subsribes to update themselves, in my case the UI