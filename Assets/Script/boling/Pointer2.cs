using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer2 : MonoBehaviour
{
    public GameObject jiang;
    public GameObject veg;
    public GameObject vege;
    public GameObject stars;

    private Animator anim;
    private AudioSource congrats;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        congrats = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetFloat("step") == 1)
        {
            ShowJiang();
            anim.SetFloat("step", 1.5f);
        }
        else if (anim.GetFloat("step") == 2)
        {
            ShowVeg();
            anim.SetFloat("step", 2.5f);
        }
    }
    
    public void ShowJiang()
    {
        jiang.SetActive(true);
    }
    public void ShowVeg()
    {
        veg.SetActive(true);
        vege.SetActive(false);
        stars.SetActive(true);
        congrats.Play();
    }

    public void Step1()
    {
        anim.SetFloat("step", 1f);
    }
    public void Step2()
    {
        anim.SetFloat("step", 2f);
    }
}
