using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefText : MonoBehaviour
{
    public string playerName; // Rename 'name' to 'playerName' or another suitable name

    void Start()
    {

    }

    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(playerName) + "";
    }
}
