# Forest_Game — Computer Graphics Project Progression

## 1. Project Overview

**Project Name:** Forest_Game  
**Engine:** Unity  
**Project Type:** 3D interactive game  
**Course:** Introduction to Computer Graphics  
**Developer:** Individual project

Forest_Game is a 3D forest-based game developed in Unity to demonstrate fundamental computer graphics techniques in an interactive environment. The project uses a forest scene containing environmental objects, lighting, and custom shaders to explore how rendering techniques affect the appearance and atmosphere of a game.

The goal is to create a playable scene that demonstrates different illumination methods and shader effects while providing an environment in which these techniques can be compared.

## 2. Project Proposal

The original goal of this project was to create a playable 3D environment that demonstrates fundamental computer graphics concepts in a practical game setting. Rather than implementing the techniques in isolated examples, the project applies them to a forest scene so their visual effects can be observed in context.

The project focuses on illumination, custom shader implementations, and colour grading. The intended result is an interactive scene where different rendering techniques can be compared and their impact on the environment understood.

## 3. Scene and Gameplay

The project is developed in Unity and uses a 3D forest environment as its foundation.

The scene contains environmental elements such as trees, rocks, crates, lighting objects, a radio, and a radio tower. These objects help establish the environment and provide visual context for the graphics techniques being implemented.

The prototype is intended to include:

- A playable main character.
- Environmental objects appropriate to the forest setting.
- Dynamic objects that move during gameplay.
- A win or lose condition.
- A consistent visual style that supports the scene.

**Current development status:** The forest environment and illumination work have been developed. Remaining gameplay features and final testing must be verified before the project is considered complete.

## 4. Illumination

Illumination is a major component of the project. Different lighting implementations are used to demonstrate how lighting calculations affect the appearance of objects in the scene.

The project uses shader implementations to compare different lighting conditions.

### 4.1 No Lighting

This mode provides a reference for observing the scene without the selected lighting calculations. It helps demonstrate how the appearance of an object changes when lighting effects are applied or removed.

### 4.2 Ambient Lighting

Ambient lighting provides general illumination that is not calculated solely from a single directional light source. It helps make surfaces visible even when they are not directly facing the light.

In the forest scene, ambient illumination helps maintain visibility in areas that might otherwise appear too dark.

### 4.3 Diffuse Lighting

Diffuse lighting models how light interacts with a surface based on the angle between the surface normal and the light direction. Surfaces facing the light receive stronger illumination, while surfaces facing away receive less.

This technique helps give environmental objects a sense of shape and depth.

### 4.4 Specular Lighting

Specular lighting adds highlights to surfaces based on the relationship between the light direction, surface normal, and viewing direction. These highlights help represent the reflective appearance of materials.

### 4.5 Interactive Comparison

The illumination implementations can be compared using keyboard controls. The intended configuration is:

| Key | Lighting mode |
|---|---|
| 1 | No lighting |
| 2 | Ambient lighting only |
| 3 | Specular lighting only |
| 4 | Ambient and specular lighting |
| 5 | Ambient, specular, and the selected custom effect |

These controls allow the user to compare rendering results without needing to replace materials manually.

**Evidence to add:** Screenshots of the scene in each lighting mode, along with the relevant shader graphs and control script.

## 5. Custom Shader Implementations

The project includes custom shader work created using Unity's Shader Graph workflow. Shader Graph allows rendering calculations to be built by connecting nodes rather than writing every shader operation manually.

The shader assets are organized in the project's `Assets/Shaders` directory.

### Shader Implementation 1 — [Insert shader name]

**Purpose:** [Describe the visual effect this shader creates.]

**Implementation:** [Explain the shader nodes or calculations used, the material to which it is applied, and how it differs from a standard material or the class example.]

**Benefit to the scene:** [Explain how the effect improves the appearance, readability, or visual style of the forest environment.]

### Shader Implementation 2 — [Insert shader name]

