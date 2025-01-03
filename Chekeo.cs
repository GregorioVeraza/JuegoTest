using UnityEngine;

public class Chekeo : MonoBehaviour
{
    public static bool isGrounded;

    

    private void OnTriggerEnter2D(Collider2D collission){
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collider2D){
        isGrounded = false;

    }
}
