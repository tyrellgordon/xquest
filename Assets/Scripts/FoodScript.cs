using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour {

    public AudioClip foodPickUp;
    public AudioClip foodPickUp2;

    private Player player;

    // Use this for initialization
    void Start()
    {
         player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            player.currentHealth += 1;
            SoundManager.instance.RandomizeSfx(foodPickUp, foodPickUp2);
            Destroy(gameObject);
        }
    }
}
