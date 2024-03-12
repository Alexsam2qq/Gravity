using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveGun : MonoBehaviour
{
    public GameObject Gun; // объект который мы будем брать
    public GameObject GunWitchPlayer ; // объект который открывается у игрока
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E) && other.tag == "Player"){
            Gun.SetActive(false);
            GunWitchPlayer.SetActive(true);
        }
    }
}
