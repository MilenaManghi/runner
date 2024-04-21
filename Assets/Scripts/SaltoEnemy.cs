using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoEnemy : MonoBehaviour
{
    public float jumpForce;
    private bool jump;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(jump == true)
        {

            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }

    }
}
