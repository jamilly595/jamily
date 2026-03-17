using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb; 
    public float jumpForce;
    public bool Grounded; 
    public float speed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector2.up * jumpForce);
        Grounded = false; 
        {
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed);
        }
    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
        Grounded = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}




    
  
