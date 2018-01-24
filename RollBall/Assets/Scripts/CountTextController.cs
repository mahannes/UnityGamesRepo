using Assets.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class CountTextController : MonoBehaviour
{

    public PlayerController playerController;
    public Text text;

    public void Start()
    {
        playerController.PropertyChanged += HandlePlayerPropertyChanged;
        text.text = "";
    }

    private void HandlePlayerPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        text.text = playerController.Count.ToString();
    }

    public void OnDestroy()
    {
        playerController.PropertyChanged -= HandlePlayerPropertyChanged;
    }
}
