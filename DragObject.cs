using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour {
    private GameObject parentObj = null;
    private Rigidbody rb;

	void Start () {
        parentObj = this.transform.parent.gameObject;
        rb = parentObj.GetComponent<Rigidbody>();
	}

    private void OnMouseDrag()
    {
        //drag carousel left or right
        float drag = Input.GetAxis("Mouse X");
        if(drag < 0)
        {
            parentObj.transform.Rotate(-Vector3.up * (100 * Time.deltaTime));
        }
        if(drag > 0)
        {
            parentObj.transform.Rotate(Vector3.up * (100 * Time.deltaTime));
        }
    }

    private void OnMouseUp()
    {
        //add a little momentum on y axis
        rb.AddTorque(new Vector3(0, 1f, 0));
    }
}
