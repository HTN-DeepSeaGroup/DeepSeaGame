using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    GameObject Darkness;
    Darkness_Manager DMan;
    // Start is called before the first frame update
    void Start()
    {
        Darkness = GameObject.Find("Darkness");
        DMan = Darkness.GetComponent<Darkness_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.name == "Star_Physics")
        {
            //print("collideS");
            DMan.darkness -= 600;
            Destroy(collision.transform.parent.gameObject);
        }

        if (collision.gameObject.name == "Angler_Fish_Physics")
        {
            //print("collideA");
            DMan.darkness += 1200;
        }
    }
}
