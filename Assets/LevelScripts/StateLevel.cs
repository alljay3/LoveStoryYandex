using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateLevel : MonoBehaviour
{
    static private int _nHears;
    static public bool IsGamePause = false;
    public static int NHears
    {
        get
        {
            return _nHears;
        }
        set
        {
            _nHears = _nHears >= 99999 ? 99999 : value;
        }
    }
}
