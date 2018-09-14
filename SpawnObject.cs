using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {
    public GameObject carouselPrefab;
    private Vector3 upCarousel;
    private Vector3 downCarousel;
    private GameObject topCopy;
    private GameObject bottomCopy;

    void Start () {
        upCarousel = new Vector3(0, 2f, 0);
        downCarousel = new Vector3(0, -2f, 0);
	}

    //Spawn carousels on mouse down
    private void OnMouseDown()
    {
        if (gameObject.tag.Equals("top"))
        {
            Destroy(this.gameObject);
            topCopy = Instantiate(carouselPrefab, upCarousel, transform.rotation);
            //View Variable Number of Objects
            topCopy.AddComponent<VariableNumber>();
        }

        if (gameObject.tag.Equals("bottom"))
        {
            Destroy(this.gameObject);
            bottomCopy = Instantiate(carouselPrefab, downCarousel, transform.rotation);
            //Perform Actions
            bottomCopy.AddComponent<OtherActions>();
        }
    }
}
