using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStopButton : MonoBehaviour
{
    public bool Rotate = true;
    
    public Animator Cube;
    public bool InTrigger;
    public Animator Button;
    
    void Update(){
        if(InTrigger){
        if(Input.GetKeyDown(KeyCode.E)){
          Button.SetBool("Click", true);
          if(Rotate){
           Rotate = false;
          
          Cube.StopPlayback();
          }else{
           Rotate = true;
          
          Cube.StartPlayback();
          }
          
        
        
          Button.SetBool("Click", false);
        }
        }
    }
    private void OnTriggerStay(Collider other)
    {
         if(other.tag == "Player"){
       InTrigger = true;
        
    }}
    private void OnTriggerExit(Collider other) {
         if(other.tag == "Player"){
        InTrigger = false;
    }}
}
