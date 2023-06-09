using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    // void OnCollisionEnter2D (Collision2D coll) {
    // 	if(coll.collider.CompareTag("ParedeDireita")){
    //     	vel.x = rb2d.velocity.x;
    //     	vel.y = rb2d.velocity.y;
    //     	rb2d.velocity = vel;
    // 	}else if(coll.collider.CompareTag("ParedeEsquerda")){
    //         vel.x = rb2d.velocity.x;
    //     	vel.y = rb2d.velocity.y;
    //     	rb2d.velocity = vel;
    //     }else if(coll.collider.CompareTag("ParedeCima")){
    //         vel.x = rb2d.velocity.x;
    //     	vel.y = rb2d.velocity.y;
    //     	rb2d.velocity = vel;   
    //     }else if(coll.collider.CompareTag("ParedeBaixo")){
    //         vel.x = rb2d.velocity.x;
    //     	vel.y = rb2d.velocity.y;
    //     	rb2d.velocity = vel;
    //     }
	// }

	// void update(){
	// 	vel.x = rb2d.velocity.x;
	// 	vel.y = rb2d.velocity.y;
	// 	rb2d.velocity = vel;
	// }

    void GoBall(){
    	rb2d.AddForce(new Vector2(-40, 0));
	}

    void ResetBall(){
    	rb2d.velocity = Vector2.zero;
        transform.position = new Vector2(0, 0);
	}

	void RestartGame(){
    	ResetBall();
    	Invoke("GoBall", 1);

	}
}
