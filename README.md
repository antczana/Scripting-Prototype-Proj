(10/25/26) - DevLog Update:
MILESTONES: For this sprint, I wanted to clean my code up by making a larger number of small files as opposed to keeping all of the code in one giant file. I also wanted to make it so that you would be required to be near the "NPCs" in order to activate the code, and that the user's view of turning the buff on/off or rolling the dice was nicer. If I had the time, I wanted to add the two scores together and to use that score to determine how many times the user "won."

COMPLETED FEATURES: I was able to implement all of the above features except for the "times won" aspect. I was also able to add boundaries to the player's left/right movement, which I hadn't anticipated but which greatly improves the user experience.

ENGINEER'S JOURNAL: My main technical hurdle was figuring out how to use the Input System as a button, as opposed to having it run on every frame. I was able to solve this by using WasPressedThisFrame, which, while imperfect, is a noticeable improvement over having the code run for every frame that the user is holding the button down. I also struggled to figure out how to access the "Buff" variable across different files, but I was not able to find a clear solution before the deadline. My scope had to be downsized slightly for the non-required tasks, though my required tasks seem to have been met.

AILOG: No AI was used at any point in the development of this code.

(9/27/26) - First README:
MECHANIC: My mechanic revolved around rolling two dice (random number generators). There was also a way to add a skill that increased the score you got.

ARCHITECTURE: My early vs late initialization code live in the start() and update() respectively. I was able to use DeltaTime in the movement of the player character.
I also used the Input system for character movement. I was not able to add an Interface in time. (Sorry)

SCOPE ADJUSTMENT: Unfortunately, I had some struggles with the code early on, so I was unable to implement the win/loss mechanic (where scoring above a certain amount
automatically added to a tally) and the ability to interact directly with the other actors in the scene. Hopefully, with more time these will not be difficult to add.
