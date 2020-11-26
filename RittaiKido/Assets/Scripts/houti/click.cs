using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    LineRenderer line;
    SpringJoint sg;
    Rigidbody rb;
    Vector3 setTapPos;
    float speed = 7;
    public float SpringVal = 10.0f;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        sg = GetComponent<SpringJoint>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                sg.connectedAnchor = hit.point;
                Debug.Log(hit.point);
            }
        }
        else if (Input.GetMouseButton(0))
        {
            sg.spring = SpringVal;
            line.enabled = true;
            rb.useGravity = false;

            
            line.SetPosition(0, transform.position);
            line.SetPosition(1, sg.connectedAnchor);
        }
        else
        {
            sg.spring = 0.0f;
            line.enabled = false;
            rb.useGravity = true;
        }

        

        
    }
}
