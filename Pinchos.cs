using UnityEngine;

public class Pinchos : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            Debug.Log("Player Damaged");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            
        }
    }
}
