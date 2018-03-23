using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    bool inCamera;
    float speed = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (inCamera)
        {
            transform.GetComponentInChildren<Camera>().fieldOfView = Mathf.Lerp(transform.GetComponentInChildren<Camera>().fieldOfView,30,Time.deltaTime*speed);
        }else if (!inCamera)
        {
            transform.GetComponentInChildren<Camera>().fieldOfView = Mathf.Lerp(transform.GetComponentInChildren<Camera>().fieldOfView, 60, Time.deltaTime*speed);
        }
        if (Input.GetMouseButton(1))
            CallCamera();
        if (Input.GetMouseButtonUp(1))
            inCamera = false;
        if (Input.GetMouseButton(0))
            TakePic();
    }
    void CallCamera()
    {
        inCamera = true;

    }
    void TakePic()
    {

    }
}
