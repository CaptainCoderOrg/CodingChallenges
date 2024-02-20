using Raylib_cs;


// Initialize the game
Model model = new();
Controller controller = new();
View view = new();

// Initializes the game view
view.Initialize();

// Main game loop
// Loop while the window is open
while (!Raylib.WindowShouldClose())
{
    // Handle the suers input
    controller.HandleUserInput(model);

    // The amount of time that has passed since the last frame
    double deltaTime = Raylib.GetFrameTime();
    // Advance the model forward the amount of time that has passed
    model.Tick(deltaTime);

    // Draw the view
    view.Render(model);
}

// Cleans up and closes everything when the main loop ends
view.CleanUp();