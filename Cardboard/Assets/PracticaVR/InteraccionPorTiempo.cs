﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionPorTiempo : MonoBehaviour {

	
	public float limiteTiempo = 2f;
	private float tiempo;

	// Use this for initialization
	void Start () {

		tiempo = Mathf.Infinity;
		
	}


	// Update is called once per frame
	void Update () {

		if(Time.time - tiempo > limiteTiempo){
            if (this.CompareTag("Tomate")) 
            {
                interaccion();
            }
			 
		} 
	}


	public void activa(bool activado){

		if(activado){
			
			Debug.Log("Activado");

			tiempo = Time.time;
		}

		else{
			
			Debug.Log("Desactivado");	

			tiempo = Mathf.Infinity;
		}

	}


	public void interaccion(){

        //generamos una posición aleatoria en una esfera envolvente de radio 1
        Vector3 nuevaPosicion = Random.onUnitSphere;

        //lo alejamos una distancia de nosotros
        float distancia = 3 * Random.value + 3f;
        nuevaPosicion *= distancia;

        //restringimos la altura
        nuevaPosicion.y = Random.Range(0f, 1.5f);

        //asignamos la posicion
        transform.localPosition = nuevaPosicion;

        Debug.Log("Interaccion");
    }

}