**Purpose:** [Describe the second shader's visual effect.]

**Implementation:** [Explain the nodes, calculations, material settings, or other modifications used.]

**Benefit to the scene:** [Explain why the effect is suitable for this project.]

The final documentation will include screenshots of both shader graphs and examples of their effects in the game.

## 6. Colour Grading and Colour Correction

Colour grading is intended to change the overall tone and atmosphere of the scene using lookup tables (LUTs).

A LUT remaps input colours to different output colours. This allows colour correction to be applied consistently across the rendered image.

The assignment requires different grading styles, including warm, cool, and custom colour treatments. As an individual project, one functioning colour-correction implementation is required.

A representative screenshot of the forest scene is used as the basis for creating colour adjustments in an image-editing application. Photopea was used to experiment with colour adjustments, including a warm photo filter, and a warm LUT texture was imported into Unity.

The colour-grading shader work is still in progress. The final version must correctly sample the LUT, apply it to the rendered image, and provide a working way to toggle the effect.

**Evidence to add:** The original screenshot, exported LUT image, final shader graph, and before-and-after screenshots demonstrating the working effect.

## 7. How to Run the Project

### Open the Unity project

1. Download or clone this repository.
2. Open Unity Hub.
3. Select **Add** or **Add project from disk**.
4. Select the downloaded project folder.
5. Open the project using a compatible Unity version.
6. Open the main game scene and press Play.

Unity may need to regenerate its `Library` folder when the project is opened for the first time.

### Playable Windows Build

**Status:** To be added.

The Windows standalone build will be published through the GitHub Releases section. Once uploaded, this section will contain a link to download the playable build.

The build will be tested outside the Unity Editor to verify that the scene launches correctly and that the implemented shaders function as expected.

**Release link:** [Add the published GitHub Release URL here.]

## 8. Project Progression Reflection

The project has progressed from establishing a forest environment to implementing and comparing computer graphics techniques. The scene provides a consistent setting for examining how illumination and shader calculations affect the appearance of environmental objects.

One of the main challenges has been implementing custom shader effects and understanding how shader nodes, texture settings, and lighting calculations work together. Shader Graph made it possible to construct rendering effects visually, but debugging connections and achieving a clearly visible result required experimentation.

The illumination implementations have been developed, and work has also been completed on custom shaders. Colour grading has been more challenging because the LUT must be sampled and applied correctly to the rendered screen image. The project has therefore been developed incrementally, prioritizing the scene and illumination before completing the remaining effects.

The next steps are to finish and test the remaining gameplay features, complete colour grading, document the shader implementations, capture visual evidence, and prepare the Windows build and presentation.

## 9. External Resources and AI Use

External resources, tutorials, and AI assistance must be acknowledged according to the course requirements.

### AI Assistance Disclosure

ChatGPT was used as an assistance tool during development to help understand Unity workflows, troubleshoot Shader Graph setup, organize project tasks, and prepare project documentation. Assistance included explanations of shader concepts, guidance on Unity project organization, and help structuring this README.

The project was developed and tested by the student, who is responsible for verifying all implementations and ensuring that the submitted work accurately reflects their own contributions.

**AI interaction evidence:** Screenshots of relevant AI conversations must be included with the submission, as required by the assignment.

**Additional external resources:** [List any tutorials, documentation, code, textures, assets, or other external resources actually used, and explain how they were used.]

## 10. Screenshots and Supporting Evidence

The following evidence will be included to demonstrate the implementation and results of the project:

- **Figure 1:** Overview of the forest scene.
- **Figure 2:** Playable scene showing the environment and game objects.
- **Figure 3:** Diffuse lighting implementation.
- **Figure 4:** Ambient lighting implementation.
- **Figure 5:** Specular lighting implementation.
- **Figure 6:** Shader Graph for the first custom shader.
- **Figure 7:** Shader Graph for the second custom shader.
- **Figure 8:** Colour-grading implementation and comparison images.
- **Figure 9:** Dynamic objects and the win/lose condition.
- **Figure 10:** Windows build running outside the Unity Editor.

Each figure will be accompanied by a short explanation of what it demonstrates and how it relates to the project requirements.

## 11. Final Deliverables

The completed repository will contain:

- The Unity project, including `Assets`, `Packages`, and `ProjectSettings`.
- This README with the project proposal, implementation explanations, and reflection.
- Screenshots, diagrams, and code snippets supporting the graphics implementations.
- A Windows playable build uploaded as a GitHub Release.
- A link to the unlisted YouTube presentation, between five and ten minutes long.
- Required evidence of AI use and acknowledgements of external resources.

The final submission will be checked to ensure the project opens correctly, the required rendering techniques function, the playable build works, and all required documentation and presentation materials are accessible.
