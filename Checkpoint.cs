using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class Checkpoint : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            collision.GetComponent<PlayerRespawn>().ReachedCheckPoint(transform.position.x, transform.position.y);
            GetComponent<Animator>().enabled = true;
        }
    }
}