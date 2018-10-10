using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour {

    private Player Player;


	// Use this for initialization
	void Start () {

        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

		
	}

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){

            Player.Damage(1);
        }
    }
}
