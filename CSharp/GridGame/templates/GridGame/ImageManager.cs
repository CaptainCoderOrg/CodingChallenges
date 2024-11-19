using Raylib_cs;

// Warning, you should not modify this file

/// <summary>
/// Manages loading and drawing images to the screen
/// </summary>
public static class ImageManager
{
    private static Dictionary<char, Texture2D> _images = new();
    private static Dictionary<char, string> _assignment = new();

    /// <summary>
    /// Assign a character symbol to a specific image. Images should be placed in the `assets\images` directory.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="imagePath"></param>
    /// <exception cref="Exception"></exception> <summary>
    /// 
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="imagePath"></param>
    public static void SetSymbol(char symbol, string imagePath)
    {
        if (_images.ContainsKey(symbol))
        {
            throw new Exception($"The {symbol} was previously assigned to {_assignment[symbol]}");
        }
        Image image = Raylib.LoadImage(AssetPath(imagePath));
        Texture2D texture = Raylib.LoadTextureFromImage(image);
        _images[symbol] = texture;
        _assignment[symbol] = imagePath;
    }

    public static void DrawSymbol(char symbol, int x, int y, int tileSize)
    {
        if (_images.TryGetValue(symbol, out Texture2D texture))
        {
            float scale = (float)tileSize / texture.Width ;
            Raylib.DrawTextureEx(texture, new System.Numerics.Vector2(x, y), 0, scale, Color.White);
        }
        else
        {
            throw new Exception($"Attempted to draw the symbol {symbol} but it had not be set with `SetSymbol`");
        }        
    }

    private static string AssetPath(string name) => "assets/images/" + name;

}