using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorMovement : MonoBehaviour
{
    public float conveyorSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            Vector3 forceDirection = transform.right;
            rigidbody.velocity = forceDirection * conveyorSpeed;
        }
    }

}
