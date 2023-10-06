using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragByInterfaceTemplate : MonoBehaviour, IDragHandler,IBeginDragHandler,IEndDragHandler
{
    public GameObject slot;
    //public Animator pointerAnimator;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Animator animator;

    private void Start()
    {
        slot.SetActive(false);
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        animator = GetComponent<Animator>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        animator.enabled = false;

        //pointerAnimator.SetBool("showPointer", false);
    }

    public void OnDrag(PointerEventData eventData)
    {
        slot.SetActive(true);
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        slot.SetActive(false);
        canvasGroup.blocksRaycasts = true;
        animator.enabled = true;

        //pointerAnimator.SetBool("showPointer", true);
    }


}
