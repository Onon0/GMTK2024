using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelBtnLogic : MonoBehaviour
{
    public int level;
    public bool unlocked;
    public Sprite unlocked_sprite;
    public Sprite locked_sprite;
    public TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        if (!unlocked)
        {
            GetComponent<Button>().enabled = false;
            GetComponent<Image>().sprite = locked_sprite;
            return;
        }
        
        GetComponent<Button>().onClick.AddListener(() => { SceneManager.LoadScene("Level" + level); });
        GetComponent<Image>().sprite = unlocked_sprite;
        textMesh.text = "Level " + level;

    }

    
}
