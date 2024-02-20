using Raylib_cs;

/// <summary>
/// A Mode representing your simulation / game state
/// </summary>
public class Model
{
    public double X { get; set; } = 0;
    public double Y { get; set; } = 0;
    public double Radius { get; set; } = 15;
    public double Speed { get; set; } = 100;
    public Color Color { get; set; } = Color.Black;
    public double XVelocity { get; set; } = 1;
    public double YVelocity { get; set; }= 1;


    /// <summary>
    /// Advances the simulation / game by the specified amount of time.
    /// </summary>
    /// <param name="deltaTime">Time in seconds</param>
    public void Tick(double deltaTime)
    {
        // Move the model
        UpdatePosition(deltaTime);
        // Keep the model in bounds
        CheckBounds();
    }

    private void UpdatePosition(double deltaTime)
    {
        X += Speed * deltaTime * XVelocity;
        Y += Speed * deltaTime * YVelocity;
    }

    private void CheckBounds()
    {
        // Checks if the ball is outside of the bounds, and changes the x/y velocity
        // if necessary
        if (X > View.ScreenWidth)
        {
            XVelocity = -1;
        }

        if (X < 0)
        {
            XVelocity = 1;
        }

        if (Y > View.ScreenHeight)
        {
            YVelocity = -1;
        }

        if (Y < 0)
        {
            YVelocity = 1;
        }
    }
}