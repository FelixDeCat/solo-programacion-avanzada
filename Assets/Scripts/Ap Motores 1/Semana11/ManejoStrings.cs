using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using TMPro;

public class ManejoStrings : MonoBehaviour
{
    string myString1 = "";
    string myString2 = string.Empty;

    const string PLAYERKEY = "PLYR_NAME_ZARARZA";

    [SerializeField] TextMeshProUGUI txtSample;

    private void Start()
    {
        txtSample.text = "<color=red>My</color>T<b>ex</b>t";

        string msg = string.Empty;

        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                int val = Random.Range(10, 100);
                string aux = string.Empty;
                if (val >= 50)
                {
                    aux = "<color=red>" + val.ToString() + "</color>";
                }
                else if (val > 25)
                {

                    aux = "<color=#ffff00ff>" + val.ToString() + "</color>";
                }
                else
                {
                    aux = val.ToString();
                }
                msg += aux + ",";
            }
            msg = msg.TrimEnd(',');
            msg += "\n";
        }

        print(msg);

        return;
        string myText = "Hola";

        myText = myText.Replace("ol", "Chau");

        Debug.Log(myText); // Chau

        string text1 = "Gato";

        int count = text1.Length; // 4

        char first = text1[0]; // 'G'
        char second = text1[1]; // 'a'
        char last = text1[text1.Length-1]; // 'o'


        #region SPLIT (Serialize y Deserialize)
        /// 
        // lado del Serializador, Conversor

        string data = "Ana,Pedro,Juan,Matias";
        /// Guardamos o enviamos...
        /// 
        // Lo Recibimos

        string raw = data;
        string[] col = data.Split(',');


        /// ENVIO DATOS (Serializacion)
        Data d = new Data();
        d.data1 = 20;
        d.data2 = "Jose";
        d.data3 = true;
        string toSend = d.data1.ToString() + "," + d.data2 + "," + d.data3.ToString();
        
        // Send(toSend)
        // Save(toSend)
        // recibe

        // SIMULACION DE RECIBIR DATOS
        string getVal = toSend; /// lo levanto de algun lado

        // CONVERSION DE DATOS (Deserializacion)
        string[] convertd = toSend.Split(',');

        Data dC = new Data();
        dC.data1 = int.Parse( convertd[0]);
        dC.data2 = convertd[1];
        dC.data3 = bool.Parse(convertd[2]);

        #endregion


        string concatString = "Pedro,Juan,Marta";
        string[] jugadores = { "Pedro", "Juan", "Marta", "Luis", "Jorge" };
        string concatArray = jugadores[0] + "," + jugadores[1] + "," + jugadores[2] + "," + jugadores[3] + "," + jugadores[4];
        string concatJoin = string.Join(",", jugadores); /// forma dinamica de hacerlo

        int[] integers = { 12, 23, 432, 5, 3, 4, 23 };
        string concatJoinInt = string.Join(":", integers.Select(x => x.ToString()).ToArray()); // en IA2


        // pepe + juan
        string id = string.Concat("PLAYER", "_", "01"); /// PLAYER_01

        string ply = "Jorge";
        int gold = 20;

        string message = $"hola {ply} tenes {gold} de oro";

        Dictionary<string,string> localizations = new Dictionary<string,string>();
        localizations.Add("en", "Hello PLYR_NAME_ZARARZA you have GOLD gold");
        localizations.Add("es", "hola PLYR_NAME_ZARARZA tenes GOLD oro");

        localizations["en"].Replace(PLAYERKEY, ply);
        localizations["es"].Replace(PLAYERKEY, ply);

        string fecha = "23/10/2026";
        fecha = fecha.Replace('/','-');


        //// Contains
        ///

        string pySetting = "PlayerSettings";
        bool esSetting = pySetting.Contains("Settings"); // true

        string archivo = "player.png";
        bool isPng = archivo.EndsWith("pNg", System.StringComparison.OrdinalIgnoreCase); //true


        string alias_de_doña_rosa = "rosa.servilleTa.cactus".ToLower(); ///servidores de MP, CTaDNI
        string alias_de_envio = "RoSa.SeRvilLeTa.CacTus";
        alias_de_envio = alias_de_envio.ToLower();


        string palabra = "Microfono";
        int indexF = palabra.IndexOf('f'); /// 5


        string entrada = "   Ana    ";

        string a = entrada.Trim(); // "Ana"
        string b = entrada.TrimStart(); // "Ana    "
        string c = entrada.TrimEnd(); // "    Ana"

        string ruta = "////rol/manuales/phb/asd.pdf";
        ruta = ruta.Trim('/'); /// "rol/manuales/phb/asd.pdf"

        /////
        ///


        /*
         coca........6000......2.....12000
         pan.........3000......1.....3000
         fiambre_pa..12000.....300...60000
         */

        string item = "coca";
        item = item.PadLeft(12,'.'); // 10 elementos [ c, o ,c, a, ., ., ., ,., ., ., ., ., . ]

        string totales = "12000";
        totales = totales.PadRight(9,'.'); // 9 elementos         ....12000|

    }

    public struct Data
    {
        public int data1;
        public string data2;
        public bool data3;
    }
}
