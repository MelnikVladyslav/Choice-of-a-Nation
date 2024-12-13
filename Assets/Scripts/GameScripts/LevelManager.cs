using Assets.Scripts.Clasess;
using Assets.Scripts.Clasess.Profile;
using Assets.Scripts.Menu.Settings.Localization;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.GameScripts
{
    public class LevelManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        Game game = new Game();
        bool isOpen = false;

        public GameObject levelPr;
        public GameObject contentPar;
        Text[] texts = new Text[] { };

        Text nameLev;
        Text descLev;
        Button playBtn;

        // Use this for initialization
        void Start()
        {
            isOpen = true;
            game = load.LoadStartInfo();
        }

        // Update is called once per frame
        void Update()
        {
            if (isOpen)
            {
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < game.Levels.Count; i++)
                {
                    GameObject curEff = Instantiate(levelPr, contentPar.transform);
                    curEff.transform.position = new Vector3(curEff.transform.position.x - (2 * i), curEff.transform.position.y, curEff.transform.position.z);
                    
                    texts = curEff.GetComponentsInChildren<Text>();
                    foreach(Text text in texts) 
                    { 
                        if (text.name == "Name")
                        {
                            nameLev = text;
                        }
                        if (text.name == "Description")
                        {
                            descLev = text;
                        }
                    }

                    nameLev.GetComponent<TextLanguage>().textUkr = game.Levels[i].Name;
                    nameLev.GetComponent<TextLanguage>().textEng = game.Levels[i].NameEng;
                    nameLev.text = game.Levels[i].Name;
                    descLev.GetComponent<TextLanguage>().textUkr = game.Levels[i].Description;
                    descLev.GetComponent<TextLanguage>().textEng = game.Levels[i].DescriptionEng;
                    descLev.text = game.Levels[i].Description;

                    int a = i;
                    playBtn = curEff.GetComponentInChildren<Button>();
                    playBtn.onClick.AddListener(() => PlayLevel(a));
                }
                isOpen = false;
            }
        }

        public void PlayLevel(int id)
        {
            SceneManager.LoadSceneAsync(id + 5);
            game.idLevCur = 0;
            save.SavePlayers(game);
        }
    }
}