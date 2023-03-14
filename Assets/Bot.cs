using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public GameObject bola;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        bola = GameObject.FindWithTag("Ball");
        var vel = rb2d.velocity;
        //robo
        var yrobo = rb2d.transform.position.y; 
        var xrobo = rb2d.transform.position.x;
        //bola
        var xbola = bola.transform.position.x;
        var ybola = bola.transform.position.y;
        var vel_max = 2.5f;
        if(xbola > 0){

            if(yrobo < ybola){
                vel.y = vel_max;
            }

            else if(yrobo > ybola){
                vel.y = -vel_max;
            }

            
            if(xrobo < xbola){
                vel.x = vel_max;
            }

            else if(xrobo > xbola){
                vel.x = -vel_max;
            }

            
        

        } else {
            if(yrobo < 0.1f){
                vel.y = vel_max;
            }

            else if(yrobo > -0.1f){
                vel.y = -vel_max;
            }
            
            else{
                vel.y = 0;
            }

            if(xrobo < 8f){
                vel.x = vel_max;
            }

            else if(xrobo > 7.5f){
                vel.x = -vel_max;
            }

            else{
                vel.x = 0;
            }
        }


        var pos = transform.position;

            if (pos.y > 4)
            {
                pos.y = 4;
            }
            else if (pos.y < -4)
            {
                pos.y = -4;
            }

            if( pos.x > 10){
                pos.x = 10;
            } 
            else if (pos.x < 10-10){
                pos.x = 10-10;
            }
            transform.position = pos;

        rb2d.velocity = vel;

    }
}
