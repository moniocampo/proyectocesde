using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Capsule : MonoBehaviour
{
    public float speed;
    public Rigidbody rigid;
    public float jumpforce;

    public GameObject agent;

    //update is called once per frame
    void Update()
    {
        Move();
        Jump();
        CheckGameOver();
    }

    void Move()
    {
        float V = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float H = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(H, 0, V);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpforce * Time.deltaTime, ForceMode.Impulse);
        }
    }
    void CheckGameOver()
    {
        if (transform.position.y < -9)
        {
            rigid.AddForce(Vector3.up * jumpforce * Time.deltaTime, ForceMode.Impulse);
            transform.position = new Vector3(-1.7f, 1.7f, 0);
        }
    }
}


    

