using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miprimercodigo : MonoBehaviour
{
    public GameObject micubo;
    public GameObject misphera; 

    public object Cube { get; private set; }
    public object Sphere { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
       // = GameObject.Find("Cube");
        micubo.transform.position = new Vector3(2, 1, 0);
        micubo.transform.position = new Vector3(80,45,30);

        // = GameObject.Find("Sphere");
        misphera.transform.position = new Vector3(0, 0, 0);
        misphera.transform.position = new Vector3(3,3,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
