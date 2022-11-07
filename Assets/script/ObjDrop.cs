using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("1");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("3");
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Debug.Log("4");
    }

    


}



