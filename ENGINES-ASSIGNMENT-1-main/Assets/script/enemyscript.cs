using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    private playermovement PM;
    public void Start()
    {
        PM = GameObject.FindGameObjectWithTag("Player").GetComponent<playermovement>();
        PM.enemycount++;
    }
    public void OnDestroy()
    {
        PM.enemycount--;
    }
}
