using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public Animator transitionAnim;
    public int transitionTime;
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance== null){
            instance =this;
        }
        Time.timeScale=1f;
    }
    public void gameOver(){

        gameOverCanvas.SetActive(true);
        
        Time.timeScale=0f; 
       
    }
    IEnumerator restartGame(){
        
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    // Update is called once per frame
    void Update()
    {
        if(gameOverCanvas.activeSelf==true){
             if(Input.GetKey("space")){
                StartCoroutine(restartGame());
        }
        }

            
        
    }
}
