using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigMovement : MonoBehaviour {

    public Transform RefPoint2;
    public Transform RefPoint;

    public float xspeed = 1f;
    public float yspeed = -1f;
    // Use this for initialization
    bool Switch = false;
	void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
       

        if (Switch == false)
        {
            Debug.Log("cool");
            this.transform.position += new Vector3(xspeed, yspeed, 0) * Time.deltaTime;
        }
      
        if(this.transform.position.x >= RefPoint2.transform.position.x)
        {
            Switch = true;
        }

        if (Switch == true)
        {
            Debug.Log("awesome");
            this.transform.position = new Vector3(-10, this.transform.position.y, 0);
            Switch = false;
        }
	}
}
