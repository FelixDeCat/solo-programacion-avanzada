namespace Clase2
{
    using UnityEngine;

    public class EjemploUsoStatic : MonoBehaviour
    {
        private void Start()
        {
            MarineWH pepe = new MarineWH("pepe");
            MarineWH juan = new MarineWH("Juan");
            MarineWH pedro = new MarineWH("pedro");
            MarineWH lucas = new MarineWH("lucas");


            pepe.Correr();
            pepe.name = "pepe2";
            pepe.Disparar();

            print(MarineWH.credo);
        }
    }

    public class MarineWH
    {
        public string name;
        public static string credo = "Por el emperador!!";

        public MarineWH(string name)
        {
            this.name = name;
        }

        public void Correr()
        {

        }

        public void Disparar()
        {

        }

    }
}

