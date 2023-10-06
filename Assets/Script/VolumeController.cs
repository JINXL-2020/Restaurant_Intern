using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    private Slider volumeSlider;
    private AudioSource audioSource;
    void Awake()
    {
        volumeSlider = GameObject.Find("Slider").GetComponent<Slider>();
        audioSource = GameObject.Find("bgMusic").GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }
    public void Init()
    {
        //当音量是有上一次记录的值时，附上相应的值
        if (PlayerPrefs.HasKey(GameConst.PlayerPrefsStr.soundValue.ToString()))
        {
            float vol = PlayerPrefs.GetFloat(GameConst.PlayerPrefsStr.soundValue.ToString());
            audioSource.volume = vol;
            volumeSlider.value = vol;
        }
        //否则，设置当前音量值为1
        else
        {
            audioSource.volume = 1;
            PlayerPrefs.SetFloat(GameConst.PlayerPrefsStr.soundValue.ToString(), 1);
            volumeSlider.value = 1;
        }
        //音量条拖动时，记录下当前音量值
        volumeSlider.onValueChanged.AddListener(delegate (float vol)
        {
            PlayerPrefs.SetFloat(GameConst.PlayerPrefsStr.soundValue.ToString(), vol);
            audioSource.volume = vol;
        });
    }

}
