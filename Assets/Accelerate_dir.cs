using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate_dir : MonoBehaviour
{
    [SerializeField]
    private float impulseForce = 5f;

    private void OnCollisionStay(Collision collision)
    {
        collision.rigidbody.velocity += Vector3.forward * Time.fixedDeltaTime * impulseForce;
    }

}
