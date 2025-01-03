using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OpenDoor : MonoBehaviour
{
public Text text;
public string levelName;
private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D colission){
        if(colission.transform.CompareTag("Player")){
            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D colission){
        if(colission.transform.CompareTag("Player")){
            text.gameObject.SetActive(false);
            inDoor = false;
        }
    }
    private void Update(){
        if(inDoor && Input.GetKey("e")){
            SceneManager.LoadScene(levelName);
            Debug.Log($"nivel {levelName}");
        }
        
    }
}
