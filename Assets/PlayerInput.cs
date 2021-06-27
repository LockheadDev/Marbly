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
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LevelManager.setStart(true);
            levelSequencer.startMarble();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LevelManager.togglePause();
            levelSequencer.toggleGamePause();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            LevelManager.showStatus();
        }

    }
}
