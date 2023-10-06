using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepBtn : MonoBehaviour
{
    //缩放动画
    Animator animator;
    
    AudioSource click;

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        click = GetComponent<AudioSource>();
        
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Selected()
    {
        animator.SetBool("selected", true);
        click.Play();
        showPanel();
        Invoke("Deselected", 0.01f);
    }

    public void showPanel()
    {
        panel.SetActive(true);
    }
    
    public void HidePanel()
    {
        panel.SetActive(false);
    }
    private void Deselected()
    {
        animator.SetBool("selected", false);
    }

    /*public void MouseEnter()
    {
        GetComponent<RectTransform>().sizeDelta = Vector2.one * 0.5f;
        //this.GetComponent<RectTransform>().localScale += Vector3.one * 0.5f;
        print("fangda");
    }*/

}
