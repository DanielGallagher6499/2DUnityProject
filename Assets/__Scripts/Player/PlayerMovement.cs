using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Public Variables
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;

    //Vectors
    Vector2 movement;
    Vector2 mousePos;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        //Border so player doesnt go off screen
        float yValue = Mathf.Clamp(rb.position.y, -4.5f, 4.5f);
        float xValue = Mathf.Clamp(rb.position.x, -10.25f, 10.25f);

        rb.position = new Vector2(xValue, yValue);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //Makes the player follow the mouse around the screen
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
