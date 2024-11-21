using Assets.Scripts.Clasess;
using Assets.Scripts.Menu.Settings.Localization;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GameScripts
{
    public class LoseManager : MonoBehaviour
    {
        public Text loseTxt;

        Save save = new Save();
        Load load = new Load();

        // Use this for initialization
        void Start()
        {
            loseTxt.text = PlayerPrefs.GetString("textLose");
            loseTxt.GetComponent<TextLanguage>().textUkr = PlayerPrefs.GetString("textLose");
            loseTxt.GetComponent<TextLanguage>().textEng = PlayerPrefs.GetString("textEngLose");

            Game game = load.LoadStartInfo();
            save.SavePlayers(game);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}