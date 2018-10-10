﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Dude, we're going to assign player stats to public variables right here.
    public int currentHealth;
    public int maxHealth = 5;

	// Use this for initialization
	void Start () {

        currentHealth = maxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if(currentHealth <= 0){
            Die();
            ScoreScript.scoreValue = 0;
        }
	}

    // needs to be public for other scripts to see this funtion, bruh
    public void Damage(int dmg){

        currentHealth -= dmg;

    }


    void Die(){
        //restarts the game bruh
        Application.LoadLevel(Application.loadedLevel);
    }
}
