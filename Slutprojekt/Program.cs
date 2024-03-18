using Raylib_cs;
using System.Numerics;
using System.Reflection.Metadata;

Raylib.InitWindow(800,800, "Slutprojekt");
Raylib.SetTargetFPS(60);

Rectangle player = new Rectangle(360, 700, 100, 30);

Vector2 movement = new Vector2(0,0);

float speed = 5;

string scene = "start";

while (!Raylib.WindowShouldClose()){
    if (scene == "game"){
        movement = Vector2.Zero;

        if (Raylib.IsKeyDown(KeyboardKey.Right)){
            movement.X = 1;
        }

        if (Raylib.IsKeyDown(KeyboardKey.Left)){
            movement.Y = -1;
        }

        if (movement.Length() > 0)
        {
            movement = Vector2.Normalize(movement) * speed;
        }

        player.X += movement.X;
        player.Y += movement.Y;
    }

    else if (scene == "start"){
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            scene = "game";
        }

    }

    Raylib.BeginDrawing();

    if (scene == "game"){
        Raylib.ClearBackground(Color.White);

    }

    else if (scene == "start"){

    }

    Raylib.EndDrawing();
}