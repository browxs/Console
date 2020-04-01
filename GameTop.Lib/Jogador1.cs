using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Rivaldo")
        {
            _Nome = nome;
        }

        public string Correr()
        {
            return $"{_Nome} esta Correndo \n";
        }

        public string Passar()
        {
            return $"{_Nome} esta Passando \n";
        }

        public string Chutar()
        {
            return $"{_Nome} esta Chutando \n";
        }
    } 
}