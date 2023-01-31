using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzlePlayPartSample : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{

    private bool MouseOnObj = false;
    private RaycastHit hit;



    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        
    }
}
