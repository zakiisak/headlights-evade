﻿using Assets.Code.Game;
using Assets2.Code;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Code.Titlescreen
{
    public class ComponentTitlescreenHooks : MonoBehaviour
    {

        public TMP_InputField ReplayCodeInputField;
        public TMP_Text ReplayCodeInvalidText;

        public void Start()
        {

        }

        public void OnStartPressed()
        {
            PredictableRandom.SetRandomSeed();
            SceneManager.LoadScene(1);
        }


        public void SwitchGame()
        {
            SceneManager.LoadScene(Game2.TitlescreenBuildIndex);
        }
    }
}
