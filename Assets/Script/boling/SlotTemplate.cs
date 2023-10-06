using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotTemplate : MonoBehaviour,IDropHandler
{
    public Animator pointerAnimator;
    public Animator crabStickAnimator;

    public static int stepCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition 
            = GetComponent<RectTransform>().anchoredPosition;
        crabStickAnimator.SetBool("isInSlot", true);
        
        stepCount++;
        if (pointerAnimator.GetInteger("step")>2 && stepCount % 3 == 0)
        {
            pointerAnimator.SetInteger("step", ++SushiStepContrller.num);
        }
        //pointerAnimator.SetBool("showPointer", false);
        //pointerAnimator.SetInteger("step", ++stepCount);
    }
    
}
