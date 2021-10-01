using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Canvas cv;
    public int enemycount;
    public float ms = 4f;
    public Rigidbody2D rb;
    public Camera cam1;
    Vector2 movement;
    Vector2 mousePos;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam1.ScreenToWorldPoint(Input.mousePosition);
        if (enemycount == 0)
            cv.enabled = true;
        else
            cv.enabled = false;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * ms * Time.fixedDeltaTime);

        Vector2 LD = mousePos - rb.position;
        float angle = Mathf.Atan2(LD.y, LD.x)*Mathf.Rad2Deg -90;
        rb.rotation = angle;
    }

}
