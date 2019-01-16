using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueloController : MonoBehaviour {
    
    public float speed = 10f;
    private Vector3 newPosition;

    // Use this for initialization
    void Start()
    {
        newPosition = transform.position;

    }


    private void Update()
    {
        newPosition.z = transform.position.z - Time.deltaTime * speed;
        transform.position = newPosition;

    }

}
