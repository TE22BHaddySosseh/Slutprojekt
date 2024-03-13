using Raylib_cs;

Raylib.InitWindow(800,800, "Slutprojekt");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose()){

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.White);

    Raylib.DrawRectangle(360, 700, 100, 30, Color.Black);

    Raylib.EndDrawing();
}