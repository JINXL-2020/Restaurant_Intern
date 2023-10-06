using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinControl : MonoBehaviour
{
    public Transform bottombunObj;
    public Transform topbunObj;
    public Transform burgerObj;
    public Transform beefObj;
    public Transform leafObj;
    public Transform cheeseObj;
    public Transform eggObj;

    public static float pos = -1f;

    public static Animator pointerAnim;
    public static int step = 1;
    // Start is called before the first frame update
    void Start()
    {
        pointerAnim = GameObject.FindGameObjectsWithTag("pointer")[0].GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(pointerAnim.GetInteger("step"));
    }

    private void OnMouseDown()
    {
        if (pos < -0.9 && gameObject.name== "bread below" && GamePlay.cuttingboardS1 == "empty")
        {
            Instantiate(bottombunObj, new Vector2(-2.5f, -1), bottombunObj.rotation);
            GamePlay.cuttingboardS1 = "full";
            pos += 0.3f;
            pointerAnim.SetInteger("step", ++step);//step=2

            /*if (GamePlay.cuttingboardS1 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(-3, -1), bottombunObj.rotation);
                GamePlay.cuttingboardS1 = "full";
            }
            else if(GamePlay.cuttingboardS2 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(0, -1), bottombunObj.rotation);
                GamePlay.cuttingboardS2 = "full";
            }
            else if (GamePlay.cuttingboardS3 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(3, -1), bottombunObj.rotation);
                GamePlay.cuttingboardS3 = "full";
            }*/
        }
        else if (pos > -0.9)
        {
            if (gameObject.name == "eggs")
            {
                Instantiate(eggObj, new Vector2(-2.5f, pos), eggObj.rotation);
                pos += 0.1f;
                pointerAnim.SetInteger("step", ++step);//step=5
            }
            if (gameObject.name == "leaves")
            {
                Instantiate(leafObj, new Vector2(-2.5f, pos), leafObj.rotation);
                pos += 0.3f;
                pointerAnim.SetInteger("step", ++step);
            }
            if (gameObject.name == "cheese")
            {
                Instantiate(cheeseObj, new Vector2(-2.5f, pos), cheeseObj.rotation);
                pos += 0.3f;
                pointerAnim.SetInteger("step", ++step);
            }
            if (gameObject.name == "bread above")
            {
                Instantiate(topbunObj, new Vector2(-2.5f, pos), topbunObj.rotation);
                pos += 0.3f;
                pointerAnim.SetInteger("step", ++step);
            }
        }
        


        if (gameObject.name == "beef" && GamePlay.grillS1=="empty")
        {
            Instantiate(beefObj, new Vector2(3f, -1.45f), beefObj.rotation);
            GamePlay.grillS1 = "full";
            pointerAnim.SetInteger("step", ++step);//step=3
        }
    }
}
