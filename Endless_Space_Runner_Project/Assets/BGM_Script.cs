using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BGM_Script : MonoBehaviour
{
    void Start()
    {

    }
    private static BGM_Script instance = null;
    public static BGM_Script Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
