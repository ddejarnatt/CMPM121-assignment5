using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehavior : MonoBehaviour{
	public Animator door;
	public GameObject doorname;
	public GameObject pSys;

    void OnTriggerEnter(Collider other){
        pSys.SetActive(true);
        if (other.gameObject.CompareTag("Player")){
            this.gameObject.SetActive(false);
            if (doorname.tag == "Door2"){
            	door.Play("OpenDoor2", 0, 0);
            } else {
            	door.Play("OpenDoor", 0, 0);
            }
        }
    }
}
