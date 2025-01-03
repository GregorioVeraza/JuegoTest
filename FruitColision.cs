using UnityEngine;

public class FruitColision : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D colission){
        if (colission.CompareTag("Player")){//chequea si el objeto con el tag Player es el que colisiono
            GetComponent<SpriteRenderer>().enabled = false;//desactiva el render del objeto
            gameObject.transform.GetChild(0).gameObject.SetActive(true); //activa la animacion

             Destroy(gameObject, 0.5f);//destruye el objeto junto con su hijo
        }
    }
}
