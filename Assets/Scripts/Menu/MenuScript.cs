using Assets.Scripts.Clasess;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Menu
{
    public class MenuScript : MonoBehaviour
    {
        public void Play(int id)
        {
            SceneManager.LoadSceneAsync(id);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}