using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiStepContrller : MonoBehaviour
{
    private Animator anim;
    private AudioSource sound;

    public static int num = 0;
    public Animator bambooStickAnim;
    public Animator noriAnim;
    public GameObject scoopUp;
    public Animator sauceAnim;
    public GameObject sauceImage;
    public Animator bambooStickAnim2;
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;
    public Animator sushiWhiteAnim;
    public GameObject knife;
    public Animator knifeAnim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        scene2.SetActive(false);
        scene3.SetActive(false);
        scene4.SetActive(false);
        knife.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickOnBambooStick()
    {
        bambooStickAnim.SetBool("isOn", true);
        if(num==0)
            anim.SetInteger("step", ++num);
    }
    public void ClickOnBambooStick2()
    {
        bambooStickAnim2.SetBool("isWrapup", true);
        anim.SetInteger("step", ++num);
    }
    public void ClickOnNori()
    {
        noriAnim.SetBool("isOn", true);
        if (num == 1)
            anim.SetInteger("step", ++num);
    }
    public void ClickOnRice()
    {
        scoopUp.SetActive(true);
        if (num == 2)
            anim.SetInteger("step", ++num);
    }
    public void ClickOnSauce()
    {
        sauceAnim.SetBool("isOn", true);
        sauceImage.SetActive(true);
        if (num == 5)
            anim.SetInteger("step", ++num);
    }
    public void ClickToNext()
    {
        if(anim.GetInteger("step")==6)
        {
            scene1.SetActive(false);
            scene2.SetActive(true);
            anim.SetInteger("step", ++num);
        }
        else if (anim.GetInteger("step") == 8)
        {
            scene2.SetActive(false);
            scene3.SetActive(true);
            anim.SetInteger("step", ++num);
        }
        else if (anim.GetInteger("step") == 11)
        {
            scene3.SetActive(false);
            scene4.SetActive(true);
            anim.SetInteger("step", ++num);
            sound.Play();
        }
    }
    public void ClickOnSushi()
    {
        sushiWhiteAnim.SetBool("isOn", true);
        anim.SetInteger("step", ++num);
        knife.SetActive(true);
    }
    public void ClickOnKnife()
    {
        knifeAnim.SetBool("isOn", true);
        sushiWhiteAnim.SetBool("isCut", true);
        anim.SetInteger("step", ++num);
    }
}
