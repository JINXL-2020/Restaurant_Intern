using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//勺子搅拌
public class AnimActivate : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("isStir", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
