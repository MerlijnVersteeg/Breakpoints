using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test1 : MonoBehaviour
{

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 400, 200),"Als de twee cubes elkaar raken moet de OnCollision log komen.\nGebruik alleen maar breakpoints geen code aanpassen.");
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Cube")
        {
            Debug.Log("Hit");
        }
    }
}
