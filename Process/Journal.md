# Journal Entry One

## Game that I like is Counter Strike

### The Counter Strike franchise is a great franchise. I have over 4k hours played from the past couple years. Where I think the game excells is the shooting mechanics. While it seems very simple, there is a defined recoil pattern for each weapon. This makes each interaction ingame against other people rather interesting as it is purely based on how skillful someone is at shooting compared to others. I think another aspect that is always changing is the map design. Counter Strike map design has been known to be one of the best around. Maps includes skyboxes/ other ingame element that may be invisible to players but when taken into account, it can be base for tactics. For example, smoke linups or grenade linups where each is defined by finding pixel perfect spots. These can make up for very different scenarios which makes up for more fun times when playing. Another aspect that is also overlooked by newer players is the idea of timing. Like most shooters, maps and spawns are purposefully placed which directs how one would act in one round. That is mostly what I love about counter strike.

# Journal Entry Two

### Design Values:
 1. Immersion: The game should provide players with a deeply immersive experience, blurring the lines between reality and the virtual world.
 2. Player Agency: Offering meaningful choices and consequences, allowing players to shape the narrative and impact the game world.
 3. Innovation: Introducing novel mechanics or concepts that push the boundaries of traditional game design.

### 1. Echoes of Eternity:
Embark on a journey through a fractured timeline where the player's decisions in one era ripple through the ages. Utilizing time manipulation, players must solve puzzles, forge alliances, and face consequences that echo across different epochs.

### 2. Celestial Odyssey:
Immersing players in a cosmic exploration game where they traverse breathtaking celestial landscapes. The narrative unfolds as they interact with ancient beings, each encounter influencing the cosmic balance and determining the fate of galaxies.

### 3. Nexus Chronicles:
Plunging players into a cyberpunk metropolis where they navigate a web of interconnected stories. Every decision made, from alliances with factions to personal relationships, shapes the city's destiny. The narrative evolves dynamically based on the player's choices, creating a living, breathing urban landscape.

# Journal Entry Three
Prototyping Stage 1 - The idea was to create a simple low fidelity game mechanic. The idea was to make a game that ressembles a platformer/adventure type game. Related to my previous journal entry, Nexus Chronicles above, the idea was to create an exploration game using this simple game mechanic found in the embeded video.
<p align="center">
  <a href="https://youtu.be/_nVTNyTQ1Sw">
    <img src="https://img.youtube.com/vi/_nVTNyTQ1Sw/maxresdefault.jpg" alt="Watch the video" style="width:50%;">
  </a>
</p>

The video consist of three things, a double jump mechanic, wallmount and platforms. This would be the basic game where you can travel to the next stages based on the platforms etc.
After the playtest, there was multiple people that felt as if the game was similar to jump king. So we asked ourselves, how can we improve the idea rather than scrapping it? Puzzles was one of the solutions that intrigued me. Creating a puzzle like platformer where the end-goal is to reach the top. This mechanic could be in the form of a labyrinthe or even items that the player have to collect to get to the endgame.
The next step is to have a more refined prototype of the interaction with different levels ready!

Prototyping Stage 2 - The idea was to explore a different setting from the unity editor called tilemap. The general idea would be a roguelike game that consist of a zombie apocalypse. This next video consist of a barebone game mechanic

<p align="center">
  <a href="https://studio.youtube.com/video/Bxu9QSdyALQ">
    <img src="https://img.youtube.com/vi/Bxu9QSdyALQ/maxresdefault.jpg" alt="Watch the video" style="width:50%;">
  </a>
</p>
This is a simple collision mechanic. The main goal was to use the z as t timemap axis which was new to me to create a different kind of game from what we have been working on. Simple and easy.


# Design Journal One
Initially, I showed my process of the Prototyping Stage 2 to John who at the time was working on a game that was a 2D rogue like top down game. We ended up thinking about incorporating both the idea of an isometric 2D and the rogue like game that he was working on. 
We started with the idea of finding assets from the unity store. The problem was that there weren't many examples of assets which would fit our needs and not a lot of examples of what we wanted to create online which deemed to be quite hard.
Then we decided on making the project a 3D top down project after coming across this.

[![Video Title](http://img.youtube.com/vi/CFymeqMnLOU/0.jpg)](http://www.youtube.com/watch?v=CFymeqMnLOU "Click to Watch Video")

This would essentially be the start of our project. A top down game where we have mechanics like the game Brotato where weapons are homing and a simple movement mechanic along a following camera.

# Design Journal Two
Week two was the start of working on the project. While John was figuring out some part for the camera movement and player movement, I had the task of creating a 3D map that would take place in the city alongside shaders to view behind buildings.

![image](https://github.com/Bimpiel/Cart-315/assets/122397561/7f17eee1-071d-4a2c-94c3-8edba5282568)

I started the process with finding suitable assets to build a small city. These were relatively easy to find on the asset store. It was as simple as dragging and dropping models onto the 3D plane. Next up was adding collision to the building and creaeting a boundary so that the player doesn't walk off the map with the enemies. This task was also relatively easy. I was able to add textures to the building etc.

Next up, creating a night time atmosphere.
![image](https://github.com/Bimpiel/Cart-315/assets/122397561/d319c151-1bc4-424c-b42f-0c0666a52146)
The use of directional lights would allow us to make something that is Darkish for the future as the theme of the project was based in an apocalyptic city.

# Design Journal Three

Week Three started with adding the shaders. This was my first time using shaders in Unity. Initially, we wanted the shader to hide the building completely when the camera is infront of it. That being said, it turned out rather complicated as the 3D models seems to have trouble rendering different sides. For example, the four faces of the building would be completely invisible but the smaller details like the window ceils would remain. 
To solve this problem, We decided to change the shader settings to a simpler one.
![image](https://github.com/Bimpiel/Cart-315/assets/122397561/46ad4594-2204-40bf-a644-594812288ab9)
Basically, it is a radius where we can see the players. To do so, we had to remove the textures and create a material for the 3D models that we were using. This ended up giving the game a bland look which turn out to be rather fitting to what we wanted. 

# Design Journal Four

The final week was the week we decided to do some minor adjustments. 

![image](https://github.com/Bimpiel/Cart-315/assets/122397561/91417912-4c6c-462c-9cd2-5e0eb34d42e4)

Basically, added street lights to improve the aesthetic of the game. While doing so, we ran into a slight problem which was related to the URP. Because we were using spot lights, URP ended up being restrictive as it only allowed us to use 8 spot lights at a time. We ended up exploring other options such as HDRP for the graphics but ended up sticking with URP as we decided it would be best since having random lights working would add to the aesthetic of an apocalypse.


