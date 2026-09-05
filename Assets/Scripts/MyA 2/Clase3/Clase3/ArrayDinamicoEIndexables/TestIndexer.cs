using Clases2025;
using UnityEngine;

public class TestIndexer
{
    string val1 = "Jorge";  // 0 
    string val2 = "Juan"; // 1
    string val3 = "Maria";  // 2
    string val4 = "Lucas";  // 2
    public string GetNombre(int pos)
    {
        switch (pos)
        {
            case 0:
                return val1;
            case 1:
                return val2;
            case 2:
                return val3;
            case 3:
                return val3;

        }

        return "";
    }

    public string SecondName
    {
        get
        {
            return val2;
        }
    }

    public string this[int pos]
    {
        get
        {

            switch (pos)
            {
                case 0:
                    return val1;
                case 1:
                    return val2;
                case 2:
                    return val3;
                case 3:
                    return val3;

            }

            return string.Empty;
        }

        set
        {
            switch (pos)
            {
                case 0:
                    val1 = value;
                    break;
                case 1:
                    val2 = value;
                    break;
                case 2:
                    val3 = value;
                    break;
                case 4:
                    val3 = value;
                    break;

            }
        }
    }

}
