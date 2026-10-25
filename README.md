Forest_Game — Computer Graphics Project

Project Overview

Forest_Game is a 3D Unity project created for the Introduction to Computer Graphics course at Ontario Tech University. The project explores real-time lighting, custom shaders, and colour grading in a forest environment.

The player can explore the scene and interact with objects. The graphics features improve visibility, highlight important objects, and establish the visual style of the environment.

Project Proposal

The goal of this project is to apply computer graphics concepts to an interactive 3D forest scene. I am focusing on lighting techniques, custom outlines, and colour correction to improve the appearance and readability of the environment.

Graphics Implementations

 1. No Lighting
    
    No lighting screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20153255.png

    made a base material and removed all lighting from it, and gave it the tree colour 
    

Diffuse lighting 

Diffuse lighting uses the surface direction and the direction of the light to determine how brightly a surface is illuminated.

I implemented diffuse lighting using Unity Shader Graph. This helps objects in the forest respond to light and makes their shapes and surfaces easier to distinguish.

diffuse only Shader Graph -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160448.png
diffuse lighting in game -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160448.png

Different from in class-- I'm not really sure how it differs, this is my own work and I could not find anything other then code on diffuse lighting which is obviously different from shader graphs. I can assure no in class shader graphs were copied. All I did was add a simple Fresnel effect to a colour I thought was a good highlight for my scene and multiplied them together.  

 2. Ambient Lighting

Ambient lighting adds general illumination to surfaces that might otherwise appear too dark.

I implemented ambient lighting using Shader Graph so that objects remain visible in areas without strong direct lighting. This helps maintain visibility throughout the forest environment.

pressing 2 in game will change all the trees to ambient only 

Ambient only screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160345.png
Ambient Shader graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160502.png

How it differs- Same thing not really sure. I have missed a good amount of classes so I don't really know what was referenced in class. But my ambient light just takes in the colour of the trees and amplifies it  

 3. Specular Lighting

Specular lighting adds highlights to surfaces based on the relationship between the light, surface, and viewing direction.

I implemented specular lighting using Shader Graph to give selected surfaces additional highlights and make the lighting more visually noticeable.

You can see this by pressing 3 in game 

Specular Lighting screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160352.png
Specular Lighting shader graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160443.png

My ambient only shader just converts the world direction and the main camera direction so we know what angle the light comes from, into a normalized value, then takes the dot product of that value with the normalized world vector, and adds saturation and shininess to those places  

Combining them

You can combine them by pressing 4 in game 
this takes all 3 and adds them together 

--This just takes all the math above and adds them together

Shader Graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160438.png
in game screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160357.png

and then pressing 5 will add my custom outline shader to the trees as well as all the lighting above 

Shader Graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160427.png
in game screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160403.png

This is the exact same thing as number 4 but it adds the blue border around it 


4. Custom Shader One — Blue Radio Outline

I created a blue outline shader for the radio. The outline helps the player recognize the radio as an interactable object, making it easier to understand where interaction is possible.

Purpose: Improve player guidance and make an important interactive object stand out.

Shader Graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20162217.png
in game screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20162131.png

 5. Custom Shader Two — Cyan Tree-Leaf Outline

I created a cyan outline shader for the tree leaves. The outline adds visual emphasis to the foliage and helps the leaves stand out against the surrounding forest.

Purpose: Improve the visual appearance of the environment and give the foliage more definition.

Shader Graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20162208.png
in game screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20162154.png


 Colour Grading
I failed to figure the colour grading out for the scene and gave up 


## Project Progression Reflection

During this project, I developed a 3D forest environment and explored how computer graphics techniques can improve an interactive scene. I used Shader Graph to implement lighting effects and created two custom outline shaders. The blue radio outline helps communicate interaction, while the cyan tree-leaf outline adds emphasis to the foliage. These features helped me understand how shaders can serve both functional and artistic purposes. I also began experimenting with LUT-based colour grading but could not figure out the implementation in time 

## Playable Build

**Windows build:** Add the link to the GitHub Release containing the playable build once it has been created and tested.

## Presentation

**Project video:** Add the link to the unlisted YouTube presentation once it is uploaded.

The presentation will demonstrate the project, explain the graphics implementations, and discuss what I learned during development.

## AI Use Acknowledgement

No AI use 

## Repository

This repository contains the Unity project files and supporting documentation. The final submission will include the required screenshots, a tested playable build, and the project presentation.
