using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        scene++;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            SceneManager.LoadScene(scene);
        }
    }
}
