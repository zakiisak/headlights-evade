﻿using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.Settings
{
    public class ComponentTreesEnabled : MonoBehaviour
    {
        public Toggle toggle;

        public void Start()
        {
            toggle = GetComponent<Toggle>();

            toggle.isOn = PlayerPrefs.GetInt("TreesDisabled", 0) == 0;
        }

        public void OnToggled()
        {
            int val = toggle.isOn ? 0 : 1;
            PlayerPrefs.SetInt("TreesDisabled", val);
            PlayerPrefs.Save();
            Debug.Log("Is on: " + val);
        }
    }
}
