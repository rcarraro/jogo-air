using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private bool cima;
    private int vida; 
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if(gameObject.tag == "paddle2"){
            cima = true;
        } else {
            cima = false;
        }
        vida = 10;
    }

    void OnCollisionEnter2D (Collision2D coll) {
    	if(coll.collider.CompareTag("Ball")){
            vida -= 1;
        }
        if(vida == 0){
            Destroy(gameObject);
        }
	}

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        var vel_max = 1;
        if(rb2d.transform.position.y >= 4){
            cima = !cima;
        } 
        
        if(rb2d.transform.position.y <= -4){
            cima = !cima;
        } 
        if(cima){
            vel.y = vel_max;
        } else {
            vel.y = -vel_max;
        }


        rb2d.velocity = vel;
    }
}
