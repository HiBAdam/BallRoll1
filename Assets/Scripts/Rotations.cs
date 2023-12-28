using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotations : MonoBehaviour
{
// initialize rotations of different axes
  public float rotateX;
  public float rotateY;
  public float rotateZ;

    // Update is called once per frame
    void Update()
    {
    // rotate. if you do not multiply by Time.deltaTime, it will do this every single frame. so change to real time
        transform.Rotate(new Vector3(rotateX,rotateY,rotateZ)*Time.deltaTime);
    }
}
