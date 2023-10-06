using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public static string cuttingboardS1 = "empty";
    /*public static string cuttingboardS2 = "empty";
    public static string cuttingboardS3 = "empty";*/

    public static string grillS1 = "empty";
    /*public static string grillS2;
    public static string grillS3;*/

    public GameObject pointerUpAndDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HidePointer()
    {
        Destroy(pointerUpAndDown);
    }
}
