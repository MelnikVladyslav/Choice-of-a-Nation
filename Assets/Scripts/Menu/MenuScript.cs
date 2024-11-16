using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

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