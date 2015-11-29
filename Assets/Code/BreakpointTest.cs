using UnityEngine;
using System.Collections;

public class BreakpointTest : MonoBehaviour
{
    void Start()
    {
        //je kan een breakpoint maken door F9 te drukken op de regel code waar je een breakpoint wilt hebben
        int a = 5;
        int b = 5;        
        int c = a + b;
        Debug.Log(c);
        //wat is C?
    }
}
