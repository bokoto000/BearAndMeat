using UnityEngine;
using System.Collections;

public class RotateSujuk : MonoBehaviour
{
    public float speed = 10.0f;
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime*speed);
    }
}