using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    private static BGMusic instance;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        int bgNum = GameObject.FindGameObjectsWithTag("sound").Length;
        //Debug.Log(bgNum);
        if (bgNum > 1)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
