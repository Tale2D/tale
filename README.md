# Tale
The Tale engine enables the creation of interactive **cross platform** 2D graphics applications.

It offers simple 2D polygon (coloured, textured and dual textured) drawing functions, in addition to flexible render path creation making use of shader effects (both inbuilt and user defined).

Quickly create 2D games and prototypes that run on all major desktop operating systems and mobile  . Graphics, Input, Windowing and Application Lifecycle are all provided for and managed by the engine (just add sound). Avoid the bloat of large game engines. No GUI, **do it all in code.**

Tale is structured as a collection of .NET standard 2.0 class libraries, built upon the Veldrid cross-platform API agnostic rendering library. Application windowing is handled by SDL2 via Veldrid.

**Supported Desktop Platforms: Windows, Linux and MacOS**

**Supported Mobile Platforms: Android and IOS**

**Supported Graphics APIs: Direct3D 11, Vulkan, OpenGL,OpenGL ES, Metal**

## Key Features
* Customisable Rendering Pipeline
    * Create and use Textures and Render Targets (surfaces) as inputs and outputs wherever desired in rendering pipeline
    * Arrange render stages in any order to create desired effects
    * Supports common image file formats for Texture loading
* 2D Drawing
    * Draw custom polygons from vertices or regular shapes (quads, n-sided shapes) by creating request queues
    * Helpers provided for generating vertices of common shapes, including a fluent interface for reusing and iterating drawing objects
    * Fill with solid colour, single or dual texturing
    * Draw / transform into world space or screen space (based on interchangable cameras), split into layers and set depths
    * Reuse queues or re-create each frame
    * Queues auto-sorted and batched
* Bitmap Font Rendering support
    * Will parse user .fnt files
* Use of Cameras (2D and 3D) and Viewports allow easy rendering of the same draw queue or surface from different perspectives, on differet parts of a render surface
    * Simplifies split screen views
* Shader Effects
    * Blur, Bloom, Colourize, Grayscale, Negative, Add Opacity, Mix Textures, Basic Copy between surfaces
    * Pixellate, Static, Edge Detection, Old-Movie Reel, CRT monitor
    * Height Map Distortion (such as shock waves)
    * Render surfaces to 3D meshes (Phong lighting model with up to 8 lights)
    * Easily Create Custom Shader stages, or stages with full exposure to Veldrid objects
* Input
    * Exposes keyboard, mouse and gamepad input via an abstraction over Veldrid / SDL2