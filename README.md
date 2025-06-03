# ca-Mike14533-1
ca-Mike14533-1 created by GitHub Classroom
Report:

Summary of Game:
In my game you are placed in a strange desert at night with a large statue taking the centrepiece of the landscape, at the foot of a statue is an altar. Within the surrounding landscape are abandoned building, desert flora, rusted cars etc. Within this landscape are wandering undead who will chase the player, the aim of the game is to gather three totems that look like skulls and place them on the altar to stop the undead and ultimately beat the game.
Currently my game is an unfinished work, but so far I have included the following features that are important for a VR game: VR Locomotion, Grabbable Objects and Sockets.
VR Project Setup:
My project is set up as a scene in which all the assets used in the game are included. Here are some images of the projects map.
Birds Eye view of the game Map:

 ![image](https://github.com/tussoftwaredesign/ca-Mike14533-1/assets/123557009/fc29fb52-ac9a-4221-b2d9-aa8bba10e73d)

Isometric View of the map:
 
![image](https://github.com/tussoftwaredesign/ca-Mike14533-1/assets/123557009/4b5396c8-3edd-483f-acce-1508f79ea831)

The Map includes several structures, the structure most important to the playing of the game is the statue in the centre of the map, at the foot of the statue is an altar:
 ![image](https://github.com/tussoftwaredesign/ca-Mike14533-1/assets/123557009/0ca6c5f0-4e47-45e1-9aba-0bb6d3a11163)

The altar serves as the only interactable object that is static.
There are three sockets on the altar that serve the purpose of holding the three totems that have been scattered across the map.



Frontal view of a totem:

 ![image](https://github.com/tussoftwaredesign/ca-Mike14533-1/assets/123557009/5d11dc48-af8b-4548-b9fa-a5870d936188)

To aid you in finding the totems I have made two objects a flashlight and a compass.
The flashlight and compass side by side:

 ![image](https://github.com/tussoftwaredesign/ca-Mike14533-1/assets/123557009/0c7eb630-44cb-40c7-bbd2-467bfb00814b)

The flashlight acts exactly as real flashlight does, it showers a beam of light into the direction it is pointed at.











The flashlight in use:

![image](https://github.com/tussoftwaredesign/ca-Mike14533-1/assets/123557009/85b8a4c9-db89-4f31-8967-2d22720f67a3)

 
*note the flashlight is dimmed to give more fear to the player.

The compass is a sphere with needles in it that point to the direction that the totems are.

Organisation of the Hierarchy:

 ![image](https://github.com/tussoftwaredesign/ca-Mike14533-1/assets/123557009/da2e0722-1a03-459c-9215-9c3ab552f491)

Within my game the objects included are sorted into the hierarchy based on what characteristic they qualify as, the categories being an object associated with XR, the object behaving in a static manner or the object behaving in a dynamic manner. 
VR Locomotion:
For the locomotion of the player I opted to use continuous motion as I felt that for the open world aspect of the game it would suit better for moving around terrain and would add to a sense of realism of that you are being chased by zombies, whereas I feel that if I were to use teleportation it wouldn’t add to that sense of realism, perhaps in the future when I build upon my game I could add the teleportation feature in some area, but I feel that it would have to remain within a confined area or serve it’s purpose.
Grabbable objects:
In my game currently I have three grabbable objects the flashlight, the compass and the totems. All have been described above. The improvements I would like to make on these objects, would be to give them more functionality, such as for the flashlight I would like to give it a script that allows for the player to turn it on and off. I also thought that I shoot a ray out of that when its on that if it were to come into contact with a zombie it would stun the zombie momentarily. As for the compass I would like to make it smaller and attach to the players hand so they aren’t carrying it around, it would serve immediately in showing the player the direction to the totems. As for the totems functionally I would leave them the same as they are currently, but when all of them are placed on the altar I would allow for an event to occur. I also intend on updating the map of the game so that there may be more challenging aspects to finding the totems than just searching in the dark.
Sockets:
I have three sockets on the altar object for the totems to be placed, currently when all three sockets are full there is no functionality but I intend to add a feature so that when all totems are placed an event occurs.
Enemies:
Currently I have one enemy type that of which is a zombie,

 ![image](https://github.com/tussoftwaredesign/ca-Mike14533-1/assets/123557009/be08c67d-2b53-4e6a-8b51-2883843cdeff)

Currently they just follow the player wherever the go and rotate according to the direction that the player is headed, what I would like to do is to upgrade the movement of them, and add sounds and attacks to increase their fear factor onto the player. One issue that I am hoping to get resolved from their current script is that if they were to walk into the obstacle they try to walk through the obstacle instead of walking around the obstacle, I would also like to add a range for them to sense the player.
Reflection:
Upon Reflection, I believe what I have achieved so far in my game demonstrates apt technical ability. I believe that the player would not immediately be able to play the game without understanding of how to play, and that is something that I intend to work on by making the game more intuitive in areas and by giving the player more instruction on what to do, this can be achieved in multiple ways but the way I intend on doing it is by adding some story elements to the game, so narratively it makes sense that by collecting three totems and putting them on an altar would stop the undead. Improving the behaviour of the zombie enemies to instil a better fear factor. 
