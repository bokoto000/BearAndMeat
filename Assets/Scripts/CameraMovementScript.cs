using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour {
    public float speed = 3;

    private float mouseX;
    private float mouseY;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mouseX = Input.GetAxis("Mouse X") * speed;
        mouseY = Input.GetAxis("Mouse Y") * speed;
	}

    private void FixedUpdate()
    {
         //Debug.Log("Mouse X " + mouseX);

        transform.Rotate(mouseY*-1, mouseX,0);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
    }
}
