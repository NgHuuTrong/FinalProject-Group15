# CS427 - Game Report: Robot Adventure 3D  
**GROUP - 15**

## 1. Introduction  
"Robot Adventure 3D" is a 3D game developed using Unity and C#. In this game, the player controls a robot character as it runs through three main levels filled with obstacles, such as spikes, pits, and enemies. Each level progressively becomes more challenging, requiring players to be quick, skillful, and strategic. The objective is to collect coins, avoid obstacles, and fight enemies, including a final boss battle. The game features checkpoints, health bars, AI-controlled enemies, and coin-collecting mechanics, which all enhance the gameplay experience.

## 2. Game Ideas  
The concept behind "Robot Adventure 3D" revolves around a robot exploring different worlds. The player controls this robot as it runs and jumps to avoid hazards such as deep pits, sharp spikes, and enemy attacks. These elements challenge the player to make precise movements and strategic decisions to advance through the levels. Along the way, the robot collects coins to increase the score and activates checkpoints, allowing it to resume progress from the last checkpoint when it dies.

Enemies in the game are controlled by AI, which actively chases and attacks the robot when it gets too close. At the end of each level, the player faces a boss—an advanced robot with powerful abilities and unique combat mechanics.

## 3. Features  
### 3.1 Player Character and Obstacles  

#### Main Robot:  
The player controls a highly advanced robot equipped with the ability to run and jump its way through an array of challenges scattered across various levels. The robot’s movement is fluid, with responsive controls allowing the player to easily navigate complex environments filled with traps and hazards. The robot can jump over obstacles, run across platforms, and engage in combat with enemies it encounters.

#### Obstacles:  
Each level is filled with a variety of obstacles that are designed to challenge the player’s skill and reflexes. These obstacles include sharp spikes that can instantly damage the robot, deep pits that cause the robot to fall to its demise, and enemy AI scattered throughout the level. The placement of obstacles becomes progressively more difficult, requiring players to carefully time their jumps and movements. For instance, spikes may appear on moving platforms, and pits may have enemies patrolling nearby to make navigation trickier.

#### Checkpoints:  
To reduce frustration and enhance the flow of the game, each level features strategically placed checkpoints. These checkpoints save the player's progress, allowing them to respawn there when the robot dies rather than starting the level from the beginning. The frequency of checkpoints varies depending on the difficulty of the level, with more difficult stages featuring fewer checkpoints to test the player's skills. Checkpoints are often located before particularly challenging sections, such as enemy-heavy areas or complex platforming sequences.

#### Health Bar:  
The robot has a visible health bar displayed, which decreases when the robot is hit by enemies, environmental hazards, or traps like spikes. The health bar can be replenished through health pickups scattered throughout the level or awarded upon defeating certain enemies. Once the health bar is depleted, the robot "dies," and the player will respawn at the most recent checkpoint. Players can manage health carefully to survive longer, especially in challenging areas or during boss fights.

### 3.2 Enemy AI  

#### Chasing Behavior:  
The enemies in the game are equipped with AI that detects the player when the robot enters their range of vision or proximity. Once the robot is detected, enemies switch from a passive patrol state to an active pursuit, chasing the robot until they either catch up or the robot manages to escape their detection range. The enemies may vary in their chasing behavior, with some moving quickly but with limited stamina, while others slowly stalk the robot, forcing the player to deal with them strategically.

#### Attack Mechanics:  
When an enemy gets close enough to the robot, it initiates an attack sequence. These attacks can vary between melee strikes, ranged projectiles, or area-of-effect moves depending on the type of enemy. Each hit from an enemy reduces the robot’s health, and players must either evade or counter the attacks to minimize damage. Certain enemies may even possess special abilities, such as poison attacks that drain health over time or stunning attacks that temporarily immobilize the robot.

### 3.3 Coin Collecting  
Coins are scattered throughout each level, serving as a secondary reward system that motivates players to explore and take risks. These coins are often hidden in hard-to-reach places or located in areas guarded by enemies, requiring players to balance the risks and rewards of collecting them. Coins may be used as currency to unlock new abilities, purchase upgrades, or unlock new skins and customization options for the robot. The more coins a player collects, the greater their ability to enhance their robot’s abilities, offering a sense of progression.

### 3.4 Boss Battles  

#### Final Challenge:  
At the end, the player encounters a boss battle. The boss is far more formidable than regular enemies, possessing unique abilities that force the player to adjust their playstyle.

#### Increased Difficulty:  
The boss has significantly more health than regular enemies, meaning players need to deal sustained damage while avoiding their attacks. Bosses also deal more damage, often able to deplete the robot’s health bar with just a few hits.

### 3.5 Settings  

#### Music Volume:  
Players can adjust the background music volume to their preference, allowing them to either turn the music off completely or increase it for a more immersive experience.

