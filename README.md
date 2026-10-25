Forest_Game — Computer Graphics Project

Project Overview

Forest_Game is a 3D Unity project created for the Introduction to Computer Graphics course at Ontario Tech University. The project explores real-time lighting, custom shaders, and colour grading in a forest environment.

The player can explore the scene and interact with objects. The graphics features improve visibility, highlight important objects, and establish the visual style of the environment.

Project Proposal

The goal of this project is to apply computer graphics concepts to an interactive 3D forest scene. I am focusing on lighting techniques, custom outlines, and colour correction to improve the appearance and readability of the environment.

Graphics Implementations

 1. No Lighting
    
    No lighting screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20153255.png


Implementation: I created a base material using the tree's colour without applying lighting calculations.

How it works: The material displays its base colour without calculating how light illuminates the surface. This provides a baseline for comparing the other lighting techniques.
    

Diffuse lighting 

Diffuse lighting calculates how strongly a surface is illuminated based on the angle between its surface normal and the direction of the light.

Implementation: I used Unity Shader Graph to create a diffuse lighting effect for the forest environment.

Basic calculation:

NdotL = max(0, dot(N, L))

N is the normalized surface normal.

L is the normalized direction toward the light.

dot(N, L) calculates how closely the surface faces the light.

max(0, ...) prevents the diffuse contribution from becoming negative.

The diffuse contribution is then multiplied by the light colour and the surface's base colour.

How it benefits the scene: Diffuse lighting makes the shapes of objects easier to distinguish by illuminating surfaces according to their orientation.

How my implementation differs: I built the shader using a visual Shader Graph rather than writing the shader entirely in HLSL. This allowed me to connect and adjust the shader operations visually for my scene.

diffuse only Shader Graph -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160448.png
diffuse lighting in game -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160448.png


 2. Ambient Lighting

Ambient lighting adds general illumination to surfaces that might otherwise appear too dark.

I implemented ambient lighting using Shader Graph so that objects remain visible in areas without strong direct lighting. This helps maintain visibility throughout the forest environment.

pressing 2 in game will change all the trees to ambient only 

Ambient only screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160345.png
Ambient Shader graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160502.png

How it differs- Same thing not really sure. I have missed a good amount of classes so I don't really know what was referenced in class. But my ambient light just takes in the colour of the trees and amplifies it  

 3. Specular Lighting

Specular lighting produces highlights on surfaces based on the relationship between the light, the surface orientation, and the viewing direction.

Implementation: I created a specular lighting shader using Unity Shader Graph. Pressing the number 3 key switches the scene to the specular-only mode.

Basic calculation:

V = normalize(Direction from Surface to Camera)

R = reflect(-L, N)

Specular = pow(max(0, dot(R, V)), Shininess)

L is the direction toward the light.

N is the surface normal.

V is the direction toward the camera.

R is the reflected light direction.

Shininess controls how concentrated the highlight is.

The calculation produces a stronger highlight when the reflected light direction closely matches the viewing direction. This is a simplified reflection-vector specular model.

How it benefits the scene: Specular lighting makes highlights more noticeable and demonstrates how lighting can change the appearance of surfaces.

Specular Lighting screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160352.png
Specular Lighting shader graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160443.png



Pressing the number 4 key switches to the combined lighting mode.

Implementation: This mode combines the diffuse, ambient, and specular lighting contributions.

Simplified calculation:

Final Colour = Diffuse + Ambient + Specular

In a practical shader, the contributions may also be multiplied by their respective light and material colours before being combined.

How it benefits the scene: Combining these techniques provides a more complete lighting result. Diffuse lighting defines surface orientation, ambient lighting adds general illumination, and specular lighting creates highlights.

Shader Graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160438.png
in game screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160357.png

Combined Lighting with Custom Outline

Pressing the number 5 key adds the custom outline effect to the combined lighting mode.

Implementation: I combined the lighting effects with a blue outline effect on the trees.

How it benefits the scene: The outline adds visual emphasis and helps distinguish the tree shapes from the surrounding environment.

Shader Graph screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160427.png
in game screenshot -- https://github.com/tylerspurrell-lang/Forest_Game/blob/main/Screenshot%202026-10-25%20160403.png




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

I began experimenting with LUT-based colour grading to change the overall colour appearance of the forest.

A lookup table (LUT) maps input colours to adjusted output colours. This can be used to create a warmer, cooler, or otherwise modified colour palette.

However, I was unable to complete the LUT implementation in the scene. Colour grading remains an area for further development.

Status: Incomplete.


## AI Use Acknowledgement

No AI use 
