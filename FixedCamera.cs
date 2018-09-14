using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour {

    private void Awake()
    {
        //Camera stays at 0,0,0
        Camera.main.transform.position = Vector3.zero;
    }
}
