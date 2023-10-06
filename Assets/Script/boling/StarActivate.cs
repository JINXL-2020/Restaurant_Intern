using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarActivate : MonoBehaviour
{
    //public int num;
    public GameObject[] star;
    // Start is called before the first frame update
    void Start()
    {
        ShowStar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowStar()
    {
        for (int i = 0; i < star.Length; i++)
            star[i].SetActive(true);
    }
    
}
