using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FruitManage : MonoBehaviour
{
    public Text levelCleared;
    private void Update(){
       AllFruitsCollected(); 
    }
    public void AllFruitsCollected(){
        if (transform.childCount==0){
            Debug.Log("No hay mas frutas. Victoria");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }
    void ChangeScene(){
        Scene escActual = SceneManager.GetActiveScene();
        if (escActual.name != "Nivel2"){
        SceneManager.LoadScene(escActual.buildIndex + 1);
        } else {
            SceneManager.LoadScene("Menu");
        }
    }
}