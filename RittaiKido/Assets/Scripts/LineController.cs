using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{

    public GameObject player;
    public GameObject shootBall;

    WireController wire;
    Transform playerTf;
    SpringJoint sp;

    void Start()
    {
        
        wire = player.GetComponent<WireController>();
        playerTf = player.transform;
        sp = player.GetComponent<SpringJoint>();
    }

    void Update()
    {
        
        GetComponent<LineRenderer>().SetPosition(1, shootBall.GetComponent<Transform>().position);
        GetComponent<LineRenderer>().SetPosition(0, sp.connectedAnchor);
        if (sp.spring == 0)
        {
            GetComponent<LineRenderer>().enabled = false;
        }
        else
        {
            GetComponent<LineRenderer>().enabled = true;
        }
    }
}
