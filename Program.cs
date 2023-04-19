using Raylib_cs;

class Program {
    static void Main () {
        Raylib.InitWindow(306, 65, "Hello World");
        Raylib.SetTargetFPS(1);
        while (!Raylib.WindowShouldClose()) {
            Raylib.BeginDrawing();
            Raylib.DrawText("Hello World", 10, 10, 50, Color.WHITE);
            Raylib.EndDrawing();
        }
    }
}