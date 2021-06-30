using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float m_jumpforce = 5f;
    private Vector3 direction;
    private void Update()
    {
        direction = transform.TransformDirection(Vector3.up * m_jumpforce);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        string obj_tag = collision.gameObject.tag;
        switch(obj_tag)
        {
            case "Player":
                obj.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
                break;
        }
        Debug.Log("Collided with: " + obj_tag);
    }
}
