using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookFood : MonoBehaviour
{
    public float cookingTime = 0;

    //public Animator pointerAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cookingTime += Time.deltaTime;
        if (cookingTime > 2 && cookingTime < 4)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 0.9f, 0.9f);
        }
        if (cookingTime > 4 && cookingTime < 6)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 0.8f, 0.8f);
        }
        if (cookingTime > 6)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 0.6f, 0.6f);
        }
    }

    private void OnMouseDown()
    {
        //print(BinControl.pos);
        if (cookingTime > 6 && GamePlay.grillS1 == "full" && BinControl.pos > -0.9)
        {
            GetComponent<Transform>().position = new Vector2(-2.5f, BinControl.pos);
            BinControl.pos += 0.3f;
            GamePlay.grillS1 = "empty";
            BinControl.pointerAnim.SetInteger("step", ++BinControl.step);//step=4
            print("BinControl.step"+BinControl.step);
        }
    }
}
