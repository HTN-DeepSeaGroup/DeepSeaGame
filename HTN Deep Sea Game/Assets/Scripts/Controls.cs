using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{

    public Rigidbody2D rb;
    float horizontalMovement, verticalMovement;
    float xmomentum, ymomentum;
    float maxSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        xmomentum += horizontalMovement/3;
        ymomentum += verticalMovement/3;
        rb.velocity= new Vector2(Mathf.Min(xmomentum,maxSpeed),Mathf.Min(ymomentum,maxSpeed));
        xmomentum = rb.velocity[0] * 0.9f;
        ymomentum = rb.velocity[1] * 0.9f;
    }

    
}
