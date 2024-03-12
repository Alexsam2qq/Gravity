using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levl2 : MonoBehaviour
{
    public string TagKasanie;
    public bool Main;
    public int Kolvo;
    public Animator Door;
    public Levl2 L;
    public int MaxBox = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Kolvo == MaxBox && Main){
         Door.SetBool("open", true);
        }else if(Kolvo < 3 && Main){
            //Door.SetBool("open", false);
        }
    }
    void OnTriggerEnter(Collider other) {
        if(other.tag == TagKasanie){
         if(Main){
            Kolvo++;
         }else{
            L.Kolvo++;
         }

        }
    }
    void OnTriggerExit(Collider other) {
        if(other.tag == TagKasanie){
         if(Main){
            Kolvo--;
         }else{
            L.Kolvo--;
         }

        }
    }
}
