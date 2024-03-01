using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class variables : MonoBehaviour
{
    public string name = "Monica";
    public int age = 19;
    public float height = 1.65f;
    public string birthdate = "24 de diciembre del 2004";
    public int CC = 1033426324;
    public float number = 3208597979f;

    void Start()
    {
        print(name + age + height + birthdate + CC + number);
    }
    public GameObject agent;
      
         //start is called before the first frame update
     

    //update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("arriba");
            agent.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("Abajo");
            agent.transform.localEulerAngles = new Vector3(180, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("Derecha");
            agent.transform.localEulerAngles = new Vector3(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("Izquierda");
            agent.transform.localEulerAngles = new Vector3(0, -90, 0);
        }
    }


}