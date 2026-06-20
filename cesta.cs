using Raylib_cs;

public class Cesta
{
    public int cesta_eixo_X {get; set;}
    public int cesta_eixo_Y {get; set;} 

    public int Largura{get; set;}

    public Cesta(int x,int y, int largura)
    {
     cesta_eixo_X = x;
     cesta_eixo_Y = y;
     Largura = largura;   
    }

    public void MoverEsquerda()
    {
       cesta_eixo_X -= 5; 
    }

    public void MoverDireita()
    {
        cesta_eixo_X += 5;
    }

    public void Desenhar()
    {
        Raylib.DrawRectangle(cesta_eixo_X,cesta_eixo_Y,Largura,20,Color.Brown);
    }

}