using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieInVoid : MonoBehaviour
{
    public float DieVoidDistance;
    public GameObject Spawn;
    
    private void OnTriggerStay(Collider other){
        other.gameObject.transform.position = Spawn.transform.position;
    }
  
}
