using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayer : MonoBehaviour
{
    public GameObject clickToStartButton;
    // Start is called before the first frame update
    void Start()
    {
        clickToStartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        clickToStartButton.SetActive(false);
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        
        if (!vp.isPlaying)
        {
            clickToStartButton.SetActive(true);
        }
    }

}
