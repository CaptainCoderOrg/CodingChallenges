using Raylib_cs;

/// <summary>
/// The view knows how to render a model
/// </summary> 
public class View
{

    public const int ScreenWidth = 800;
    public const int ScreenHeight = 450;

    /// <summary>
    /// Initializes the game window and view. This should be called exactly once
    /// before any other method.
    /// </summary>
    public void Initialize()
    {
        Raylib.InitWindow(ScreenWidth, ScreenHeight, "raylib [core] example - basic window");
        Raylib.SetTargetFPS(60);
    }

    /// <summary>
    /// Cleans up the view. This method should be called when the game exits and closes any
    /// system resources that are in use.
    /// </summary>
    public void CleanUp()
    {
        Raylib.CloseWindow();
    }

    /// <summary>
    /// Given a model, render it to the screen.
    /// </summary>
    public void Render(Model model)
    {
        // Sets up the frame to be drawn
        Raylib.BeginDrawing();

        // Clears the screen and fills with Color.SkyBlue
        Raylib.ClearBackground(Color.SkyBlue);

        string debugText = $"""
        X: {model.X:0.0}
        Y: {model.Y:0.0}
        Radius: {model.Radius:0}
        Instructions:
        Up/Down - Change Radius
        B - Blue | R - Red | X - Black
        """;
        Raylib.DrawText(debugText, 0, 0, 16, Color.White);

        Raylib.DrawCircle((int)model.X, (int)model.Y, (int)model.Radius, model.Color);

        //Finish drawing frame
        Raylib.EndDrawing();
    }
}