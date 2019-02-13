using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour{

	public Camera cam1;
	public Camera cam2;
    
    void OnTriggerEnter(Collider other){
    	//check for player colliding
        if (other.gameObject.CompareTag("Player")){
        	//check what cam is on, and switch to the other
            if (cam1.enabled){
            	cam2.enabled = true;
            	cam1.enabled = false;
            } else {
            	cam2.enabled = false;
            	cam1.enabled = true;
            }
        }
    }
}
