using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Jogos2D
{

    class Program
    {
        

        static void Main(string[] args)
        {
            Zumbi zumbi = new Zumbi();

            zumbi.vida = 100;
            zumbi.velocidade = 0.5f;
            zumbi.energia = 50.0f;

            Console.WriteLine(" A vida é " + zumbi.vida + " A velocidade é  " + zumbi.velocidade + " A energia é " + zumbi.energia);

            Zumbi pai = new Zumbi();
            Zumbi_filho filho = new Zumbi_filho();

            pai.Andar();
            filho.Andar();


            Console.ReadLine();
        }
    }
}

public class Zumbi
{
    public int vida;
    public float velocidade;
    public float energia;
    public virtual void Andar()
    {
        Console.WriteLine("Pai andando ");

    }
}

public class Zumbi_filho : Zumbi
{
    public override void Andar()
    {
        Console.WriteLine("Filho andando");
    }
}
