--CS3383 Breakout

-Description

This is a Breakout Game I made for Class and it has several additions like sound effects and background music along with a help page.

-Requirements

Windows computer
Unity Hub
Unity Editor 6.5 (60000.5.10f1)
Git if cloning the project
-Downloading the Project




The project is available on GitHub:

https://github.com/Gavin-Wolff/Breakout

To download the project using Git:

Install Git from https://git-scm.com/downloads
Open Git Bash.
Navigate to the folder where you want to store the project.
Run:
git clone https://github.com/Gavin-Wolff/Breakout
This will create a Breakout folder containing the Unity project.

-Opening the Project in Unity

-If you do not have Unity navigate to their website and follow the download instructions. https://unity.com

Open Unity Hub.
Select Add or Open.
Select the downloaded Breakout project folder.
Open the project using the Unity Editor version used to create the project(mentioned at beginning).
Open the game's scene from the Assets folder.
Press the Play button at the top of the Unity Editor to run the game.
Unity may take some time to import the project the first time it is opened.

-Controls

A / D to move the paddle
H to open and close the help menu
Escape to quit the game
The Help screen can be opened at any time during gameplay. When the Help screen is open, the game is paused. Pressing H again closes the Help screen and resumes the game.

-Gameplay

The objective is to destroy all of the tiles while keeping the ball in play.

The player earns one point for each tile destroyed. If the ball enters the lose area, the game resets. The score is reset, the ball returns to its starting position and size, and the tiles are recreated. The Help screen is then displayed and the game is paused until the player presses H.

The ball also has random gameplay effects when hitting tiles:

10% chance: The tile does not break.
5% chance: The ball's speed doubles.
5% chance: The ball's size doubles.
-Building the Game

To create a standalone Windows build in Unity:

Open the project in Unity.
Select File → Build Settings (or Build Profiles, depending on the Unity version).
Select the Windows build target.
Make sure the game's scene is included in the build.
Build the project into a new folder.
Name the executable:
breakout.exe
The entire build folder must be kept together. The executable will not run correctly without its accompanying _Data folder and other Unity files.

-Project Structure

The main project files are organized as follows:

Assets/ — Game scenes, scripts, prefabs, audio, and other game assets.
Assets/Scripts/ — C# scripts controlling the game.
Assets/Audio/ — Background music and sound effects.
Packages/ — Unity package information.
ProjectSettings/ — Unity project configuration.

