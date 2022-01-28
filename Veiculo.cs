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