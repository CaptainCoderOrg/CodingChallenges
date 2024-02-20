using Raylib_cs;

/// <summary>
/// The controller knows how to update / modify the model
/// </summary>
public class Controller
{

    /// <summary>
    /// Processes the users input. User input is typically processed first.
    /// </summary>
    public void HandleUserInput(Model model)
    {
        // Raylib.IsKeyDown checks it the key is being held
        if (Raylib.IsKeyDown(KeyboardKey.Up))
        {
            model.Radius += 1;
        }

        if (Raylib.IsKeyDown(KeyboardKey.Down))
        {
            model.Radius -= 1;
            model.Radius = Math.Max(1, model.Radius);
        }

        // Raylib.IsKeyPressed is true during the frame the key was pressed
        if (Raylib.IsKeyPressed(KeyboardKey.R))
        {
            model.Color = Color.Red;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.B))
        {
            model.Color = Color.DarkBlue;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.X))
        {
            model.Color = Color.Black;
        }
    }
}