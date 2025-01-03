using UnityEngine;

public class EnemigoPincho : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            Debug.Log("Player Damaged");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}