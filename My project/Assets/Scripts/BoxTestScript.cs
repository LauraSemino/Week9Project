using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTestScript : MonoBehaviour
{
    public Rigidbody2D redBoxRigidBody;

    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("We have entered the space of another collider.");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("We are in the space of another collider.");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("We have left the space of another collider.");
    }
}
