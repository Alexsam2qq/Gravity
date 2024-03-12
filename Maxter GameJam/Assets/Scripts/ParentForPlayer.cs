using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentForPlayer : MonoBehaviour
{
    
    public GameObject Player;
    public GameObject CurrentObject;


    private void OnTriggerEnter(Collider other)
    {
        CurrentObject = other.gameObject;
        Player.transform.parent = CurrentObject.transform;
    }
    private void OnTriggerExit(Collider other) {
        
        CurrentObject = null;
        Player.transform.parent = null;
    }
}
