using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherActions : MonoBehaviour {

	//Add different action to spawn carousel
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.Translate(0, (Time.deltaTime * -10f), 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.Translate(0, (Time.deltaTime * 10f), 0);
        }
    }
}
