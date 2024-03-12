using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraviBoots : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
            Physics.gravity = new Vector3(0, -5.0F, 0);
        }
        if(Input.GetKeyDown(KeyCode.Y)){
            Physics.gravity = new Vector3(0, 5.0F, 0);
        }
    }
}
