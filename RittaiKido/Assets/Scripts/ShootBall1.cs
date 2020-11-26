using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall1 : MonoBehaviour
{
    public GameObject BallPrefab;
    public bool BallColision;

    Vector3 BallCollisionPosition;
    float PlayerMoveSpeed = 1.0f;

    void Start()
    {
        BallColision = false;
    }

    
    void Update()
    {
         // クリックしたときにボール発射
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            

            if (Physics.Raycast(ray, out hit))
            {
                GameObject ball = Instantiate(BallPrefab) as GameObject;
                ball.transform.position = transform.position;
                ball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                BallCollisionPosition = hit.point;
            }
        }

        if (BallColision)
        {
            Debug.Log("butukatta" + BallCollisionPosition);
            /*
            //TODO: 下のコードがうまく動かない
            transform.position = Vector3.MoveTowards(transform.position, BallCollisionPosition, PlayerMoveSpeed);
            BallColision = false;
            */
        }
    }
}
