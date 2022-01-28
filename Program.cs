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



