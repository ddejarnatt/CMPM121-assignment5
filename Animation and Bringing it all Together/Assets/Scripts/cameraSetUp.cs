using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSetUp : MonoBehaviour{
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
    // Start is called before the first frame update
    void Start(){
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }
}
