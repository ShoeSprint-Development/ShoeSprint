using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{

    private void Awake()
    {
        GameObject[] ad = GameObject.FindGameObjectsWithTag("AudioSRC");
        if (ad.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
