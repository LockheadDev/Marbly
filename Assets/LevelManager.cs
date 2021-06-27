using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LevelManager
{
    // Start is called before the first frame update
    private static bool start = false;
    private static bool win = false;
    private static bool fail = false;
    private static bool pause = false;

    #region setters
    public static void setStart(bool state)
    {
        start = state;
    }
    public static void setWin(bool state)
    {
        win = state;
    }
    public static void setFail(bool state)
    {
        fail = state;
    }
    public static void setPause(bool state)
    {
        pause = state;
    }
    #endregion

    #region getters
    public static bool getStart()
    {
        return start;
    }
    public static bool getWin()
    {
        return start;
    }
    public static bool getFail()
    {
        return start;
    }
    public static bool getPause()
    {
        return pause;
    }
    #endregion

    public static void togglePause()
    {
        setPause(!pause);
    }
    public static void showStatus()
    {
        Debug.Log(
            "Start: " + start.ToString()+" "+
            "Win: " + win.ToString() + " "+
            "Fail: " + fail.ToString() + " "+
            "Pause: " + pause.ToString() + " "
            );
    }
}
