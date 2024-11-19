using static Raylib_cs.Raylib;
using Raylib_cs;

int lastX = 1;
int lastY = 1;
int x = 1; // The player's starting position
int y = 1;
int tileSize = 32; // Changes the size of each tile
char[,] maze; // Stores your maze as an array so it can be modified later

// The message that should currently be displayed
string currentMessage = "";
// How long the message should remain on the screen
float messageTime = 0;

// The starting area
string starting_area = """
    ################
    #              #
    ############## #
    #2           # #
    ####### #### # #
    ##4     #### # #
    #######3#### # #
    ############ # #
    #1             #
    ################
    """;

LoadMaze(starting_area);
Main();

void Main()
{
    // Initialization
    //--------------------------------------------------------------------------------------
    const int screenWidth = 1280;
    const int screenHeight = 720;

    InitWindow(screenWidth, screenHeight, "2D Maze");
    
    // You must load images after the screen has been initialized
    LoadImages();

    DisplayMessage("Welcome to my dungeon!", 10);

    SetTargetFPS(60);
    //--------------------------------------------------------------------------------------

    // Main game loop
    while (!WindowShouldClose())
    {
        // Update
        //----------------------------------------------------------------------------------
        // TODO: Update your variables here
        //----------------------------------------------------------------------------------
        HandleUserInput();
        // Draw
        //----------------------------------------------------------------------------------
        BeginDrawing();
        ClearBackground(Raylib_cs.Color.Black);
        DrawMap();
        DrawPlayer();
        DrawMessage();
        EndDrawing();
        //----------------------------------------------------------------------------------
    }

    // De-Initialization
    //--------------------------------------------------------------------------------------
    CloseWindow();
    //--------------------------------------------------------------------------------------
}

/// <summary>
/// Given a string that represents a map, converts it into an array of characters
/// and assigns it to maze
/// </summary>
/// <param name="map"></param>
void LoadMaze(string map)
{
    string[] rows = map.ReplaceLineEndings().Split(Environment.NewLine);
    int height = rows.Length;
    int width = rows.Select(r => r.Length).Max();
    maze = new char[width, height];
    // Loop through every row and column in your maze
    for (int row = 0; row < height; row++)
    {
        for (int col = 0; col < width; col++)
        {
            if (col < rows[row].Length)
            {
                // If there was a symbol at this position assign it to the maze
                maze[col, row] = rows[row][col];
            }
            else
            {
                // If there was no symbol, set the default value to a blank character
                maze[col, row] = ' ';
            }            
        }
    }
}

void LoadImages()
{
    ImageManager.SetSymbol(' ', "dungeon/tile_0000.png");
    ImageManager.SetSymbol('#', "dungeon/tile_0040.png");
    ImageManager.SetSymbol('@', "dungeon/tile_0085.png");
    ImageManager.SetSymbol('1', "dungeon/tile_0084.png");
    ImageManager.SetSymbol('2', "dungeon/tile_0089.png");
    ImageManager.SetSymbol('3', "dungeon/tile_0104.png");
    ImageManager.SetSymbol('4', "dungeon/tile_0121.png");
}

void DrawSymbolAt(char symbol, int x, int y)
{
    int tileX = x * tileSize;
    int tileY = y * tileSize;
    ImageManager.DrawSymbol(symbol, tileX, tileY, tileSize);
}

void DrawMap()
{
    for (int x = 0; x < maze.GetLength(0); x++)
    {
        for (int y = 0; y < maze.GetLength(1); y++)
        {
            DrawSymbolAt(maze[x,y], x, y);
        }
    }
}

void DisplayMessage(string message, float duration)
{
    currentMessage = message;
    messageTime = duration;
}

void DrawMessage()
{
    if (messageTime > 0)
    {
        int fontSize = 24;
        int xPosition = 16 * tileSize;
        int yPosition = 0;
        Raylib.DrawText(currentMessage.ReplaceLineEndings("\n"), xPosition, yPosition, fontSize, Color.White);
        messageTime -= Raylib.GetFrameTime();
    }
}

void DrawPlayer()
{
    DrawSymbolAt('@', x, y);
}

void HandleUserInput()
{
    (lastX, lastY) = (x, y);

    if (Raylib.IsKeyPressed(KeyboardKey.Right))
    {
        x++;
    }
    else if (Raylib.IsKeyPressed(KeyboardKey.Left))
    {
        x--;
    }
    else if (Raylib.IsKeyPressed(KeyboardKey.Down))
    {
        y++;
    }
    else if (Raylib.IsKeyPressed(KeyboardKey.Up))
    {
        y--;
    }

    CheckWalls();
    CheckOldMan();
    CheckGhost();
    CheckChest();
    CheckSword();

}

void CheckSword()
{
    if (maze[x, y] == '3')
    {
        DisplayMessage("It's a sword", 2);
    }
}

void CheckChest()
{
    if (maze[x, y] == '2')
    {
        DisplayMessage("It's a chest", 2);
    }
}

void CheckGhost()
{
    if (maze[x, y] == '4')
    {
        DisplayMessage("It's a ghost", 2);
    }
}

// The player should not be allowed to move through walls
void CheckWalls()
{
    if (maze[x, y] == '#')
    {
        (x, y) = (lastX, lastY);
        DisplayMessage("Ouch!", 2);
    }
}

void CheckOldMan()
{
    if (maze[x, y] == '1')
    {
        DisplayMessage("""
        I'm an old man!

        E - Talk

        A - Attack
        """, 1);

        if (Raylib.IsKeyPressed(KeyboardKey.E))
        {
            x++;
            DisplayMessage("You must find the sword!", 10);
        }

        if (Raylib.IsKeyPressed(KeyboardKey.A))
        {
            maze[x, y] = ' ';
            DisplayMessage("The old man vanishes!", 10);
        }
    }
}