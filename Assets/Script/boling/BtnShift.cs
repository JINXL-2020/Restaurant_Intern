using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//控制开关火
public class BtnShift : MonoBehaviour
{
    AudioSource shift;
    private bool isOn;
    
    public Animator fireAnimator;
    public Animator pointerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        shift = GetComponent<AudioSource>();
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnAndOff()
    {
        shift.Play();
        if (!isOn)
        {
            isOn = true;
            fireAnimator.SetBool("on", true);
            GetComponent<RectTransform>().anchoredPosition += Vector2.right * 50f;
            
            pointerAnimator.SetBool("showPointer", false);
            Invoke(nameof(PointerAnim), 0.5f);
        }
        else
        {
            isOn = false;
            fireAnimator.SetBool("on", false);
            GetComponent<RectTransform>().anchoredPosition -= Vector2.right * 50f;
        }
    }

    void PointerAnim()
    {
        pointerAnimator.SetBool("showPointer", true);
        pointerAnimator.SetInteger("step", 1);
    }
}
