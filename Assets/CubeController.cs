﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private float speed = -12;

    private float deadLine = -10;

    private AudioSource sound01;

    // Use this for initialization
    void Start () {
        sound01 = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if(transform.position.x < this.deadLine )
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag == "ground" || other.gameObject.tag == "Cube")
        {
            sound01.PlayOneShot(sound01.clip);
        }
        
    }
}
