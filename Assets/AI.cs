using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
    private int health;
	// Use this for initialization
	void Start () {
        health = 100;

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 enemy=GameObject.Find("Player").transform.position;

    }
}
