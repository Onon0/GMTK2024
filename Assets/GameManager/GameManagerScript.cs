using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int currentLevel = 0;
    
    public GameObject GameDialog;
    public GameObject player;

    public Button resetBtn;
    public Button exitBtn;

    private Vector3 startPos;
    private Vector3 startScale;

    private Button nextButton;
    private Button quitButton;
    private TextMeshProUGUI dialogText;
    private TextMeshProUGUI buttonText;
    
    private void Awake()
    {
        hideDialog();
        
    }
    private void Start()
    {
        
        startPos = player.transform.position;
        startScale = player.transform.localScale;

        foreach (Button b in GameDialog.GetComponentsInChildren<Button>(true))
        {
            Debug.Log(b.name);
            if (b.name == "btn_next")
            {
                nextButton = b;
                print(b.name);
            }
            if (b.name == "btn_quit") quitButton = b;
        }
        dialogText = GameDialog.GetComponentInChildren<TextMeshProUGUI>();
        buttonText = nextButton.GetComponentInChildren<TextMeshProUGUI>();

        quitButton.onClick.AddListener(() => { Quit(); });
        exitBtn.onClick.AddListener(() => { Quit(); });
        resetBtn.onClick.AddListener(() => { Restart(); });

        setButtonFinish();



    }
    public void Restart() {
        //player.transform.position = startPos;
        //player.transform.localScale = startScale;
        //player.GetComponent<player_controller>().setSmall();
        //player.GetComponent<player_controller>().Finish();
        //hideDialog();
        SceneManager.LoadScene("Level" + currentLevel);

    }
    public void showDialog()
    {
        GameDialog.SetActive(true);
    }
    public void hideDialog()
    {
        GameDialog.SetActive(false);
    }
    public void setButtonFinish()
    {
        dialogText.text = "Level " + currentLevel + " Completed";
        
        nextButton.onClick.AddListener(() => {
            
            NextScene();
        });
    }
    public void setRestart()
    {
        dialogText.text = "Oops! Try Again?";
        player.GetComponent<player_controller>().Finish();
        buttonText.text = "Reset";
        nextButton.onClick.AddListener(() => { Restart();  });
        showDialog();
    }
    public void Finish()
    {
        buttonText.text = "Next Level";
        setButtonFinish();
        player.GetComponent<player_controller>().Finish();
        showDialog();
        PlayerPrefs.SetInt("LastLevel", currentLevel);
        PlayerPrefs.Save();
    }
    public void NextScene()
    {
        String sceneName = "Level" + (currentLevel + 1);
        Debug.Log(sceneName);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    public void Quit()
    {
       
        Application.Quit();
    }
}
