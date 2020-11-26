using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    float x_sensi;
    float y_sensi;
    float moveSpeed;
    float jumpPower;
    public GameObject camera;

    void Start()
    {
        x_sensi = 3;
        y_sensi = 3;
        moveSpeed = 0.1f;
        jumpPower = 300.0f;
    }

    // Update is called once per frame
    void Update()
    {
        cameraControll();
        moveControll();
    }

    void moveControll()
    {
        transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Vertical")) * moveSpeed;
        transform.position += transform.TransformDirection(Vector3.right) * Input.GetAxis("Horizontal") * moveSpeed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, jumpPower, 0);
        }
    }

    void cameraControll()
    {
        float x_Rotation = Input.GetAxis("Mouse X");
        float y_Rotation = Input.GetAxis("Mouse Y");
        x_Rotation = x_Rotation * x_sensi;
        y_Rotation = y_Rotation * y_sensi;
        this.transform.Rotate(0, x_Rotation, 0);
        camera.transform.Rotate(-y_Rotation, 0, 0);
    }
}
