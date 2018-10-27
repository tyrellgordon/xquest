using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelScript : MonoBehaviour {

    public AudioClip jewelPickUp;
    public AudioClip jewelPickUp2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            ScoreScript.scoreValue += 100;
            SoundManager.instance.RandomizeSfx(jewelPickUp, jewelPickUp2);
            Destroy(gameObject);
        }
    }
}
