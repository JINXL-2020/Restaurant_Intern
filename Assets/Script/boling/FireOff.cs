using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOff : MonoBehaviour
{
    public Animator pointerAnim;
    // Start is called before the first frame update
    void Start()
    {
        FireOffPointer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //关火
    public void FireOffPointer()
    {
        pointerAnim.SetInteger("step", 6);
        pointerAnim.SetBool("showPointer", true);
    }
}
