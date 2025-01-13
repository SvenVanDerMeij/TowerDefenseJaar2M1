using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTowers : MonoBehaviour
{
    public bool pickedUp = false;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if (pickedUp == true)
        {
            transform.position = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        }
        if (Input.GetMouseButtonDown(0) && pickedUp == true)
        {
            pickedUp = false;
            TowerButton.mousefull = false;
        }
    }
}
