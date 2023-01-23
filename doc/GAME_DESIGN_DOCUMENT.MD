
### Name: ShoeSprint
Created by: [Jakub Cesar](https://github.com/cesarjakub), [Ondřej Kulhavý](https://github.com/OndrejKulhavy), [Rostyslav Levder](https://github.com/RostaJecna)
Last updated: 23.01. 2023


## Table of content
1) [[#Introduction|Introduction]]
2) [[#Level design and game mechanics|Level design and game mechanics]]
	- [[#Level design and game mechanics#Graphics|Graphics]]
	- [[#Level design and game mechanics#Enemies|Enemies]]
	- [[#Game controls|Game controls]]
3) [[#Other|Other]]


## Introduction
In this game, you play as a student who is running away from the janitor because he forgot to put on his shoes. You have to run through the school's hallways and avoid obstacles like lockers, other students, and teachers. Your goal is to escape the janitor and not get caught. The game ends when the janitor finally catches you.


## Level design and game mechanics
Levels are represented by corridors, with varying numbers of obstacles as players progress. To ensure endless gameplay, the levels will be generated algorithmically, resulting in an infinite and dynamic environment.
It's single player game.

### Enemies
There are 3 types of enemies:
1. The Janitor - The main enemy who is chasing the player.
2. Teachers - Each teacher has a unique special ability based on the subject they teach. For example, an ICT teacher can turn off the lights in the corridor, a Chemistry teacher can throw a chemical bomb, a History teacher can throw a book, a Physics teacher can give the player electric shock, and a Biology teacher can throw a frog.
3. The Nerd - An unpredictable enemy who is a student who sometimes helps the teachers and sometimes doesn't, making it hard to predict when he will assist them.
### Obstacles
- School lockers
- Other students
- Lockers
- Benches
- Etd ...


### Graphics
We plan to use 3D low poly graphics like in the picture below:
![Alt text](low%20poly.jpg)

Some of the 3D models used in the game will be created by us (using Blender), while others will be downloaded from the internet.

## Game controls
The student is controlled by the player using a keyboard. The player can maneuver the student left and right, and make him jump over or duck under obstacles to avoid them.

## Other
- Game engine: Unity 3D
- Target platform: Windows