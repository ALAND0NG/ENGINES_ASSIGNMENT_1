using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
     
        if (col.gameObject.tag == "enemy")
        {
            GameObject.Destroy(col.gameObject);
        }
        Destroy(gameObject);
    }
  
}
