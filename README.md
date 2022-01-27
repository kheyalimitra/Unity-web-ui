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
- In order to fetch records, we need https://github.com/kheyalimitra/game-listing-framework to run. 
  - Go to https://github.com/kheyalimitra/game-listing-framework, clone the repo
  - From terminal cd to the folder
  - run `docker build -t react-app ./client` and `docker build -t api-server ./server`
  - aftger that, run  `docker-compose up --remove-orphan`
- Now all necesary services are running on port 5000 of your local machine. 
- Come back to unity hub, From the screen, hit play. 


## Expected result 
All game tiles with Background image, title, subtitle will appear in screen. 
