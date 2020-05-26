using System;

namespace POO
{
    public class Smartphone
    {
        private const bool V = true;
        public string cor;
        public string modelo;
        public double tamanho;
        // em px - ex. 3200x1700

        public bool on;
          
        public string Ligado(){
            if ( on == false){
                on = true;
                return "O celular esta ligado.";
            }
            else
            {
                return "O celular ja esta ligado.";
            }
        }
        public string Desligado(){
            if ( on == true){
                on = false;
                return "O celular esta desligado.";
            }
            else{
                return "O celular ja esta desligado.";
            }
        }

        public string Mensagem(){
            if (on == false){
                return "O celular deve estar ligado para isso.";
            }
            else{
                return "Mensagem enviada com sucesso!";
            }
        }
        public string Ligação(){
            if (on == false){
                return "O celular deve estar ligado para isso.";
            }
            else{
                return "Ligação realizada com sucesso!";
            }
        }
        
    }
}