using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

        Rigidbody2D rb=GetComponent<Rigidbody2D>();

        rb.isKinematic = true;
        rb.velocity = new Vector2(speed,speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
