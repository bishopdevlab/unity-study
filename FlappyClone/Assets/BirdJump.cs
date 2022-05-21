using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D myRigidbody2D;
    public float JumpPower;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigidbody2D.velocity = Vector2.up * JumpPower;    // (0,3)
        }
    }
}
