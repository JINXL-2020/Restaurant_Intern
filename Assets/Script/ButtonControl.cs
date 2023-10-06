using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    AudioSource click;

    public GameObject Menu;
    bool isStop = false;

    private void Start()
    {
        click = GetComponent<AudioSource>();
        Menu.SetActive(false);
    }
    private void Update()
    {
        if (isStop == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                StopGame();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Resume();
                /*Time.timeScale = 1f;
                isStop = false;
                Menu.SetActive(false);*/
            }
        }
    }
    //暂停菜单
    public void StopGame()
    {
        Time.timeScale = 0;
        isStop = true;
        Menu.SetActive(true);
    }
    public void ReplayGame()
    {
        Time.timeScale = 1f;
        BinControl.pos = -1f;
        GamePlay.cuttingboardS1 = "empty";
        GamePlay.grillS1 = "empty";
        Invoke(nameof(BacktoStartScreen), 0.2f);
    }
    public void Resume()
    {
        click.Play();
        Time.timeScale = 1f;
        isStop = false;
        Menu.SetActive(false);
    }

    //开始界面
    public void startGame()
    {
        click.Play();
        Invoke(nameof(LoadMainScene), 0.2f);
    }
    public void AboutGame()
    {
        click.Play();
        Invoke(nameof(LoadInstructionScene), 0.2f);
    }
    public void QuitGame()
    {
        Application.Quit();
        //Invoke(nameof(Quitgame), 0.2f);
    }
    public void LoadStartScreen()
    {
        click.Play();
        Invoke(nameof(BacktoStartScreen), 0.2f);
    }

    void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    void LoadInstructionScene()
    {
        SceneManager.LoadScene("Instruction");
    }
    void Quitgame()
    {
        Application.Quit();
    }
    void BacktoStartScreen()
    {
        SceneManager.LoadScene("StartScreen");
    }

    //跳转不同菜品
    public void American()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Chinese()
    {
        SceneManager.LoadScene("Chinese");
    }
    public void Japanese()
    {
        SceneManager.LoadScene("Japanese");
        SushiStepContrller.num = 0;
        SlotTemplate.stepCount = 0;
    }
    public void Korean()
    {
        SceneManager.LoadScene("Korean");
    }
}
