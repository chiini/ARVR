using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{
    public GameObject Canvas;

    private GameObject zoomCard;

    void Start()
    {
        Canvas = GameObject.Find("Main Canvas");
    }

    public void onHoverEnter() 
    {
        zoomCard = Instantiate(gameObject, new Vector2(Input.mousePosition.x, Input.mousePosition.y + 150), Quaternion.identity);
        zoomCard.transform.SetParent(Canvas.transform, false);
        zoomCard.layer = LayerMask.NameToLayer("Zoom");

        RectTransform rect = zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(147, 216);
    }

    public void onHoverExit() 
    {
        Destroy(zoomCard);
    }

    void Update()
    {
        
    }
}
