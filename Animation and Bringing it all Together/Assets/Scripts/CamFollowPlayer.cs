using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour{

    public Transform player;

    // Update is called once per frame
    void Update(){
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z);
    }
}
