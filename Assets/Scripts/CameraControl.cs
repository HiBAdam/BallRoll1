using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
// initialize 
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
    // initialize the offset between player and camera
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called at the end of the frame
    void LateUpdate()
    {
    // change camera position correctly as one moves every frame 
        transform.position = player.transform.position + offset;
    }
}
