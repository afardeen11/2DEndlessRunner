using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float offsetSmoothing;
    private Vector3 playerPosition;
 
     void Start()
     {

     }
     
     void Update () {
 
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        playerPosition = new Vector3(playerPosition.x + offset, playerPosition.y, playerPosition.z);
        transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);

         
     }
}
