using Raylib_cs;

public class Maca
{
    public int X {get; set;}
    public int Y{get;set;}
    public int Velocidade{get;set;}
    public bool Ativa{get;set;}
    public int Raio{get;set;}
    public int Delay{get;set;}
    

    public Maca(int x, int velocidade,int delay)
    {
        X = x;
        Y = -15;
        Velocidade = velocidade;
        Ativa = true;
        Raio = 15;
        this.Delay = delay;
    }

    public void cair()
    {
        if(Delay > 0)
        {
            Delay--;
            return;
        }

        Y += Velocidade;
    }


    public void Reposicionar()
    {
        Y = -Raio;
        X = Raylib.GetRandomValue(Raio,900 - Raio);
        Delay = Raylib.GetRandomValue(30,20);
    }

    public void Desenhar()
    {
        if(Delay > 0) return;
        Raylib.DrawCircle(X,Y,15,Color.Red);   
    }
}