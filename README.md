# Unity-web-ui
This is a Unity sample project to get started with the UI. 
Here, we have basic Assets and all C# code we need to run the project locally. 

## Changes:
- Added code in `TestListing.cs` to fetch games records from external API running in Docker container on same machine. `localhost:5000`
- Added code in `UIEntity.cs` to call Texture of given image URL.  `GetTexture`  downloads the image and sets to image object. 

This helps to show background images in tiles. 


## How to Run:
- Download Unity Hub in your local
- Download this project 
- Open this project from Unity Hub
- From the screen, hit play. 


## Expected result 
All game tiles with Background image, title, subtitle will appear in screen. 
