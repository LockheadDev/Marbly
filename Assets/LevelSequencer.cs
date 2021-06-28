using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSequencer : MonoBehaviour
{
    public GameObject  m_startmark, m_finishmark, m_marble;


    private void Awake()
    {
        // Deactivate marble at start point
        m_marble.SetActive(false);

    }
    // Start is called before the first frame update
    void Start()
    {
        // Put marble in startmark Position
        m_marble.transform.SetPositionAndRotation(m_startmark.transform.position, Quaternion.identity);
       
    }
    private void Update()
    {

    }
    public void startMarble()
    {
        m_marble.SetActive(true);
    }
    public void toggleGamePause()
    {
        if (!LevelManager.getPause())
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        

        //lock camera and show GUI
    }
    
}
