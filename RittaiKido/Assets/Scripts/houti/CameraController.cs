using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject Player;
    public GameObject Camera;

    void Start()
    {
        
    }

    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        Player.transform.Rotate(0, X_Rotation, 0);
        Camera.transform.Rotate(-Y_Rotation, 0, 0);
    }
}
