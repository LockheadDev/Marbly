using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private LevelSequencer levelSequencer;

    // Start is called before the first frame update
    void Start()
    {
        levelSequencer = GameObject.Find("LevelSequencer").GetComponent<LevelSequencer>();
        if (levelSequencer == null)
        {
            GameObject g_LevelSequencer = new GameObject();
            g_LevelSequencer.AddComponent<LevelSequencer>();
            g_LevelSequencer.name = "LevelSequencer(Created by code)";
            Instantiate(g_LevelSequencer);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LevelManager.togglePause();
            levelSequencer.toggleGamePause();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LevelManager.showStatus();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            LevelManager.setFail(false);
            LevelManager.setStart(false);
            LevelManager.setWin(false);
            levelSequencer.startMarble(0);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            levelSequencer.startMarble(1);
            LevelManager.setStart(true);
        }

    }
}
