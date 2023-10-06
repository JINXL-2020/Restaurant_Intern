using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CutUpVegetable : MonoBehaviour
{
    public Animator cucumberAnimator;
    public Animator carrotAnimator;
    public Animator meatAnimator;
    public Animator onionAnimator;
    public Animator xiangcaiAnimator;

    public Animator pointerAnimator;
    public Animator knifeAnimator;

    public GameObject line;

    private int pointerInt=0;
    int pointerNum=0;//点击菜品次数

    int cutNum = 0;//切菜次数

    // Start is called before the first frame update
    void Start()
    {
        //隐藏指示线
        line.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //点击蔬菜
    public void Step1Put()
    {
        //print("切菜"+ cucumberAnimator.GetInteger("step"));

        if(cucumberAnimator.GetInteger("step")<1)
        {
            cucumberAnimator.SetInteger("step", 1);
            Pointer();
        }
        else if (cucumberAnimator.GetInteger("step") == 2)   //切菜后step=2
        {
            cucumberAnimator.SetInteger("step", 3); //放回
            knifeAnimator.SetInteger("step", 0);    //菜刀动画结束
            //pointerInt = 0;
            //pointerAnimator.SetInteger("step", 0);
            Pointer();
        }
            
        //Pointer();
    }
    public void Carrot()
    {
        if (carrotAnimator.GetInteger("step") < 1)
        {
            carrotAnimator.SetInteger("step", 1);
            Pointer();
        }
        else if (carrotAnimator.GetInteger("step") == 2)   //切菜后step=2
        {
            carrotAnimator.SetInteger("step", 3); //放回
            knifeAnimator.SetInteger("step", 0);  //菜刀动画结束
            Pointer();
        }
        
        //Pointer();
    }
    public void Meat()
    {
        if (meatAnimator.GetInteger("step") < 1)
        {
            meatAnimator.SetInteger("step", 1);
            Pointer();
        }
        else   //切菜后step=2
        {
            meatAnimator.SetInteger("step", 3); //放回
            knifeAnimator.SetInteger("step", 0);  //菜刀动画结束
            Pointer();
        }

        //Pointer();
    }
    public void Onion()
    {
        if (onionAnimator.GetInteger("step") < 1)
        {
            onionAnimator.SetInteger("step", 1);
            Pointer();
        }
        else   //切菜后step=2
        {
            onionAnimator.SetInteger("step", 3); //放回
            knifeAnimator.SetInteger("step", 0);  //菜刀动画结束
            Pointer();
        }

        //Pointer();
    }
    public void Xiangcai()
    {
        if (xiangcaiAnimator.GetInteger("step") < 1)
        {
            xiangcaiAnimator.SetInteger("step", 1);
            Pointer();
        }
        else   //切菜后step=2
        {
            xiangcaiAnimator.SetInteger("step", 3); //放回
            knifeAnimator.SetInteger("step", 0);  //菜刀动画结束
            Pointer();
        }

        //Pointer();
    }

    private void Pointer()  //点击菜品时，手指的动画
    {
        pointerNum++;
        print("pointerNum " + pointerNum);

        if (pointerAnimator.GetInteger("step") < 2)
        {
            pointerAnimator.SetInteger("step", ++pointerInt);   //pointerInt=1
        }
        else if(pointerAnimator.GetInteger("step") == 2)   //切菜放回后pointer step=2
        {
            switch (pointerNum / 2)
            {
                case 1:
                    pointerAnimator.SetInteger("step", 3);   //pointerInt=3,指示carrot
                    break;
                case 2:
                    pointerAnimator.SetInteger("step", 4);   //pointerInt=4,指示meat
                    break;
                case 3:
                    pointerAnimator.SetInteger("step", 5);   //pointerInt=3,指示onion
                    break;
                case 4:
                    pointerAnimator.SetInteger("step", 6);   //pointerInt=4,指示xiangcai
                    break;
                case 5:
                    pointerAnimator.SetInteger("step", 7);   //pointerInt=5,指示消失
                    break;
            }
            
        }
        else
        {
            pointerInt = 1;
            pointerAnimator.SetInteger("step", pointerInt);
        }

        if (pointerAnimator.GetInteger("step") < 2)
            //显示指示线
            line.SetActive(true);

    }
    //点击菜刀
    public void Step2Cut()
    {
        if(pointerAnimator.GetInteger("step") == 1)
        {
            cutNum++;
            line.SetActive(false);
            knifeAnimator.SetInteger("step", 2);
            pointerAnimator.SetInteger("step", ++pointerInt);   //pointerInt=2
                                                                //Invoke(nameof(PointerAnim), 0.2f);

            switch (cutNum)
            {
                case 1:
                    cucumberAnimator.SetInteger("step", 2);
                    break;
                case 2:
                    carrotAnimator.SetInteger("step", 2);
                    break;
                case 3:
                    meatAnimator.SetInteger("step", 2);
                    break;
                case 4:
                    onionAnimator.SetInteger("step", 2);
                    break;
                case 5:
                    xiangcaiAnimator.SetInteger("step", 2);
                    break;
            }
        }
        
    }
    /*void PointerAnim()
    {
        pointerAnimator.SetInteger("step", ++pointerInt);   //pointerInt=3
    }*/

    
}
