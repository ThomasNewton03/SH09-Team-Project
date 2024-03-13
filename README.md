# SH09 Team Project - Project GUNDAM

## Unity Version: 2022.3.12f1
It is important to use the same version.

## Description
Project GUNDAM is an augmented reality game developed for the University of Glasgow Games Lab and is available as an Android app.

The application works by placing models across the local area, and the user must go to these set location in the real world, once there, a quiz is given and if the correct answer is given, you earn the model at that specific location. Augmented reality can be used to display he model in the real world.

What the application does:

The technologies used and why:

Challenges faced and features to implement in the future:

## Table of Contents
1. [How to Install and Run the Project](#How-to-Install-and-Run-the-Project)
2. [How to Contribute to the Project](#How-to-Contribute-to-the-Project)
<!-- 3. Badges -->
<!-- 3. Visuals -->
3. [Usage](#Usage)
4. [Roadmap](#Roadmap)
5. [How to Run Tests](#how-to-run-tests)
6. [How to add new models](#how-to-add-new-models)
7. [How to modify project settings](#how-to-modify-project-settings)
8. [Informations about Prefabs and Scenes](#information-about-prefabs-and-scenes)
9. [Project status](#project-status)
10. [Authors and Acknowledgment](#authors-and-acknowledgment)
11. [Referenced Materials](#referenced-materials)
12. [License](#license)

## How to Install and Run the Project
### How to install Unity project:

1. Download Unity Hub from the [Unity website](https://unity.com/download).
2. Once the download has completed, run the setup wizard and follow the instructions. Install in your folder of choice with at least 30 GB of free space. This is for the next step.
3. Next you will want to install our Unity version, which is located [here](https://unity.com/releases/editor/archive). Find the 2022.3.12 version and click the Unity Hub button. This will prompt Unity Hub to be opened, allow this.
4. When Unity Hub opens the install menu for the version, make sure that the following are enabled: Android Build Support with OpenJDK and Android SDK & NDK Tools. The rest are optional and can be installed if you plan on developing in future for these platforms or are required by other projects.
5. Once fully installed, you can now clone the project into a folder of your choice, see the section How to Clone below for this.
6. Once your project has been cloned, go back to the Unity Hub and in the Projects menu, on the top right click "Add", then find your cloned repository and slelect the folder inside the repository named "sh09-main". The directory path should be "~/sh09-main/sh09-main". Once done click open on the folder page and this will let Unity Hub recognise the project.
7. Check that Unity Hub has recognised the project, and if so, attempt to open it. This will take a few minutes to load and should take you into the main project app once done.

### How to install the app on to your Android Device:

1. Open the Unity project (see above for how to do this).
2. Click file on the top left of Unity, and then from the dropdown menu, click build settings.
3. Ensure that scene1, Location-basedGame and Intro are all ticked in the "Scenes in Build" section. 
4. Ensure that Android is the selected platform in the Platform section.
5. None of the checkboxes in the right side of the Build settings window should be checked, and the following options should be set to the following: Texture Compression - Use Player Settings, ETC2 fallback - 32-bit, Create symbols.zip - Disabled, Run Device - Default device, Compression Method - LZ4.
6. Finally click build, and store the apk wherever you wish to store it.
7. Finally take the apk and install it on your android device (Note: each android device is different but you may need developer mode enabled).

### How to run the project:

For running in Unity, simply click the play button at the top of the application to run the game in Unity, this will run the game from the scene selected, so if you want to check the map scene, you will need to have that scene opened.

For running on your android device, if you have a previous version of the app installed already, please delete this before installing the new apk file otherwise a black screen glitch may occur which will not allow the applciation to run. Once done, download the apk onto your device, and click on it. This will start the installation process. You may be asked if you give the app permission to install, in this case simply click yes.

<!-- If you update the application, or decide to install the app again, please ensure that the previous version is uninstalled from the android device, otherwise the "black screen of death" may appear. It may tell you that the source you are downloading from is not recognized, in this case you have to allow your phone to install apps from this source. -->

## How to Contribute to the Project
### On First Go, How to Clone
Open up a terminal environment and navigate to where you would want to save the project. Navigate to the github remote repository and click on the Code button dropdown. Click on the HTTPS section and copy the link available it should be something like: https://github.com/username/sh09-main.git . From here you want to clone the project. Go into your terminal where you have naviagted to where you would like to save the project.
```bash
git clone https://github.com/username/sh09-main.git 
```
### Collaborate with your team

- [ ] [Invite team members and collaborators](https://docs.gitlab.com/ee/user/project/members/)
- [ ] [Create a new merge request](https://docs.gitlab.com/ee/user/project/merge_requests/creating_merge_requests.html)
- [ ] [Automatically close issues from merge requests](https://docs.gitlab.com/ee/user/project/issues/managing_issues.html#closing-issues-automatically)
- [ ] [Enable merge request approvals](https://docs.gitlab.com/ee/user/project/merge_requests/approvals/)
- [ ] [Set auto-merge](https://docs.gitlab.com/ee/user/project/merge_requests/merge_when_pipeline_succeeds.html)

### Add your files

- [ ] [Create](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#create-a-file) or [upload](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#upload-a-file) files
- [ ] [Add files using the command line](https://docs.gitlab.com/ee/gitlab-basics/add-file.html#add-a-file-using-the-command-line) or push an existing Git repository with the following command:
```
cd existing_repo
git remote add origin https://stgit.dcs.gla.ac.uk/team-project-h/2023/sh09/sh09-main.git
git branch -M main
git push -uf origin main
```
### After Cloning
Navigate to where you cloned the project to within your file directory, whilst in a terminal environment. Always make sure you are in the correct directory and folder. There is a sh09-main root repository and another sh09_main folder within that. Make sure you are in the one you want to be in.
Pull to make sure you have the most up to date version before editing:
```bash
git pull
```
You can then do the changes you want to make. You then want to commit your changes so that they are saved.
```bash
git add * #this adds all the changes you have made
git commit -m "put your commit message here"
```
When you want your local changes to be put on the remote github repository, you should push your changes.
```bash
git push
```
<!-- ## Badges
On some READMEs, you may see small images that convey metadata, such as whether or not all the tests are passing for the project. You can use Shields to add some to your README. Many services also have instructions for adding a badge. https://shields.io/badges -->

<!-- ## Visuals
Depending on what you are making, it can be a good idea to include screenshots or even a video (you'll frequently see GIFs rather than actual videos). Tools like ttygif can help, but check out Asciinema for a more sophisticated method. -->



## Unity and Git Steps We Use
When switching between branches in the project, make sure to use git switch instead of git checkout, as this is a newer command and focuses solely on switching branches:
```bash
git switch main
```

If at any point you are unsure as to which branch you are currently in, use git branch -a. This will display all the branches in the project and highlight the branch you are in currently in green:
```bash
git branch -a
```

If you want to delete a local branch, use git branch -d <branchname>. Git will only allow you to delete this branch with this command if it has been fully merged into the current branch. Otherwise, if you want to force delete a branch, use git branch -D <branchname>- make sure to be careful, as this will delete it even if it includes changes that haven't been merged. E.g.:
```bash
git branch -d Development
```

```bash
git branch -D Development
```

If you want to reset the branch to a previous commit, removing any local changes made to the project, you can use git reset --hard:
```bash
git reset --hard
```

You can use git clean -df to delete untracked files in the working directory- these are files that are in the repository's directory but haven't yet been added to its index with git add *. Make sure to be careful with this command:
```bash
git clean -df
```

In Unity, you can use Debug.Log(message:object) to print a message in the console to validate the application's behaviour when the code is executed. 
E.g.:
Debug.Log(msg);

## Usage
The application works similar to other AR games such as Pokémon Go, see screenshots below for the games usage.
screenshots here:

## Roadmap

The project code freeze takes place on the 15th of March, from this point onwards the code is no longer required to be maintained or actively developed by the original team, however measure will be in place to ensure a stable app is released.

This project can and will be developed upon by the UofG Games Lab after the original team members code freeze. This can be done on this GitHub.

This project will be demonstrated at the Science Fiction conference in Glasgow in August.

## How to Run Tests
<!-- Use the built-in continuous integration in GitLab.
- [ ] [Get started with GitLab CI/CD](https://docs.gitlab.com/ee/ci/quick_start/index.html)
- [ ] [Analyze your code for known vulnerabilities with Static Application Security Testing(SAST)](https://docs.gitlab.com/ee/user/application_security/sast/)
- [ ] [Deploy to Kubernetes, Amazon EC2, or Amazon ECS using Auto Deploy](https://docs.gitlab.com/ee/topics/autodevops/requirements.html)
- [ ] [Use pull-based deployments for improved Kubernetes management](https://docs.gitlab.com/ee/user/clusters/agent/)
- [ ] [Set up protected environments](https://docs.gitlab.com/ee/ci/environments/protected_environments.html) -->

This project has a set of manual tasks that can be undertaken to ensure full current functionality:
| Tasks | Expected output from task| Passed?| Extra Comments |
| ------ | ----------------------- | ------ | -------------- |
| Load app up for the first time | It should load up on the main menu page with information and notices |  |  |
| After loading app up for the first time, click on the arrow on the main menu page | You should be redirected to the profile page where the user can change their name |  |  |
| After loading app up for the first time, click on the arrow on the main menu page, you should be redirected to the profile page | There will be a tutorial prompt explaining the profile and how to change your name |  |  |
| After loading app up for the first time, click on the arrow on the main menu page, you should be redirected to the profile page, click done on the tutorial prompt explaining the profile and how to change your name | The pop up should disappear |  |  |
| On the first go of the app, after being navigated to the profile page from the main menu page navigate to the settings page | There should be a tutorial explaining the settings page |  |  |
| On the first go of the app, after being navigated to the profile page from the main menu page navigate to the settings page, click done on the tutorial explaining the settings page | The tutorial prompt should close |  |  |
| On the first go of the app, after being navigated to the profile page from the main menu page navigate to the Inventory page | There should be a tutorial explaining the Inventory page |  |  |
| On the first go of the app, after being navigated to the profile page from the main menu page navigate to the Inventory page, click done on the tutorial explaining the Inventory page | The tutorial prompt should close |  |  |
| Click on Open button | Inventory, Profile and Settings pop out.|  |  |
| Click on Close button | Buttons close down, only Open button showed.|  |  |
| Click on Inventory button after clicking Open button | Inventory page loads up, with different models shown |  |  |
| Click on Profile button after clicking Open button | Profile page loads up, with profile icon, name, way to change name and how many GUNDAM collected. |  |  |
| Change name in Profile page, write new name in enter text box and click enter | Name displayed above box should change to name inputted. |  |  |
| Click on Settings button after clicking Open button | Settings page should load up with button size slider, font size slider, left handed tick box and an option to reset the tutorial |  |  |
| On Settings page slide Button Size slider | As slider goes more towards the right button size should get larger, as slider goes more towards the left button size should get smaller. |  |  |
| On Settings page slide Font Size slider | As slider goes more towards the right font size should get larger, as slider goes more towards the left font size should get smaller |  |  |
| On Settings page click on Left-Handed tick box | When Left-Handed tick box ticked buttons, including the button at the bottom and the Map button at the top, should change to the left, when unticked buttons should be on the right |  |  |
| On Setting page click on reset tutorial button | The tutorial should be reset and a popup will appear explaining the setting page |  |  |
| On Settings page click on reset tutorial button, then navigate to profile page | There should be a popup tutorial explaining what's on the profile page |  |  |
| On Settings page click on reset tutorial button, then navigate to Inventory page | There should be a popup tutorial explaining what's on the Inventory page |  |  |
| Click on Map button | Map should display user location as well as icons showing where the GUNDAM's are |  |  |
| Click on Map button then travel to within proximity of a GUNDAM | Collect button should show where GUNDAM is |  |  |
| Click on Map button then exit out | It should take you back to the page you were on before |  |  |
| Given you're within proximity of a GUNDAM icon, click on the collect button by the GUNDAM icon | You should be taken to the camera where the GUNDAM is displayed in AR |  |  |
| On Inventory page click on non greyed out GUNDAM | It should take you to the information page for the specific GUNDAM |  |  |
| On Inventory page click on other non greyed out GUNDAM that you haven't already clicked on | It should take you to the information page for the specific GUNDAM, this information should be different to the other GUNDAM information |  |  |
| After navigating to an information page from a collected Gundam from the Inventory page, click on the right arrow | It should take you to the next page for the information |  |  |
| After navigating to an information page from a collected Gundam from the Inventory page, click on the right arrow, then click the left arrow | It should take you back to the first page for the information |  |  |
| After navigating to an information page from a collected Gundam from the Inventory page, click on the right arrow until you can't click anymore | It should take you to the quiz page |  |  |
| After navigating to an information page from a collected Gundam from the Inventory page, click on the skip to quiz button | It should take you to the quiz page |  |  |
| After navigating to a quiz page click on one of the options | Either a you are correct with a green tick mark or a you are incorrect with a red cross will be displayed at the bottom of the page |  |  |
| After navigating to a quiz page click on all of the options one after another and note what they display | Only one should display you are correct with a green tick mark and the rest a you are incorrect with a red cross at the bottom of the page |  |  |
| After navigating to a quiz page navigate to another quiz page | The content on it should be different |  |  |
| Given you're on the Map page and within proximity of the GUNDAM icon, click on the collect button by the GUNDAM icon, camera will pop up, move camera around to assess AR of GUNDAM model | Model should be directly on the floor, and preferably not having any occlusion problems with the environment (within reason) |  |  |
| Navigate to the Map | The map should open at the correct location based on the user's current GPS location |  |  |
| Navigate to the Map page, travel around | As the user moves around the real world, the in-game map should also move to that new GPS location of the user |  |  |
| Navigate to the Map page | The user should be able to see clear points on the map for each GUNDAM |  |  |
| After having clicked on a GUNDAM icon when being in proximity and the camera has been brought up, click on click to collect button | You should be brought to the inventory page |  |  |
| Navigate to the Map page | There should be a zoom slider at the bottom |  |  |
| Navigate to the Map page, slide the zoom slider at the bottom towards the plus sign | The map should zoom in |  |  |
| Navigate to the Map page, slide the zoom slider at the bottom towards the minus sign | The map should zoom out |  |  |


## How to add map functionalities

This project employs the Mapbox API for mapping and geolocation features. You are required to create a Mapbox account and acquire an API key in order to use this application. The account type you are recommended to use is Static Images API; it will provide you with 50,000 monthly requests free of cost. From then onwards it will cost USD $1 per 1000 requests.
You can obtain the API key by creating an access token in your account. To enter this key into the application, go into Unity and head to Mapbox in the options bar at the top of your screen. Click on "setup", paste the key from your Mapbox account into the bar, and press submit. Once you have set up this key, you will be able to access the location-based map within the application.



## How to add new models

First, drag your model folder into the unity project area, located at the bottom of the Unity application. This is where all of your assets for the game are stored. 
Now, this model will not have any textures, so in order to have them go to the section about [texturing the models](#adding-textures-to-each-model).
Next you are going to create a prefab variant of the fbx/obj 3d model. So, simply right click the file, then in the menu, go to create, and then find the option named "prefab variant", and click on that.
Moving on add the new model you need to move to the scene1 Scene. This is found in the Scenes folder in Assets. Once you are on this page you need to add the 3d Model into the ModelContainer (You must apply the textures).
Then you would open the canvas, Inventory Menu, Scroll, Viewport, Content and copy and paste one of the items and name it item(next number) Then select it and on the inspector (Right of the screen) scroll down to the bottom until you see Gundam Robot (Script). There are field you can fill in on this script fill them in as follows:  
- Id: (item number - 1)  
- Gundam Name: Exact name of the model  
- Location: Ignore  
- Quiz Question: Question that the quiz will ask  
- Quiz Answers(Drop down menu): possible multiple choice answers  
- Discovered: Ignore  
- Information: The information that you want to show up on the information page  
- Quiz correct index: The index of the correct answer  
- Gundam Sprite: Sprite image of the GUNDAM. You must drag the sprite image into the field for it to update [(See Making a Sprite)](#making-a-sprite)
- Quiz Complete Color: Ignore  
- Star: Ignore  

Next you will need to add the coordinates on the map. First you must open the Location-based-game scene which can be found Mapbox > Examples > PrefabScenes > Location-based-game.  
Once you have opened the scene go to the event spawner object scroll down to add component add the script spawn on map (NOTE: A new script must be added for each new GUNDAM), this will contain multiple field to fill in, do it as follows:  
- Map: click on the circle to the right of it and select the script named Map  
- Location strings: open the drop down and enter the Latitude and longitude coordinates you want the model to be at.  
- Spawn Scale: 5  
- Marker Prefab: Drag the model you want to show up on the map into the field  
- Button Prefab: Click on the small circle next to the field and select the button with a Blue box next it (The blue box indicates a prefab in Unity).  

### Adding Textures to each model
1. Click on the original fbx/obj file. Once you click on this you should see the inspector open on the right side of the screen with 4 buttons representing menus for: Model, Rig, Animation and Materials. Click on the materials part.
2. Next click Extract Materials as this will autogenerate the correct materials needed for each model.
3. If at any point it asks for which folder to do this to, make sure its in the textures folder within the whole models folder. An example path would be "modelName/textures".
4. If the model has any autogenerated coloured materials you can ignore these as these are already set up on the model, for all materials that have a grey circle and have textures following the same name structure, we will need to update these [More details are in the section below or click me!](#creating-the-materials-for-each-component)
5. Once you have all the materials applied and completed and in the right spots, you can continue adding the model into Unity.

#### Creating the materials for each component
1. Click on the material in the texture folder, and it should open up on the inspector to the right. At the top there should be a dropdown box for a "shader". From the options in the dropdown, select "Autodesk Interactive".
2. For the material, find all textures that share the exact same name as the material. If there are no similar names pick the one that sounds the most appropriate to the material name.
3. Each tecture will look slightly different and are used for a different purpose. Here's a list of the different types of texture files you need:
- Albedo - This is the main colouring for the material. This will be called either albedo, main colour, or will not have any naming extension (all of these can be abreviated to single character)
- Metallic - This makes the model reflective at the white sections, and non reflective at the dark sections. This will be called metallic or M.
- Roughness - This is used to describe how light scatters over the model. This will be called roughness or R
- Normal - This is used to create scratches or bumps on the models texture. This will be called normal or M. When you add this to the material, it will ask you to fix this texture to be a normal. Simply click the Fix button that appears on the material inspector.
- Emissions - This creates a glowing effect from the part on the model. This will be called emission or E.
- Do note that all models will have all, only some or even more. Focus on these ones will make the model have the correct look in terms of textures. If there are less just add the ones you have, and if there are more, you can check where they are appropriate to use in the model documentation or a google search. If you can't find out where they are used, just leave them aside or ask online for more info.
4. Apply each texture to the correct section of the material, use the points above for reference. To do this make sure the material is open in the inspector and drag and drop the texture file into the right spot.
5. Once completed, check the model and see if the textures are on the model and look like they are in the correct space. If not double check your textures are in the right materials, and ensure that the materials are linked to the model. If for whatever reason the materials are not linked to the model. Click the fbx/obj file, go back into the materials section and from the texture folder, drag the material to the correct material slot in the "On Demand Remap" section.


## Making a Sprite

First add an image into the Image folder of the assets next click on the image (This should open the inspector on the right side of the screen). At the top of the inspector there should be a field called Texture Type on this select Sprite (2D and UI). NOTE: You must click off of the image and agree to the change before it will change to the sprite.

## How to modify project settings

For changes such as the name of the app or icon, these can be changed by going into Edit then Project Settings then Player, once in Player you can see the product name, company name and version which can all be changed. The icon can be changed by going to Icon from Player, then expanding Adaptive (API 26) icons then change the icon by selecting and replacing the images labeled Background and Foreground in xxxhdpi (432x432px). To edit the Splash Logo which shows the icon after launching the app, you have to go from Player to Splash Image, then Logos, our logo is below the "made with unity logo", you can change the image or add other images as icons as well.

## Information about Prefabs and Scenes

Unity projects depend on [Scenes](https://docs.unity3d.com/Manual/CreatingScenes.html), each scene is a different environment where all the objects related to that scene are going to be. There can only be 1 one person (1 device) working on a scene at a time. For our project we have 3 scenes, the intro scene which holds the intro page, the main scene which holds the different pages and their UI, and lastly the map scene which handles the map.

We also make use of [Prefabs](https://docs.unity3d.com/Manual/Prefabs.html) in our project. Prefabs are ready made objects that can be reused in the project, such as the GUNDAM models and the GUNDAM inventory objects.


## Project status

This project from April 2024 and beyond is no longer required to be maintained by the original developers on this project, but further development from the UofG Games Lab will occur. Contributions will take place in the public repository and those wishing to work on further development should contact Timothy Peacock.

## Authors and Acknowledgment
This was developed as a team project for third year students in the University of Glasgow. Developers include:

- Josh Duffy
- Connor Fallon
- Isabella Gard
- Maryam Al-Khulaifi
- Thomas Newton
- Aiden Smith

## Referenced materials

[Unity Scene Manual](https://docs.unity3d.com/Manual/CreatingScenes.html)

[Unity Prefab Manual](https://docs.unity3d.com/Manual/Prefabs.html)

## License
This project uses an open-source software license, meaning that users can access, modify, and share the application content for free. With this license, it will allow third-party developers to make improvements and other changes to features, such as the models existing in the map and their spawnpoints, before the application is released. 

