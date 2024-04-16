using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakan : MonoBehaviour
{
    public Rigidbody rb;
    public float maju = 100.0f;
    public float kanan = 5000.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, maju*Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(kanan, 0,0);
        }
        else if(Input.GetKey("a")){
            rb.AddForce(-kanan, 0,0);
        }
    }

}
