using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleratePad : MonoBehaviour
{
    public float m_accelforce = 5f;
    private Vector3 direction;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        string obj_tag = other.gameObject.tag;
        Vector3 dir = new Vector3(0, 0.001f, 1*m_accelforce);
        Vector3 ball_dir = Vector3.forward * m_accelforce;
        Debug.Log(obj.name);
        switch (obj_tag)
        {
            case "Player":
                obj.GetComponent<Rigidbody>().AddForce(dir, ForceMode.Impulse);
                Debug.Log("Force applied");
                break;
        }

        Debug.Log("Collided with: " + obj_tag);
    }

}
