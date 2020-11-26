using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPowerToPlayer : MonoBehaviour
{

    public GameObject player;
    float shootSpeed;
    public bool collitionBall;

    void Start()
    {
        shootSpeed = 900.0f;
        collitionBall = false;
    }

    
    void Update()
    {
        if (collitionBall)
        {
            AddPower();
            collitionBall = false;
        }
    }

    void AddPower()
    {
        player.GetComponent<Rigidbody>().AddForce(transform.forward * shootSpeed);
    }
}
