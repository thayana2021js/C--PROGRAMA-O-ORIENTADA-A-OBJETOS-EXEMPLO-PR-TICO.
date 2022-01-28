C# PROGRAMA-O-ORIENTADA-A-OBJETOS-EXEMPLO-PR-TICO.

using System;
using Poo_MentoriaDio.Src.Entidades;

namespace Poo_MentoriaDio
{
     class Program
    {
        static void Main(string[] args)
        {

            Veiculo carro = new Veiculo("Aicross" , "Citroe", 2021, "Vermelho", 68000.00);
            Veiculo carro2 = new Veiculo("C4" , "Citroe", 2023, "Azul", 90000.00);



            Console.WriteLine(carro);
            Console.WriteLine("----------");
            Console.WriteLine(carro2);

        //usar sem argumentos:
            //carro.Marca = "Citroe";
           // carro.Modelo = "Aircross";
           // carro.Ano = 2021;
           // carro.Cor ="Vermelho";


         // exemplo 2
            //Console.WriteLine("Carro: " + carro.Marca + "\n"
           // + "Modelo: " + carro.Modelo + "\n"
           // + "Ano:    " + carro.Ano + "\n"
           // + "Cor:    " + carro.Cor);

             //primeiras caracterisca do carro:
               //string Marca = "Citroe CompletaCambioAutomatico";
              //NewMethod();
             //string Cor = "Vermelho";
            //string versao = "CompletaCambioAutomatico";
           //int Ano = 2021;
          //string Modelo = "Aircross";
         // static void NewMethod()
    
                

        }
    }   
}
//////////////////////////////////////////////////
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Poo_MentoriaDio.Src.Entidades
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public double Preco { get; set; }
        public int KmRodados { get; set; }
        public Veiculo(string Marca, string Modelo, int Ano, string Cor, double Preco)
        {
            this.Marca  = Marca;
            this.Modelo = Modelo;
            this.Ano    = Ano;
            this.Cor    = Cor;
            this.Preco  = Preco;
            this.KmRodados = 0;
        }

        public override string ToString(){
            return "Carro: " + this.Marca + "\n"
            + "Modelo: " + this.Modelo + "\n"
            + "Ano: " + this.Ano + "\n"
            + "Cor: " + this.Cor + "\n"
            + "Preco: " + this.Preco + "\n"
            + "Km rodada: " + this.KmRodados;

        }
      
    }
}