#### Sound Effects Volume:  
Similar to music volume, players have control over the sound effects volume. This includes the sounds made by the robot, enemies, environmental cues, and other in-game interactions.

### 3.6 Menu  

#### CONTINUE  
Allows players to resume their game from the last saved checkpoint or level.

#### NEW GAME  
Starts a new playthrough, resetting all progress and taking the player back to the beginning of the game.

#### QUIT  
Exits the game and returns to the main screen or closes the application.

### 3.7 Level Select Screen  
The Level Select Screen allows players to choose from previously completed levels, replaying them to improve their score, collect missed coins, or try out new strategies. This screen may display each level's completion status, including the number of coins collected, time taken, and achievements earned. Players can also see which levels they have yet to unlock, motivating them to progress through the game and unlock more challenging stages.

## 4. Techniques  
### 4.1 3D Players & Animations  
In this project, a 3D player character was implemented using Unity's animation system, incorporating keyframe-based techniques to create smooth transitions between idle, walking, and jumping states.  
The Animator Controller was utilized to blend animations based on user input, ensuring fluid motion and interaction with the game environment. Additionally, inverse kinematics (IK) was applied to enhance realism, allowing the player to interact with objects dynamically within the 3D space.

### 4.2 Camera Systems  
A dynamic camera system was implemented using Unity's Cinemachine package to create smooth and responsive camera movements. The camera follows the player character with adjustable parameters like zoom, rotation, and damping to maintain an optimal view during gameplay. Additionally, custom camera transitions were created for different scenes, providing seamless shifts between third-person, first-person, and cutscene perspectives, enhancing the overall player experience.

### 4.3 3D Environment  
The 3D environment in this project was created using Unity's terrain tools, allowing for realistic landscapes with detailed textures, and dynamic lighting. Various assets such as blocks, grass, and coins were integrated, while techniques like occlusion culling and level of detail (LOD) optimization were applied to ensure smooth performance across different hardware setups.

### 4.4 Particle System Effects  
The particle system in this project was used to create dynamic visual effects such as fire, smoke, and explosions, enhancing the game's atmosphere and realism. By adjusting parameters like particle size, speed, and emission rate, as well as utilizing custom shaders, the effects were tailored to suit different in-game scenarios while maintaining performance efficiency.

### 4.5 Lighting System  
The lighting system in the project utilized both real-time and baked lighting to achieve a balance between performance and visual quality. Techniques like global illumination, directional lights, and shadows were implemented to create a realistic and immersive 3D environment, enhancing depth and mood in the game.

### 4.6 UI  
The UI system was designed using Unity's Canvas to create responsive and intuitive interfaces, including menus, health bars, and in-game notifications. Techniques like anchoring, layout groups, and custom animations were applied to ensure the UI adapts seamlessly across different screen resolutions and devices.

### 4.7 AI Implementation  
The enemy AI was developed using Unity's NavMesh system, which allows enemies to navigate through the environment intelligently. This system helps enemies chase the robot around obstacles and navigate the terrain effectively.  
State machines were used to switch between different behaviors, such as idle, chase, and attack. Each enemy transitions between these states based on the player's proximity and actions.

### 4.8 Checkpoint System  
A checkpoint system was implemented to save the robot's progress within a level. When the robot dies, it respawns at the last activated checkpoint. Checkpoints were added as trigger zones, and once the player crosses a checkpoint, it is activated.

## 5. New Features Added by Our Team  
Among all the features and techniques presented earlier, the following are the new additions implemented in our project:  

### 5.1 More Levels with Increased Difficulty  
We have expanded the game with new levels, each progressively harder and more complex, requiring refined strategies and skills from the players.

### 5.2 More Challenging Boss Battles  
Boss fights have been enhanced with tougher enemies, featuring new attack patterns and abilities, offering a greater challenge to experienced players.

### 5.3 New Enemy Types and Abilities  
We introduced new enemy types with unique abilities, such as flying enemies and enemies that can teleport. These new enemies test the player’s adaptability and quick thinking.

## 6. Conclusion  
The "Robot Adventure 3D" project has provided our team with an excellent opportunity to apply and expand our skills in Unity development, AI programming, and game design. We were able to build upon a solid base game idea and create new features that improve the overall gaming experience. Through this project, we have enhanced our understanding of 3D game mechanics, AI behaviors, animation systems, and the importance of testing and optimization in game development. We hope to continue improving this game by adding even more features and refining the gameplay for future releases.

## 7. References  
- Unity Documentation: https://docs.unity3d.com  
- Cinemachine: https://unity.com/cinemachine  
- Unity NavMesh: https://docs.unity3d.com/Manual/nav-NavigationSystem.html  
- Particle System: https://docs.unity3d.com/Manual/PartSysMainModule.html  
