using Assets.Scripts.Clasess;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GameScripts
{
    public class GameManager : MonoBehaviour
    {
        #region Audio
        public AudioSource audio;
        #endregion

        private void Start()
        {
            #region Audio
            audio.volume = PlayerPrefs.GetFloat("volume");
            #endregion
        }
    }
}