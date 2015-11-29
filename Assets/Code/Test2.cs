using UnityEngine;
using System.Collections;

public class Test2 : MonoBehaviour
{

    private string InputField = "Input";

    void OnGUI()
    {
        //maak een textfield waar we onze input zullen invoeren
        InputField = GUI.TextField(new Rect(10, 10, 200, 20), InputField, 25);
        //maak een button
        if (GUI.Button(new Rect(10, 30, 200, 20), "Check"))
        {
            //als de button geklikt word
            //check inputfield
            if (validate(InputField))
            {
                Debug.Log("Correct");
            }
            else
            {
                Debug.Log("Incorrect");
            }
        }
    }

    //Opdracht:
    //vind doormiddel van breakpoints wat de invoer moet zijn.
    bool validate(string input)
    {
        char[] a = input.ToCharArray();
        int b = 0;

        foreach (var magic in a)
        {
            var c = (int)magic;
            b += c;
            if (c != 51 && c != 76 && c != 84)
            {
                return false;
            }
        }

        if (b != 262)
        {
            return false;
        }

        return true;
    }

    /*********************************************
     * 
     * 
     * Hints staan beneden.
     * 
     * 
    ***********************************************/


    #region Hint 1
    //wat is een char?
    //kijk is naar ascii tabel.
    #endregion

    #region Hint 2
    //elke char is een decimaal getal dat een letter, cijfer of symbool representeerd op een ascii tabel.
    //wat doet de if in de foreach loop?
    //checked deze 
    #endregion

    #region Hint 3
    //De if in de foreach loop checked of het een van de getallen is.
    //zo als we net geleerd gehebben is elke char een getal.
    //er word dus gechecked op 
    //51 = 3
    //76 = L
    //84 = T
    #endregion

    #region Hint 4
    //De laatste if word gechecked wat het alle char's bij elkaar zijn(dus alle char's bij elkaar opgeteld)
    //dit moet 262 zijn
    //hoeveel chars van 51,76 en 84 passen daar in?
    //zijn er meerderen van een soort char?
    #endregion

    #region Hint 5
    //het is een combinatie van volgende char's: L,3,3,T(dus 3,3,L,T kan ook).
    #endregion
}
