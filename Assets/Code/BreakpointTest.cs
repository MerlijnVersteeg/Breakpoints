using UnityEngine;
using System.Collections;

public class BreakpointTest : MonoBehaviour
{
    void Start()
    {
        //zorg er voor dat monodevelop/visual studio attached is aan Unity
        //in monodevelop kan dat via de play/attach knop rechts boven
        //in visual studio kan dat door middel van attack to unity knop

        //je kan een breakpoint maken door F9 te drukken op de regel code waar je een breakpoint wilt hebben
        //zet een break point op debug.log

        //nu moet je in unity de main scene starten
        //als alles goed is gegaan zal de code "breaken" op debug.log waar jou breakpoint staat
        int a = 5;
        int b = 5;        
        int c = a + b;
        Debug.Log(c);
        //wat is C?
    }
}
