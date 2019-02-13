using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaControl : MonoBehaviour{

	CharacterController controller;
	private float speed = 5f;
	private float gravity = -0.2f;
    private Vector3 movement;
    
    // Start is called before the first frame update
    void Start(){
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){
    	//check if on the ground
        if (controller.isGrounded){
        	movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        	movement = transform.TransformDirection(movement);
        } else {
        	//gravity
        	movement.y += gravity;
        }
        //Q and E rotate the player
        if (Input.GetKey(KeyCode.Q)){
        	transform.Rotate(new Vector3(0, -120, 0) * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.E)){
        	transform.Rotate(new Vector3(0, 120, 0) * Time.deltaTime);
        }
        //move
        controller.Move(movement * speed * Time.deltaTime);
    }
}
