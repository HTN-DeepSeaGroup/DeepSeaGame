using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{

    public Rigidbody2D rb;
    float horizontalMovement, verticalMovement;
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
        print(horizontalMovement);
        rb.velocity= new Vector2(horizontalMovement*2, rb.velocity[1]);
    }
}
