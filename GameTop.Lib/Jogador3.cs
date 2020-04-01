using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chutar()
        {
            return "Teste chuta \n";
        }

        public string Correr()
        {
            return "Teste corre \n";
        }

        public string Passar()
        {
            return "Teste passa \n";
        }
    }
}