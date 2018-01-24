using Assets.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class WinTextController : MonoBehaviour
    {
        public PlayerController playerController;
        public Text text;

        public void Start()
        {
            playerController.PropertyChanged += HandlePlayerPropertyChanged;
            UpdateText();
        }

        private void HandlePlayerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateText();
        }

        private void UpdateText()
        {
            text.text = playerController.Count >= 11
                ? "You win"
                : "";
        }

        public void OnDestroy()
        {
            playerController.PropertyChanged -= HandlePlayerPropertyChanged;
        }
    }
}
