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
                textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].End.Description;
                textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].End.Description;
                textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].End.DescriptionEng;

                idTurn++;
                idText = 0;

                if (game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[0].Name == "Бій")
                {
                    game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].IdTextCur = idText;
                    game.Levels[0].CountriesOpen[0].IdTurnCur = idTurn - 1;
                    PlayerPrefs.SetString("OurLeader", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[4].Name);
                    PlayerPrefs.SetString("EnemyLeader", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[5].Name);
                    PlayerPrefs.SetInt("OurArmy", game.Levels[0].CountriesOpen[0].Parametrs[5].Value);
                    PlayerPrefs.SetInt("EnemyArmy", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[1].Value);
                    PlayerPrefs.SetInt("OurOrg", (int)(50 + ((game.Levels[0].CountriesOpen[0].Parametrs[0].Value / 100f) * 50)));
                    PlayerPrefs.SetInt("EnemyOrg", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[3].Value);
                    PlayerPrefs.SetInt("OurBoyDuh", (int)(50 + ((game.Levels[0].CountriesOpen[0].Parametrs[1].Value / 100f) * 50)));
                    PlayerPrefs.SetInt("EnemyBoyDuh", game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].End.Result[2].Value);
                    PlayerPrefs.SetInt("Level", 0);
                    PlayerPrefs.SetInt("Country", 0);
                    PlayerPrefs.SetInt("Scene", 5);
                    SceneManager.LoadSceneAsync(2);
                    BackSave();
                }

                if (game.Levels[0].CountriesOpen[0].Turns[idTurn - 1].Choises.Count > 0)
                {
                    panelChoises.gameObject.SetActive(true);
                    PlayerPrefs.SetInt("Level", 0);
                    PlayerPrefs.SetInt("Country", 0);
                    PlayerPrefs.SetInt("Turn", idTurn - 1);
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
            else
            {
                textContent.text = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
                textContent.GetComponent<TextLanguage>().textUkr = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].Text;
                textContent.GetComponent<TextLanguage>().textEng = game.Levels[0].CountriesOpen[0].Turns[idTurn].Contents[idText].TextEng;
            }

            if (idTurn >= game.Levels[0].CountriesOpen[0].Turns.Count)
            {
                SceneManager.LoadSceneAsync(4);
                PlayerPrefs.SetString("textWin", "Кінець Київської держави виглядав як затихання грандіозної симфонії, яка, хоч і дійшла свого апогею, поступово розпалася на окремі ноти. Русь, збудована кров’ю та залізом, зіткнулася з хвилями зовнішніх нападів і внутрішніх чвар, які ламали її основу. Останні князі, замість того, щоб захищати землю своїх предків, боролися один з одним за уламки колишньої слави.\r\n\r\nМонгольська навала стала фінальним ударом. Батиєві орди, мов буря, пройшли руськими землями, залишаючи попелища замість колись квітучих міст. Київ, серце цієї держави, витримав облогу, але, зрештою, був зруйнований у 1240 році. Залишки мешканців спостерігали, як величні стіни та храми, що втілювали міць і духовність Русі, падали перед незламною силою монгольської кінноти.\r\n\r\nКнязі, які ще могли чинити опір, або загинули в битвах, або підкорилися, визнавши владу Орди. Центр руського життя почав зміщуватися на північ — до Володимиро-Суздальської землі, а згодом до Московії, яка стала спадкоємцем колись великої Київської Русі.\r\n\r\nАле, княже, це не просто кінець. Це перехрестя історії. Київська держава, хоч і загинула, залишила після себе невгасиме полум’я. Її культура, мова і віра стали основою для нових держав. Це урок для майбутніх поколінь: навіть найвеличніші імперії можуть впасти, якщо не знайдуть єдності. І все ж, той дух, що збудував Київ, ніколи не згасне, залишаючи свій слід у віках. \r\n\r\nГра завершена. Але історія триває.");
                PlayerPrefs.SetString("textWinEng", "The end of the Kievan state seemed like the lull of a grand symphony, which, although it had reached its apogee, gradually disintegrated into separate notes. Rus, built with blood and iron, faced waves of external attacks and internal strife that broke its foundation. The last princes, instead of defending the land of their ancestors, fought each other for the fragments of former glory.\r\n\r\nThe Mongol invasion was the final blow. Batu's hordes, like a storm, swept through the Rus' lands, leaving ashes in place of the once flourishing cities. Kiev, the heart of this state, withstood the siege, but was ultimately destroyed in 1240. The remnants of the inhabitants watched as the majestic walls and temples, embodying the power and spirituality of Rus, fell before the invincible force of the Mongol cavalry.\r\n\r\nThe princes who could still resist either died in battles or submitted, recognizing the power of the Horde. The center of Russian life began to shift northward — to the Vladimir-Suzdal land, and later to Muscovy, which became the heir to the once great Kievan Rus.\r\n\r\nBut, prince, this is not just the end. This is a crossroads of history. The Kievan state, although it perished, left behind an unquenchable flame. Its culture, language, and faith became the basis for new states. This is a lesson for future generations: even the greatest empires can fall if they do not find unity. And yet, the spirit that built Kiev will never fade, leaving its mark on the centuries.\r\n\r\nThe game is over. But history continues.");
            }

            BackSave();
        }
    }
}