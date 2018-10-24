using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    // Dude, we're going to assign player stats to public variables right here.
    public static string playerName = "Tyrell";
    public int currentHealth;
    public int maxHealth = 5;

   
    public AudioClip gameOverSound;


    private string url = "http://localhost:3001/users";


    // Use this for initialization
    void Start () {
        SoundManager.instance.musicSource.Play();
        currentHealth = maxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if(currentHealth <= 0){
            // send post request upon player death, bruh
            WWWForm sendStats = new WWWForm();
            sendStats.AddField("name", playerName);
            sendStats.AddField("score", ScoreScript.scoreValue);

            WWW www = new WWW(url, sendStats);


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
        SoundManager.instance.musicSource.Stop();
        SceneManager.LoadScene("start_menu");
    }
}
