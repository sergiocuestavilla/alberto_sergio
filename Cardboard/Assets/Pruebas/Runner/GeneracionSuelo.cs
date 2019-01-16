using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneracionSuelo : MonoBehaviour {

    public GameObject suelo;

	// Use this for initialization
	void Start () {

        InvokeRepeating("crearSuelo", 0f, 2f);
    }
	
	// Update is called once per frame
	void Update () {

    }

    void crearSuelo()
    {
        Instantiate(suelo, this.transform.position, Quaternion.identity);
    }

}
