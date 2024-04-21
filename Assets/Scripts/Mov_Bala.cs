using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Bala : MonoBehaviour
{
    private float balaVelocity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(new Vector3(-balaVelocity, 0, 0), ForceMode.Force);
        OutOfBounds();
       balaVelocity  = Mathf.SmoothStep(1f, 15f, 5f / 45f);
    }

    public void OutOfBounds()
    {
        if (this.transform.position.x <= -15)
        {
            Destroy(this.gameObject);
        }
    }

}
