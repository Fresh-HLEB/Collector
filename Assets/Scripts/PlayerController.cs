using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speedPlayer=20;
    private float rotationSpeed=60;
    public float force=10;
    private float horizontal;
    private float vertical;
    public Rigidbody rb;
    private bool onIsland;
    void Update()
    {    
        horizontal=Input.GetAxis("Horizontal");
        vertical=Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward*Time.deltaTime*speedPlayer*vertical);       
            transform.Rotate(Vector3.up*Time.deltaTime*rotationSpeed*horizontal); 

            if(Input.GetKeyDown(KeyCode.Space) && onIsland == true) 
            {
                rb.AddForce(Vector3.up * force, ForceMode.Impulse);
                onIsland = false;
            }    
    }
    private void OnCollisionEnter(Collision collision)  
    {
        if(collision.gameObject.CompareTag("Island"))
        {
            onIsland = true;
        }
    } 
}
