using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Dude, we're going to assign player stats to public variables right here.
    public int currentHealth;
    public int maxHealth = 100;

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

    void Die(){
        //restart
        Application.LoadLevel(Application.loadedLevel);
    }
}
