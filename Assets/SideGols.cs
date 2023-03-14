using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideGols : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.name == "Bola")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
