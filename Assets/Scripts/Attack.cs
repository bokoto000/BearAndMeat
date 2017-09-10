using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    private Vector3 targeted;
    public int speed=75;
	// Use this for initialization
	void Start () {
        targeted = GameObject.Find("Player").transform.position;
        //var distance = Vector3.Distance(transform.position, targeted);
    }
	
	// Update is called once per frame
	void Update () {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targeted,step);
        if (transform.position.y <= 6) Destroy(this.gameObject);
    }
}
