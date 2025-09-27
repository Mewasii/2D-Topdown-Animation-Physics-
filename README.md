# Welcome to my little game testing place
This project is my little playground where I experiment with animation and physics to better understand
how game mechanics come to life. It’s also the place where I share my 2D pixel art, combining my love for both art and design.
Working on this not only helps me learn, but also gives me the joy of creating something I’ve always dreamed about.

# The Testing Ground
## #1: The Orange Cat
This free orange cat was taken from free assets I found somewhere on the internet (I kind of stole it, not gonna lie). Then I started testing with him to understand how the animations work. I created a basic movement interaction for him, and it looks like this:

<img width="770" height="362" alt="image" src="https://github.com/user-attachments/assets/33f259e6-bcc8-4138-9183-40ca8802e8ed" />

Basicly he can walk, jumpin, and guest what, walk faster ( i call it running)

![gif](https://github.com/user-attachments/assets/801c07b6-52b7-4004-8099-4d2c73c249c7)

## #2 Idle

Firt we'll talk about how orange dude can up down up down him self
Infact he have 10 frame of different state of how he stand

<img width="1919" height="677" alt="image" src="https://github.com/user-attachments/assets/9201d16a-e28c-48e8-9c40-76453eec0273" />

combine each with others, set a perfect sample rate for animator and the dude can idle himself

![giphy (8)](https://github.com/user-attachments/assets/00ff7673-571a-43d0-a4b9-a4687315ba8c)

## #3 Walking

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

## #4 Jump in (or dash in) and running

remember about the previous trickypart ?
This's still the sameone mate :3 

But here's the things, instead of >< button, now i have "space" for jumpin and "ctrl" for running 
The condition of jumping is pretty simple hit "space" and Orange jump

![giphy (9)](https://github.com/user-attachments/assets/9cf0302b-0b18-42fd-9e74-4a77b607b1a4)

but with the running , Orange need to accelarate so he will walk first, then if i hit "ctrl": the cat's runnin

<img width="697" height="352" alt="image" src="https://github.com/user-attachments/assets/84be07c1-1238-4899-ad80-b2b6d981fed6" />

![giphy (11)](https://github.com/user-attachments/assets/1bda7eb1-51c2-43e4-8298-34e3c2dc3a3a)



