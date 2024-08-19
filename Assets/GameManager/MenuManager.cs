using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject level_btn_prefab;
    public int levelCount; 
    private int levelUnlocked;
    // Start is called before the first frame update
    void Start()
    {
        levelUnlocked  = PlayerPrefs.GetInt("LastLevel", 0); ;

        for (int i = 0; i < levelCount; i++)
        {
            GameObject g = Instantiate(level_btn_prefab, transform);
            g.GetComponent<LevelBtnLogic>().level = i + 1;
            g.GetComponent<LevelBtnLogic>().unlocked = ((i + 1) <= levelUnlocked) || (i == 0);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
