using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour,IDropHandler
{
    public Animator enAnimator;
    public Animator pointerAnimator;

    private static int stepCount=1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("drop");
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition 
            = GetComponent<RectTransform>().anchoredPosition;

        enAnimator.SetBool("isInSlot", true);

        pointerAnimator.SetBool("showPointer", false);
        pointerAnimator.SetInteger("step", ++stepCount);
    }
    
}
