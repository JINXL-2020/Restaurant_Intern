using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogSystem : MonoBehaviour
{
    [Header("UI")]
    public Text textLabel;
    public Image faceImage;
    [Header("Text File")]
    public TextAsset textFile;
    public float textSpeed;

    private static int index;
    bool textFinished;  //是否完成打字
    bool cancelTyping;  //取消逐个打字

    List<string> textList = new List<string>();
    //在OnEnable方法之前调用
    private void Awake()
    {
        GetTextFromFile(textFile);
    }
    //对话框启动时从第一句话开始显示
    private void OnEnable()
    {
        StartCoroutine(SetTextUI());
    }
    // Update is called once per frame
    void Update()
    {
        /*if (EventSystem.current.IsPointerOverGameObject())
            print("233");*/
        if (index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (textFinished && !cancelTyping)
                StartCoroutine(SetTextUI());
            else if (!textFinished)
                cancelTyping = !cancelTyping;
        }
    }

    //从文本文件中获取文本
    void GetTextFromFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var lineData=file.text.Split('\n');

        foreach(var line in lineData)
        {
            textList.Add(line);
        }
    }

    //定义一个协程，用于逐个显示文字
    IEnumerator SetTextUI()
    {
        //文本是否显示完
        textFinished = false;
        //每次调用都将文本框的文本清空
        textLabel.text = "";
        //显示每个字符的等待时间
        WaitForSeconds waitForSeconds = new WaitForSeconds(textSpeed);
        //获取每一行的字符
        for (int i = 0; i < textList[index].Length; i++)
        {
            if (cancelTyping == true)
            {
                //直接显示文本并退出循环
                textLabel.text = textList[index];
                cancelTyping = false;
                break;
            }
            textLabel.text += textList[index][i];

            yield return waitForSeconds;
        }
        
        textFinished = true;
        index++;
        
    }
}
