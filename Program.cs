using Raylib_cs;

public class Program
{
    public static void Main(string[] args)
    {
        Raylib.InitWindow(900,360,"Pegar Maçã");
        Raylib.SetTargetFPS(60);

        Jogo jogo = new Jogo();

        while (!Raylib.WindowShouldClose())
        {
            jogo.Atualizar();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            
            jogo.Desenhar();
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}