using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSequencer : MonoBehaviour
{
    public GameObject  m_startmark, m_finishmark, m_marble;


    private void Start()
    {
        // Deactivate marble at start point
        m_marble.SetActive(false);

    }

    public void startMarble(int state)
    {
        switch (state)
        {
            case 0:
                m_marble.transform.SetPositionAndRotation(m_startmark.transform.position, Quaternion.identity);
                m_marble.SetActive(false);
                m_marble.GetComponent<Rigidbody>().velocity = Vector3.zero;
                break;
            case 1:
                m_marble.SetActive(true);
                break;
        }
        
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
