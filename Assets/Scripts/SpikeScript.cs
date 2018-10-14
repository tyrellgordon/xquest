using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour {

    private Player Player;

    Collider2D spikeCollider;



    // Use this for initialization
    void Start () {

      
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        spikeCollider = this.GetComponent<Collider2D>();



    }



    public void SpikeUp(){
        spikeCollider.enabled = true;

    }

    public void SpikeDown(){
        spikeCollider.enabled = false;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {   

        if(collision.CompareTag("Player")){


           

                Player.Damage(1);


        }

        
    }

}
