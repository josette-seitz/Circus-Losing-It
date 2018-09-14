using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VariableNumber : MonoBehaviour {
    private GameObject textMesh;

    //spawn another carousel with a variable number of objects
    void Start()
    {
        textMesh = GameObject.FindGameObjectWithTag("count");
        int carouselCount = gameObject.transform.childCount;
        TextMeshPro text = textMesh.GetComponent<TextMeshPro>();
        text.SetText("There are " + carouselCount + " Objects in this Carousel");
    }
}
