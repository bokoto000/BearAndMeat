using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMoveScript : MonoBehaviour {
    public float A ;
    public float B ;
    public float speed = 2;
    private float z;
    private float k=0;
    // Use this for initialization
    void Start()
    {
        z = A;

    }

    // Update is called once per frame
    void Update()
    {
        z = transform.position.z;
        if (z <= B) k = 1; 
        if (z >= A) k = 2;
        if(k==1)transform.position += (Vector3.forward) * Time.deltaTime*speed;
        else transform.position -= (Vector3.forward) * Time.deltaTime*speed; 
        // if (min > max) { float x = max; max = min; }
    }
}
