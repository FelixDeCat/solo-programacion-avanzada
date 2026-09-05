using UnityEngine;

namespace MyEntities
{
    public class Perro
    {
        // no se puede acceder desde ningun lado
        private int patas = -1;

        // se puede acceder desde cualquier lado
        public string nombre;

        // solo los hijos que lo implementen, lo pueden acceder
        protected string genoma;

        public Perro()
        {
            // perro marca perro
            // tiene 4 patas porque todos lo deberian tener
            patas = 4;
        }

        public Perro(int _patas)
        {
            // perro marca perro
            // tiene 4 patas porque todos lo deberian tener
            this.patas = _patas;
        }

        public void Amputar(int cantPatas)
        {
            patas = patas - cantPatas;
        }


        public void Alimentar(int croqueta_balanceada)
        {
            Debug.Log($"Le doy de comer {croqueta_balanceada} croquetas");
        }
    }

    public class HijoDelPerro : Perro
    {

        string currentgenoma;
        void ImplementarGenoma()
        {
            currentgenoma = genoma;
        }
    }
    public class HijoDePerra : Perro
    {

        string currentgenoma;
        void ImplementarGenoma()
        {
            currentgenoma = genoma;
        }
    }
}
