using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartSystem : MonoBehaviour {
    public List<Transform> trackNodes;
    int curNode;
    bool running;
    public float speed;
	// Use this for initialization
	void Start () {
        //speed = 1;
        running = false;
        curNode = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
            running = !running;

        if (running)
        {
            transform.parent.parent.parent.position = Vector3.MoveTowards(transform.parent.parent.parent.position, trackNodes[curNode].position, Time.deltaTime * speed);
            transform.parent.parent.parent.rotation = Quaternion.RotateTowards(transform.parent.parent.parent.rotation, trackNodes[curNode].rotation, Time.deltaTime * (speed*1.2f));
        }
	}
    public void goToNextNode()
    {
        if((curNode+1) < trackNodes.Count)
            curNode++;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tracknode")
        {
            print("going to node " + (curNode + 1));
            goToNextNode();
        }
    }
}
