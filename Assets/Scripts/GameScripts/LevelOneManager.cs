using Assets.Scripts.Clasess;
using Assets.Scripts.Menu.Settings.Localization;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.GameScripts
{
    public class LevelOneManager : MonoBehaviour
    {
        #region Statistice
        Load load = new Load();
        Save save = new Save();

        Game game = new Game();

        public Text pidtr;
        public Text stanArmy;
        public Text kazna;
        #endregion

        public Text textContent;
        public GameObject panelChoises;

        int idText = 0;
        int idTurn = 0;

        // Use this for initialization
        void Start()
        {
            game = load.LoadPlayersInfo();

            if (game.Levels[0].CountriesOpen[0].IdTurnCur != 0)
            {
                idTurn = game.Levels[0].CountriesOpen[0].IdTurnCur;

                if (game.Levels[0].CountriesOpen[0].Turns[idTurn].IdTextCur != 0)
                {
                    idText = game.Levels[0].CountriesOpen[0].Turns[idTurn].IdTextCur;
                }
            }

            PlayerPrefs.SetInt("EnterChoise", -1);

            pidtr.text = ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value + game.Levels[0].CountriesOpen[0].Parametrs[1].Value + game.Levels[0].CountriesOpen[0].Parametrs[2].Value) / 3).ToString() + "%";
            stanArmy.text = game.Levels[0].CountriesOpen[0].Parametrs[3].Value.ToString() + "%";
            kazna.text = game.Levels[0].CountriesOpen[0].Parametrs[4].Value.ToString();

            textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
            textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
            textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].TextEng;
        }

        // Update is called once per frame
        void Update()
        {
            if (PlayerPrefs.GetString("WhoWin") != null || PlayerPrefs.GetString("WhoWin") != "")
            {
                if (PlayerPrefs.GetString("WhoWin") == "our")
                {
                    idTurn += 1;
                    idText = 0;

                    textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
                    textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
                    textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].TextEng;
                }
                if (PlayerPrefs.GetString("WhoWin") == "enemy")
                {
                    PlayerPrefs.SetString("textLose", "На жаль ви програли, ваш вплив послабився. Цим скористалися вороги і опозиція, скинувши вас і захопивши владу.");
                    PlayerPrefs.SetString("textEngLose", "На жаль ви програли, ваш вплив послабився. Цим скористалися вороги і опозиція, скинувши вас і захопивши владу.");
                    SceneManager.LoadSceneAsync(3);
                }

                PlayerPrefs.SetString("WhoWin", "");
            }

            if (PlayerPrefs.GetInt("EnterChoise") != -1)
            {
                panelChoises.gameObject.SetActive(false);
                for (int i = 0; i < game.Levels[0].CountriesOpen[0].Parametrs.Count; i++)
                {
                    Debug.Log(PlayerPrefs.GetInt("EnterChoise"));
                    Debug.Log(PlayerPrefs.GetInt("Turn"));
                    for (int j = 0; j < game.Levels[0].CountriesOpen[0].Turns[PlayerPrefs.GetInt("Turn")].Choises[0].Elements[PlayerPrefs.GetInt("EnterChoise")].Result.Count; j++)
                    {
                        if (game.Levels[0].CountriesOpen[0].Parametrs[i].Name == game.Levels[0].CountriesOpen[0].Turns[PlayerPrefs.GetInt("Turn")].Choises[0].Elements[PlayerPrefs.GetInt("EnterChoise")].Result[j].Name)
                        {
                            game.Levels[0].CountriesOpen[0].Parametrs[i].Value += game.Levels[0].CountriesOpen[0].Turns[PlayerPrefs.GetInt("Turn")].Choises[0].Elements[PlayerPrefs.GetInt("EnterChoise")].Result[j].Value;
                        }
                    }
                }

                pidtr.text = ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value + game.Levels[0].CountriesOpen[0].Parametrs[1].Value + game.Levels[0].CountriesOpen[0].Parametrs[2].Value) / 3).ToString() + "%";
                stanArmy.text = game.Levels[0].CountriesOpen[0].Parametrs[3].Value.ToString() + "%";
                kazna.text = game.Levels[0].CountriesOpen[0].Parametrs[4].Value.ToString();
                BackSave();
                PlayerPrefs.SetInt("EnterChoise", -1);
            }
        }

        public void BackSave()
        {
            save.SavePlayers(game);
        }

        public void Back()
        {
            SceneManager.LoadSceneAsync(0);
        }

        public void NextText()
        {
            idText++;
            Debug.Log(idText);
            
            if (idText >= game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents.Count)
            {
                idTurn++;
                idText = 0;
                textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn-1].End.Description;
                textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn-1].End.Description;
                textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.DescriptionEng;

                if (game.Levels[0].CountriesOpen[0].Turns[idTurn-1].End.Result[0].Name == "Бій")
                {
                    game.Levels[0].CountriesOpen[0].Turns[idTurn-1].IdTextCur = idText;
                    game.Levels[0].CountriesOpen[0].IdTurnCur = idTurn-1;
                    PlayerPrefs.SetString("OurLeader", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[4].Name);
                    PlayerPrefs.SetString("EnemyLeader", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[5].Name);
                    PlayerPrefs.SetInt("OurArmy", game.Levels[0].CountriesOpen[0].Parametrs[5].Value);
                    PlayerPrefs.SetInt("EnemyArmy", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[1].Value);
                    PlayerPrefs.SetInt("OurOrg", (int)(30 + ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value / 100f) * 30)));
                    PlayerPrefs.SetInt("EnemyOrg", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[3].Value);
                    PlayerPrefs.SetInt("OurBoyDuh", (int)(50 + ((game.Levels[0].CountriesOpen[0].Parametrs[1].Value / 100f) * 50)));
                    PlayerPrefs.SetInt("EnemyBoyDuh", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[2].Value);
                    PlayerPrefs.SetInt("Level", 0);
                    PlayerPrefs.SetInt("Country", 0);
                    PlayerPrefs.SetInt("Scene", 4);
                    SceneManager.LoadSceneAsync(2);
                    BackSave();
                }

                if (game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].Choises.Count > 0)
                {
                    panelChoises.gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Level", 0);
                    PlayerPrefs.SetInt("Country", 0);
                    PlayerPrefs.SetInt("Turn", idTurn-1);
                }

                for (int i = 0; i < game.Levels[0].CountriesOpen[0].Parametrs.Count; i++)
                {
                    for (int j = 0; j < game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result.Count; j++)
                    {
                        if (game.Levels[0].CountriesOpen[0].Parametrs[i].Name == game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[j].Name)
                        {
                            if (game.Levels[0].CountriesOpen[0].Parametrs[i].Name == "Скарбниця")
                            {
                                game.Levels[0].CountriesOpen[0].Parametrs[i].Value += (10 + (game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[j].Value / 100) * game.Levels[0].CountriesOpen[0].Parametrs[2].Value);
                            }
                            game.Levels[0].CountriesOpen[0].Parametrs[i].Value += game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[j].Value;
                        }
                    }
                }

                pidtr.text = ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value + game.Levels[0].CountriesOpen[0].Parametrs[1].Value + game.Levels[0].CountriesOpen[0].Parametrs[2].Value) / 3).ToString() + "%";
                stanArmy.text = game.Levels[0].CountriesOpen[0].Parametrs[3].Value.ToString() + "%";
                kazna.text = game.Levels[0].CountriesOpen[0].Parametrs[4].Value.ToString();
            }

            textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
            textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
            textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].TextEng;

            BackSave();
        }
    }
}