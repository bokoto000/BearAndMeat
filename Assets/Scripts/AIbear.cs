using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIbear : MonoBehaviour {
    private int health;
    public GameObject shot;
    public GameObject shot1;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;
    public float distanced;
    public float bulletspeed;
    public AudioClip roar;
    public AudioSource source;
    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 enemy=GameObject.Find("Player").transform.position;
        var distance = Vector3.Distance(transform.position, GameObject.Find("Player").transform.position);
        if ( Time.time > nextFire&&distance<200)
        {
            
            if(distance<distanced) nextFire = Time.time + fireRate/2;
            else nextFire = Time.time + fireRate;
            if (Random.Range(1, 5) == 1)
            {
                source.PlayOneShot(roar, 1F);
                Instantiate(shot1, shotSpawn.position, shotSpawn.rotation);
            }
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
