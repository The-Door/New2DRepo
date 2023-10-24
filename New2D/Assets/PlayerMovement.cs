using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float spdX, spdY;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spdX = Input.GetAxisRaw("Horizontal")*speed;
        spdY = Input.GetAxisRaw("Vertical")*speed;
        spdY =spdY/2;
        rb.velocity = new Vector2(spdX,spdY);
    }
}
