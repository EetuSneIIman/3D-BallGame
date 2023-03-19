using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    

    public float Speed = 800f;

    public Rigidbody rb;

    public bool groundCheck = true;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }




    void FixedUpdate()
    {
        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0.0f, z);

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(movement + Camera.main.transform.forward * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(movement + Camera.main.transform.forward * -1 * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(movement + Camera.main.transform.right * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(movement + Camera.main.transform.right * -1 * Speed * Time.deltaTime);
        }

        ///GetComponent<Rigidbody>().AddForce(movement * Speed * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            groundCheck = false;
        
        }

       
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            groundCheck = true;
        }
    }




}
