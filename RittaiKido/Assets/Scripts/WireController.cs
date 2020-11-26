using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireController : MonoBehaviour
{
    public GameObject block1;
    public GameObject block2;

    public Vector3 connectedAnchorVec;
    
    void Start()
    {
        connectedAnchorVec = block1.transform.position;
    }

    
    void Update()
    {
        GetComponent<SpringJoint>().connectedAnchor = connectedAnchorVec;
        stopSpring();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<SpringJoint>().spring = 0;
        Debug.Log("butukatta");
    }

    void stopSpring()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<SpringJoint>().spring = 0;
        }
    }
}
