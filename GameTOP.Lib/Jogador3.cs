using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {  
        public string Chuta()
        {
            return $"Teste chuta\n"; 
        }

        public string Corre()
        {
            return $"Teste corre\n";

        }
        public string Passa()
        {
            return $"Teste passa\n";
        }
        
    }
}