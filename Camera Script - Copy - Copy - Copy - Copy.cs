using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public float panSpeed = 20f;
    public float panBorderThickness = 10f;
    // the speed will run when afloat :)


    // Update is called once per frame
    void Update()
    {

    Vector3 pos = transform.position;
    // Forward key
    if (Input.GetKey("W")|| Input.mousePosition.y >= Screen.height - panBorderThickness ) {

        pos.z += panSpeed * Time.deltaTime;
    }
    // Backward key
    if (Input.GetKey("S")|| Input.mousePosition.y <= panBorderThickness ) {

        pos.z -= panSpeed * Time.deltaTime;
    }
    // Left key
    if (Input.GetKey("D")|| Input.mousePosition.y >= Screen.width - panBorderThickness ) {

        pos.x += panSpeed * Time.deltaTime;
    }
    // Right key
    if (Input.GetKey("A")|| Input.mousePosition.y <= panBorderThickness ) {

        pos.x -= panSpeed * Time.deltaTime;
    }


transform.position = pos;

}

}

