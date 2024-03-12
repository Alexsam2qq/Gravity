using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraviGun : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float maxGrabDistance = 10f, throwForce = 20f, lerpSpeed = 10f;
    [SerializeField] Transform objectHolder;
    public float rotationSpeed;
 
    Rigidbody grabbedRB;
    public bool X;
    public bool Y;
    public bool Z;
 
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Alpha1)){
                X = true;
                Z = false;
           Y = false;
            }
            if(Input.GetKeyDown(KeyCode.Alpha2)){
                Y = true;
                Z = false;
                X = false;
            }
            if(Input.GetKeyDown(KeyCode.Alpha3)){
                Z = true;
                X= false;
            Y = false;
            }
        if(grabbedRB)
        {
            
            if(Input.GetKey(KeyCode.R)){
                if(X){
                    grabbedRB.gameObject.transform.Rotate(Time.deltaTime * rotationSpeed, 0, 0);

                }
                if(Y){
                    grabbedRB.gameObject.transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);
                }
                if(Z){
                    grabbedRB.gameObject.transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);
                }
                
                grabbedRB.gameObject.transform.position = objectHolder.transform.position;
            }
            grabbedRB.MovePosition(Vector3.Lerp(grabbedRB.position, objectHolder.transform.position, Time.deltaTime * lerpSpeed));
            
            if(Input.GetMouseButtonDown(0))
            {
                grabbedRB.isKinematic = false;
                grabbedRB.AddForce(cam.transform.forward * throwForce, ForceMode.VelocityChange);
                grabbedRB = null;
            }
        }
 
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(grabbedRB)
            {
                grabbedRB.isKinematic = false;
                grabbedRB = null;
            }
            else
            {
                RaycastHit hit;
                Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
                if(Physics.Raycast(ray, out hit, maxGrabDistance))
                {
                    grabbedRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if(grabbedRB)
                    {
                        grabbedRB.isKinematic = true;
                    }
                }
            }
        }
    }
}
