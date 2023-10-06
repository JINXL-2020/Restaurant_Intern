using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibimbapPointer : MonoBehaviour
{
    private Animator anim;

    public static int num;
    public GameObject[] vegInBowl;
    public GameObject stars;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        num = 0;
        for (int i = 0; i < vegInBowl.Length; i++)
            vegInBowl[i].SetActive(false);
        stars.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimStep()
    {
        vegInBowl[num].SetActive(true);
        anim.SetInteger("step", ++num);
    }
    public void ShowStars()
    {
        stars.SetActive(true);
    }
}
