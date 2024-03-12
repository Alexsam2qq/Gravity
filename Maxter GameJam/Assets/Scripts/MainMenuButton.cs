using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public bool End;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(End){
             SceneManager.LoadScene(0);
        }
    }

    public void StartGame(){
     SceneManager.LoadScene(1);
    }
    public void ExitGame(){
        Application.Quit();
    }
    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
