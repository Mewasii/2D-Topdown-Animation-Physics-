# Welcome to my little game testing place
This project is my little playground where I experiment with animation and physics to better understand
how game mechanics come to life. It’s also the place where I share my 2D pixel art, combining my love for both art and design.
Working on this not only helps me learn, but also gives me the joy of creating something I’ve always dreamed about.

# The Testing Ground
##  The Orange Cat
This free orange cat was taken from free assets I found somewhere on the internet (I kind of stole it, not gonna lie). Then I started testing with him to understand how the animations work. I created a basic movement interaction for him, and it looks like this:

<img width="770" height="362" alt="image" src="https://github.com/user-attachments/assets/33f259e6-bcc8-4138-9183-40ca8802e8ed" />

Basicly he can walk, jumpin, and guest what, walk faster ( i call it running)

![gif](https://github.com/user-attachments/assets/801c07b6-52b7-4004-8099-4d2c73c249c7)

### #1 Idle

Firt we'll talk about how orange dude can up down up down him self
Infact he have 10 frame of different state of how he stand

<img width="1919" height="677" alt="image" src="https://github.com/user-attachments/assets/9201d16a-e28c-48e8-9c40-76453eec0273" />

combine each with others, set a perfect sample rate for animator and the dude can idle himself

![giphy (8)](https://github.com/user-attachments/assets/00ff7673-571a-43d0-a4b9-a4687315ba8c)

### #2 Walking

With walking, we will have the same animator process as the idle

<img width="1919" height="783" alt="image" src="https://github.com/user-attachments/assets/83b5c588-b69f-48be-bc5f-0f32a582ecb8" />

But here's the tricky part: He will have to walk when i press these buttons < ^ > and if he doesn't walk he'll idle again 
So this how the code kicked in: 

First, we need to set the condition for Orange to walk. Walking means his speed is greater than 0. If the speed drops back to 0, he idles again (pretty obvious).

<img width="1714" height="557" alt="image" src="https://github.com/user-attachments/assets/2fea2c19-69f0-48eb-86d3-266566ad62e1" />
<img width="1716" height="618" alt="image" src="https://github.com/user-attachments/assets/630c6d5d-4b53-4a71-8008-a473bdd5c243" />

To make the moving things get going on the playground, a little math about possistion will be made and put inside orange's logic

<img width="936" height="465" alt="image" src="https://github.com/user-attachments/assets/9a05d600-94cc-44f5-8b66-d422bdef713d" />

All of these "walking" are the magic of  art, code, math and architecture


![giphy (10)](https://github.com/user-attachments/assets/ccf957af-05fd-4f3e-b2ea-cbbd847f89c7)

### #3 Jump in (or dash in) and running

remember about the previous trickypart ?
This's still the sameone mate :3 

But here's the things, instead of >< button, now i have "space" for jumpin and "ctrl" for running 
The condition of jumping is pretty simple hit "space" and Orange jump

![giphy (9)](https://github.com/user-attachments/assets/9cf0302b-0b18-42fd-9e74-4a77b607b1a4)

but with the running , Orange need to accelarate so he will walk first, then if i hit "ctrl": the cat's runnin

<img width="697" height="352" alt="image" src="https://github.com/user-attachments/assets/84be07c1-1238-4899-ad80-b2b6d981fed6" />

![giphy (11)](https://github.com/user-attachments/assets/1bda7eb1-51c2-43e4-8298-34e3c2dc3a3a)

## The Cannonball

Instead of stealing something on the internet, I prefer using something I already have. It took me 2 seconds to find something "gunnly" in my assets, and BEEM! The big bad giant tomb ready to gun

As you can see i attach it right into Orange 

<img width="1153" height="720" alt="image" src="https://github.com/user-attachments/assets/3915dd94-919a-4890-9a0d-7f2baf02857d" />

To control the cannon, again, we need to do math and code.
First, cannon head will always point directly at the player's mouse cursor.

It performs two main actions every frame:

Aims: It calculates the angle between the object's position and the mouse's position in the game world, then rotates the object to face that angle.

Flips: It checks if the object is aiming over its left shoulder (rotation between 90∘ and 270∘)
 If it is, it flips the object's sprite vertically (by setting its Y scale to a negative value, ≈−0.09) so the sprite doesn't appear upside-down.

<img width="1035" height="396" alt="image" src="https://github.com/user-attachments/assets/f6cc2432-bad3-4596-bf86-d9e2d0e7a6a0" />


![giphy (17)](https://github.com/user-attachments/assets/b1941d4e-0bbf-4c03-8543-15e90c0a1e63)


And what's the most importance thing for the Cannonball ? 

Bullet ??? NUH UHHH its Solid ROCKKKKKK

<img width="706" height="266" alt="image" src="https://github.com/user-attachments/assets/fde8c156-d01f-4645-b538-d858e0aecc53" />

About the rocking thing, lets add 2 fuction:

<img width="701" height="219" alt="image" src="https://github.com/user-attachments/assets/317570bc-c73d-40d6-8332-c3afded46469" />

<img width="1044" height="218" alt="image" src="https://github.com/user-attachments/assets/23c86e59-705e-43ff-b1cc-d871804555df" />


Fire() (Shooting): Instantiates a bullet at the muzzle position, resets the firing cooldown, and applies a strong force to propel the bullet in the direction the object is currently pointing.

Update() (Logic): Constantly calls Gunning() and checks if the player is holding the left mouse button AND the cooldown time is finished. If both are true, it calls Fire().

Force and cooldown are supper important cause if you dont forcing it right you will have a slingshot, if you not let it cool down, you got a lazergun go brrrrrrrrrrrrrrrr instead of br br br br


![giphy (18)](https://github.com/user-attachments/assets/b3bc9db7-5eb5-48d3-960d-e543c1016d54)

## Enermy
Lets take a quick look 

<img width="1707" height="678" alt="image" src="https://github.com/user-attachments/assets/f1ea03b0-33e3-4a03-94af-bf8b58fc94cf" />

There's alot things to make this dude work right, so lets break it down 1 by 1

### #1 Moving 
Basicly, this dark dude will need the same animation control as Orange

<img width="1144" height="497" alt="image" src="https://github.com/user-attachments/assets/749fc3bc-9af2-4f03-87f4-83233ddac23f" />

Cause he's evil      so he have his own will

<img width="554" height="500" alt="image" src="https://github.com/user-attachments/assets/fef8a7b3-c27b-46fb-b3c0-d1ed726b52ae" />








# Show room
## This's where i show you my arts, its amatuer but i enjoy drawing stuff soo, here's is it

Waring: **Aseprite not sponsor these arts 

## The Catbish

![giphy (15)](https://github.com/user-attachments/assets/ba2b2d2d-a6ff-4828-94e3-2f8c3687b29f)

## Mr.Owl

<img width="1062" height="873" alt="image" src="https://github.com/user-attachments/assets/75fd671b-2ed9-4e7a-b91f-7983f16226e9" />

## The Heart

<img width="990" height="686" alt="image" src="https://github.com/user-attachments/assets/5420882d-7a33-490d-a6f2-5bfa7218e680" />

## Self-portrait

<img width="1398" height="869" alt="image" src="https://github.com/user-attachments/assets/906f01a4-3ff7-4446-b5d5-71a1bbd3edbb" />









