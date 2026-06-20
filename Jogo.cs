using Raylib_cs;

public class Jogo
{
    private Cesta cesta;
    private List<Maca> macas;
    private int pontuacao;

    private Image bg;

    private Texture2D texture_bg;

    public Jogo()
    {
        cesta = new Cesta(400,340,80);
        pontuacao = 0;

         macas = new List<Maca>
        {
            new Maca(Raylib.GetRandomValue(15,885),3,0),
            new Maca(Raylib.GetRandomValue(15,885),3,60),
            new Maca(Raylib.GetRandomValue(15,885),3,120),
            new Maca(Raylib.GetRandomValue(15,885),3,180),
            new Maca(Raylib.GetRandomValue(15,885),3,240),
        };

        bg = Raylib.LoadImage("assets/background.png");

        texture_bg = Raylib.LoadTextureFromImage(bg);

        Raylib.UnloadImage(bg);


    }
    
    public void Atualizar()
    { // move a cesta com teclado
        if(Raylib.IsKeyDown(KeyboardKey.Left)) cesta.MoverEsquerda();
        if(Raylib.IsKeyDown(KeyboardKey.Right)) cesta.MoverDireita();

       foreach(Maca m in macas)
        {
            m.cair();

            if(m.Y >= cesta.cesta_eixo_Y &&
           m.X >= cesta.cesta_eixo_X &&
           m.X <= cesta.cesta_eixo_X + cesta.Largura)
        {
            pontuacao ++;
            m.Reposicionar();
        }

        if(m.Y > 480)
        {
            m.Reposicionar();
        }
        }
    }

    public void Desenhar()
    {
        Raylib.DrawTexture(texture_bg,0,0,Color.White);// fundo carrega primeiro
        cesta.Desenhar();
        foreach(Maca m in macas)
        {
            m.Desenhar();
        }
        Raylib.DrawText("Pontos: " + pontuacao,10,10,20, Color.White);
        Raylib.DrawText("FPS: " + Raylib.GetFPS(),820,20,20, Color.Green);
    }
}
