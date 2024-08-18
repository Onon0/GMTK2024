using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject level_btn_prefab;
    private int levelUnlocked;
    // Start is called before the first frame update
    void Start()
    {
        levelUnlocked  = PlayerPrefs.GetInt("LastLevel", 0); ;

        for (int i = 0; i < 10; i++)
        {
            GameObject g = Instantiate(level_btn_prefab, transform);
            g.GetComponent<LevelBtnLogic>().level = i + 1;
            g.GetComponent<LevelBtnLogic>().unlocked = (i + 1) <= levelUnlocked;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
