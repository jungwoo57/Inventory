using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveInventory : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public GameObject inventory;
    public Vector2 offset;
    public Vector2 curPosition;
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        curPosition = eventData.pressPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
       if (eventData.position != curPosition)
       {
           offset = eventData.position - curPosition;
           Vector2 pos = new Vector2(inventory.transform.position.x, inventory.transform.position.y);
           inventory.transform.position = new Vector2(pos.x + offset.x, pos.y + offset.y);
           curPosition = new Vector2(curPosition.x + offset.x, curPosition.y + offset.y);
       }
    }

   
}
