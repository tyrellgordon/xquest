using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    public AudioClip coinPickUp;
    public AudioClip coinPickUp2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals ("Player")){
            ScoreScript.scoreValue += 10;
            SoundManager.instance.RandomizeSfx(coinPickUp, coinPickUp2);
            Destroy(gameObject);
        }
    }
}
