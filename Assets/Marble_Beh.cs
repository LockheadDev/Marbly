using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble_Beh : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            Debug.Log("Finished");
        }
    }
}
