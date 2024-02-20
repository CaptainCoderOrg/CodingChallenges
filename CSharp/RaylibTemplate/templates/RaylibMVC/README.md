# Raylib Model View Controller Template

This template uses a typical Model/View/Controller workflow which can be used
for creating simple games and simulations.

## Model-View-Controller

Imagine you're creating a video game where a superhero zooms around the city,
saving people and battling villains. To keep everything in order, you can use a
design pattern called Model-View-Controller, or MVC. It's like breaking down the
game creation into different roles, making sure everything works smoothly
without getting mixed up. Let's see how this works in your superhero game:

*Model*: Think of the Model as the game's knowledge keeper. It knows where your
superhero is, their health, the points you've scored, and where the villains
are. But, the Model is quiet; it doesn't show anything on the game screen. Its
job is to remember all the important details, like how many power-ups you've
collected or if a villain is near, but it doesn't tell you directly.

*View*: The View is the game's artist. It takes all the information from the
Model - like the superhero's location and the city layout - and paints it on
your screen. The View focuses on making the game look cool and exciting. It
shows your superhero flying, the buildings below, and any villains or bonuses.
However, it doesn't decide what happens in the game; it just displays it for you
to see.

*Controller*: The Controller is like the game's director. It listens to your
commands (when you press buttons to move the superhero or make them do actions)
and tells the Model what to change. If you want the superhero to move right, the
Controller says, "Hey, Model, our player wants to go right!" Then, the Model
updates everything, and the View makes sure you see the superhero moving right
on your screen. The Controller is in charge of making things happen based on
what you want to do.

In your superhero game:

* The Model is the brain that keeps track of everything but doesn't talk
  directly to you.
* The View is the storyteller that shows you what's happening in the game but
  doesn't know the rules or make decisions.
* The Controller is the one that listens to you and makes the game react, but it
  doesn't display anything or remember the game's details by itself.

The goal of MVC is to separate the responsibility of each of your components to
more effectively manage the complexity of the project as it grows . It's like
having a team where everyone knows their job, making it easier for you to create
awesome games, fix problems, or add new adventures. This way, everything stays
neat and your superhero game becomes a fantastic world for players to explore.