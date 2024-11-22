using Assets.Scripts.Clasess;
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
    public class BattlesManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        int kilkOurArmy = 0;
        int kilkEnemyArmy = 0;
        int orgOurArmy = 0;
        int orgEnemyArmy = 0;
        int boyDuhOurArmy = 0;
        int boyDuhEnemyArmy = 0;

        int le, ce, re;

        int a = 0;

        public List<Texture> texturesLeaders = new List<Texture>();
        public RawImage OurLeadImg;
        public RawImage EnemyLeadImg;
        public Text OurDataTxt;
        public Text EnemyDataTxt;

        public ToggleGroup leftFlang;
        public ToggleGroup centerFlang;
        public ToggleGroup rightFlang;

        public Text resultTxt;
        public Text hintTxt;

        // Use this for initialization
        void Start()
        {
            kilkOurArmy = PlayerPrefs.GetInt("OurArmy");
            kilkEnemyArmy = PlayerPrefs.GetInt("EnemyArmy");
            orgOurArmy = PlayerPrefs.GetInt("OurOrg");
            orgEnemyArmy = PlayerPrefs.GetInt("EnemyOrg");
            boyDuhOurArmy = PlayerPrefs.GetInt("OurBoyDuh");
            boyDuhEnemyArmy = PlayerPrefs.GetInt("EnemyBoyDuh");

            le = Random.Range(0, 2);
            Debug.Log(le);
            ce = Random.Range(0, 2);
            Debug.Log(ce);
            re = Random.Range(0, 2);
            Debug.Log(re);

            ProvideEnemyPlansHintWithError(le, ce, re);

            foreach (var item in texturesLeaders)
            {
                if (item.name == PlayerPrefs.GetString("OurLeader"))
                {
                    OurLeadImg.texture = item;
                }
                if (item.name == PlayerPrefs.GetString("EnemyLeader"))
                {
                    EnemyLeadImg.texture = item;
                }
            }

            OurDataTxt.text = kilkOurArmy.ToString() + " бійців\n" + orgOurArmy.ToString() + "% організації\n" + boyDuhOurArmy.ToString() + "% бойового духу";
            EnemyDataTxt.text = kilkEnemyArmy.ToString() + " бійців\n" + orgEnemyArmy.ToString() + "% організації\n" + boyDuhEnemyArmy.ToString() + "% бойового духу";
            OurDataTxt.GetComponent<TextLanguage>().textUkr = kilkOurArmy.ToString() + " бійців\n" + orgOurArmy.ToString() + "% організації\n" + boyDuhOurArmy.ToString() + "% бойового духу";
            EnemyDataTxt.GetComponent<TextLanguage>().textUkr = kilkEnemyArmy.ToString() + " бійців\n" + orgEnemyArmy.ToString() + "% організації\n" + boyDuhEnemyArmy.ToString() + "% бойового духу";
            OurDataTxt.GetComponent<TextLanguage>().textEng = kilkOurArmy.ToString() + " soldiers\n" + orgOurArmy.ToString() + "% organizations\n" + boyDuhOurArmy.ToString() + "% fighting spirit";
            EnemyDataTxt.GetComponent<TextLanguage>().textEng = kilkEnemyArmy.ToString() + " soldiers\n" + orgEnemyArmy.ToString() + "% organizations\n" + boyDuhEnemyArmy.ToString() + "% fighting spirit";
        }

        public void ResultBattle()
        {
            if (a == 1)
            {
                SceneManager.LoadScene(PlayerPrefs.GetInt("Scene"));

                a = 0;
            }
            else
            {

                Toggle leftSelToggle = leftFlang.ActiveToggles().FirstOrDefault();
                Toggle centerSelToggle = centerFlang.ActiveToggles().FirstOrDefault();
                Toggle rightSelToggle = rightFlang.ActiveToggles().FirstOrDefault();

                int lo = 1, co = 1, ro = 1;

                switch (leftSelToggle.name)
                {
                    case "Атака":
                        lo = 0;
                        break;
                    case "Захист":
                        lo = 1;
                        break;
                    case "Штурм":
                        lo = 2;
                        break;
                }
                switch (centerSelToggle.name)
                {
                    case "Атака":
                        co = 0;
                        break;
                    case "Захист":
                        co = 1;
                        break;
                    case "Штурм":
                        co = 2;
                        break;
                }
                switch (rightSelToggle.name)
                {
                    case "Атака":
                        ro = 0;
                        break;
                    case "Захист":
                        ro = 1;
                        break;
                    case "Штурм":
                        ro = 2;
                        break;
                }

                float ratio = (float)kilkOurArmy / ((float)kilkOurArmy + (float)kilkEnemyArmy);

                #region Left flang

                if (le == lo)
                {
                    if (lo == 0)
                    {
                        resultTxt.text = "Ваша атака зіштовхнулася із зустрічною атакою.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr = "Ваша атака зіштовхнулася із зустрічною атакою.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng = "Your attack collided with a counter attack.\n";

                        int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                        int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                        float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                        float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                        orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                        orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                        boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                        boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);

                        kilkOurArmy -= deathOur;
                        kilkEnemyArmy -= deathEnemy;
                    }
                    if (lo == 1)
                    {
                        resultTxt.text = "По обидві сторони зайняли оборону.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr = "По обидві сторони зайняли оборону.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng = "Both sides took up defense.\n";
                    }
                    if (lo == 2)
                    {
                        resultTxt.text = "Ваш штурм зіштовхнувся із зустрічним штурмом.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr = "Ваш штурм зіштовхнувся із зустрічним штурмом.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng = "Your assault collided with a counter-assault.\n";

                        int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                        int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                        float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                        float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                        orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                        orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                        boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                        boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);

                        kilkOurArmy -= deathOur;
                        kilkEnemyArmy -= deathEnemy;
                    }
                }
                if (le != lo)
                {
                    if (lo == 0)
                    {
                        if (le == 1)
                        {
                            resultTxt.text = "Ваша атака зіштовхнулася з підготовленою обороною.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr = "Ваша атака зіштовхнулася з підготовленою обороною.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng = "Your attack ran into a prepared defense.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * ratio) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (le == 2)
                        {
                            resultTxt.text = "Ворог готувався до штурму і не очікував вашої атаки.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr = "Ворог готувався до штурму і не очікував вашої атаки.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng = "The enemy was preparing for an assault and did not expect your attack.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (2f * ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                    if (lo == 1)
                    {
                        if (le == 0)
                        {
                            resultTxt.text = "Ворог, що атакував зустрів нашу грізну оборону.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr = "Ворог, що атакував зустрів нашу грізну оборону.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng = "The attacking enemy met our formidable defense.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (le == 2)
                        {
                            resultTxt.text = "На ваші обороні позиції було здійснено спланований штурм.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr = "На ваші обороні позиції було здійснено спланований штурм.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng = "A planned assault was carried out on your defensive positions.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (2f * ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                    if (lo == 2)
                    {
                        if (le == 0)
                        {
                            resultTxt.text = "Ворог вдало наступає на ваші війська котрі готувалися до штурму.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr = "Ворог вдало наступає на ваші війська котрі готувалися до штурму.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng = "The enemy is successfully attacking your troops who were preparing for an assault.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (2f * ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (le == 1)
                        {
                            resultTxt.text = "Ви вдало штурмуєте оборонні позиції ворога.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr = "Ви вдало штурмуєте оборонні позиції ворога.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng = "You successfully storm the defensive positions of the enemy.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (2f * ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                }

                #endregion

                #region Center flang

                if (ce == co)
                {
                    if (co == 0)
                    {
                        resultTxt.text += "Ваша атака зіштовхнулася із зустрічною атакою.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr += "Ваша атака зіштовхнулася із зустрічною атакою.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng += "Your attack collided with a counter attack.\n";

                        int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                        int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                        float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                        float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                        orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                        orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                        boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                        boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);

                        kilkOurArmy -= deathOur;
                        kilkEnemyArmy -= deathEnemy;
                    }
                    if (co == 1)
                    {
                        resultTxt.text += "По обидві сторони зайняли оборону.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr += "По обидві сторони зайняли оборону.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng += "Both sides took up defense.\n";
                    }
                    if (co == 2)
                    {
                        resultTxt.text += "Ваш штурм зіштовхнувся із зустрічним штурмом.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr += "Ваш штурм зіштовхнувся із зустрічним штурмом.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng += "Your assault collided with a counter-assault.\n";

                        int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                        int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                        float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                        float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                        orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                        orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                        boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                        boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);

                        kilkOurArmy -= deathOur;
                        kilkEnemyArmy -= deathEnemy;
                    }
                }
                if (ce != co)
                {
                    if (co == 0)
                    {
                        if (ce == 1)
                        {
                            resultTxt.text += "Ваша атака зіштовхнулася з підготовленою обороною.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ваша атака зіштовхнулася з підготовленою обороною.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "Your attack ran into a prepared defense.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * ratio) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (ce == 2)
                        {
                            resultTxt.text += "Ворог готувався до штурму і не очікував вашої атаки.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ворог готувався до штурму і не очікував вашої атаки.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "The enemy was preparing for an assault and did not expect your attack.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (2f * ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                    if (co == 1)
                    {
                        if (ce == 0)
                        {
                            resultTxt.text += "Ворог, що атакував зустрів нашу грізну оборону.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ворог, що атакував зустрів нашу грізну оборону.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "The attacking enemy met our formidable defense.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (ce == 2)
                        {
                            resultTxt.text += "На ваші обороні позиції було здійснено спланований штурм.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "На ваші обороні позиції було здійснено спланований штурм.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "A planned assault was carried out on your defensive positions.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (2f * ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                    if (co == 2)
                    {
                        if (ce == 0)
                        {
                            resultTxt.text += "Ворог вдало наступає на ваші війська котрі готувалися до штурму.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ворог вдало наступає на ваші війська котрі готувалися до штурму.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "The enemy is successfully attacking your troops who were preparing for an assault.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (2f * ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (ce == 1)
                        {
                            resultTxt.text += "Ви вдало штурмуєте оборонні позиції ворога.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ви вдало штурмуєте оборонні позиції ворога.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "You successfully storm the defensive positions of the enemy.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (2f * ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                }

                #endregion

                #region Right flang

                if (re == ro)
                {
                    if (ro == 0)
                    {
                        resultTxt.text += "Ваша атака зіштовхнулася із зустрічною атакою.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr += "Ваша атака зіштовхнулася із зустрічною атакою.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng += "Your attack collided with a counter attack.\n";

                        int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                        int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                        float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                        float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                        orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                        orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                        boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                        boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);

                        kilkOurArmy -= deathOur;
                        kilkEnemyArmy -= deathEnemy;
                    }
                    if (ro == 1)
                    {
                        resultTxt.text += "По обидві сторони зайняли оборону.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr += "По обидві сторони зайняли оборону.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng += "Both sides took up defense.\n";
                    }
                    if (ro == 2)
                    {
                        resultTxt.text += "Ваш штурм зіштовхнувся із зустрічним штурмом.\n";
                        resultTxt.GetComponent<TextLanguage>().textUkr += "Ваш штурм зіштовхнувся із зустрічним штурмом.\n";
                        resultTxt.GetComponent<TextLanguage>().textEng += "Your assault collided with a counter-assault.\n";

                        int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                        int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                        float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                        float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                        orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                        orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                        boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                        boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);

                        kilkOurArmy -= deathOur;
                        kilkEnemyArmy -= deathEnemy;
                    }
                }
                if (re != ro)
                {
                    if (ro == 0)
                    {
                        if (re == 1)
                        {
                            resultTxt.text += "Ваша атака зіштовхнулася з підготовленою обороною.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ваша атака зіштовхнулася з підготовленою обороною.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "Your attack ran into a prepared defense.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * ratio) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (re == 2)
                        {
                            resultTxt.text += "Ворог готувався до штурму і не очікував вашої атаки.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ворог готувався до штурму і не очікував вашої атаки.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "The enemy was preparing for an assault and did not expect your attack.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (2f * ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                    if (ro == 1)
                    {
                        if (re == 0)
                        {
                            resultTxt.text += "Ворог, що атакував зустрів нашу грізну оборону.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ворог, що атакував зустрів нашу грізну оборону.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "The attacking enemy met our formidable defense.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * ratio) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (re == 2)
                        {
                            resultTxt.text += "На ваші обороні позиції було здійснено спланований штурм.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "На ваші обороні позиції було здійснено спланований штурм.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "A planned assault was carried out on your defensive positions.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (2f * ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                    if (ro == 2)
                    {
                        if (re == 0)
                        {
                            resultTxt.text += "Ворог вдало наступає на ваші війська котрі готувалися до штурму.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ворог вдало наступає на ваші війська котрі готувалися до штурму.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "The enemy is successfully attacking your troops who were preparing for an assault.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (2f * ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (1 - ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                        if (re == 1)
                        {
                            resultTxt.text += "Ви вдало штурмуєте оборонні позиції ворога.\n";
                            resultTxt.GetComponent<TextLanguage>().textUkr += "Ви вдало штурмуєте оборонні позиції ворога.\n";
                            resultTxt.GetComponent<TextLanguage>().textEng += "You successfully storm the defensive positions of the enemy.\n";

                            int deathOur = Mathf.RoundToInt((kilkOurArmy * (1 - ratio)) / 2);
                            int deathEnemy = Mathf.RoundToInt((kilkEnemyArmy * (2f * ratio)) / 2);

                            kilkOurArmy -= deathOur;
                            kilkEnemyArmy -= deathEnemy;

                            float moraleLossOur = Mathf.Clamp(deathOur / (float)kilkOurArmy * 10f, 0f, 5f);
                            float moraleLossEnemy = Mathf.Clamp(deathEnemy / (float)kilkEnemyArmy * 10f, 0f, 5f);

                            orgOurArmy = (int)Mathf.Clamp(orgOurArmy - moraleLossOur, 0f, 100f);
                            orgEnemyArmy = (int)Mathf.Clamp(orgEnemyArmy - moraleLossEnemy, 0f, 100f);

                            boyDuhOurArmy = (int)Mathf.Clamp(boyDuhOurArmy - moraleLossOur, 0f, 100f);
                            boyDuhEnemyArmy = (int)Mathf.Clamp(boyDuhEnemyArmy - moraleLossEnemy, 0f, 100f);
                        }
                    }
                }

                #endregion

                OurDataTxt.text = kilkOurArmy.ToString() + " бійців\n" + orgOurArmy.ToString() + "% організації\n" + boyDuhOurArmy.ToString() + "% бойового духу";
                EnemyDataTxt.text = kilkEnemyArmy.ToString() + " бійців\n" + orgEnemyArmy.ToString() + "% організації\n" + boyDuhEnemyArmy.ToString() + "% бойового духу";
                OurDataTxt.GetComponent<TextLanguage>().textUkr = kilkOurArmy.ToString() + " бійців\n" + orgOurArmy.ToString() + "% організації\n" + boyDuhOurArmy.ToString() + "% бойового духу";
                EnemyDataTxt.GetComponent<TextLanguage>().textUkr = kilkEnemyArmy.ToString() + " бійців\n" + orgEnemyArmy.ToString() + "% організації\n" + boyDuhEnemyArmy.ToString() + "% бойового духу";
                OurDataTxt.GetComponent<TextLanguage>().textEng = kilkOurArmy.ToString() + " soldiers\n" + orgOurArmy.ToString() + "% organizations\n" + boyDuhOurArmy.ToString() + "% fighting spirit";
                EnemyDataTxt.GetComponent<TextLanguage>().textEng = kilkEnemyArmy.ToString() + " soldiers\n" + orgEnemyArmy.ToString() + "% organizations\n" + boyDuhEnemyArmy.ToString() + "% fighting spirit";

                le = Random.Range(0, 2);
                Debug.Log(le);
                ce = Random.Range(0, 2);
                Debug.Log(ce);
                re = Random.Range(0, 2);
                Debug.Log(re);

                bool isEnd = false;
                bool isOurWin = false;

                if (orgEnemyArmy < 20 || boyDuhEnemyArmy < 20)
                {
                    resultTxt.text = "Ворог поніс великі втрати і відступає.";
                    resultTxt.GetComponent<TextLanguage>().textUkr = "Ворог поніс великі втрати і відступає.";
                    resultTxt.GetComponent<TextLanguage>().textEng = "The enemy has suffered heavy losses and is retreating.";
                    isEnd = true;
                    isOurWin = true;
                }
                if (orgOurArmy < 20 || boyDuhOurArmy < 20)
                {
                    resultTxt.text = "Ми понесли великі втрати і відступаємо.";
                    resultTxt.GetComponent<TextLanguage>().textUkr = "Ми понесли великі втрати і відступаємо.";
                    resultTxt.GetComponent<TextLanguage>().textEng = "We have suffered heavy losses and are retreating.";
                    isEnd = true;
                    isOurWin = false;
                }
                if (kilkEnemyArmy <= 0)
                {
                    resultTxt.text = "Ворожа армія повністю знищена.";
                    resultTxt.GetComponent<TextLanguage>().textUkr = "Ворожа армія повністю знищена.";
                    resultTxt.GetComponent<TextLanguage>().textEng = "The enemy army is completely destroyed.";
                    isEnd = true;
                    isOurWin = true;
                }
                if (kilkOurArmy <= 0)
                {
                    resultTxt.text = "Наша армія повністю знищена.";
                    resultTxt.GetComponent<TextLanguage>().textUkr = "Наша армія повністю знищена.";
                    resultTxt.GetComponent<TextLanguage>().textEng = "The your army is completely destroyed.";
                    isEnd = true;
                    isOurWin = false;
                }

                if (isEnd)
                {
                    PlayerPrefs.SetString("OurLeader", "");
                    PlayerPrefs.SetString("EnemyLeader", "");
                    PlayerPrefs.SetInt("OurArmy", 0);
                    PlayerPrefs.SetInt("EnemyArmy", 0);
                    PlayerPrefs.SetInt("OurOrg", 0);
                    PlayerPrefs.SetInt("EnemyOrg", 0);
                    PlayerPrefs.SetInt("OurBoyDuh", 0);
                    PlayerPrefs.SetInt("EnemyBoyDuh", 0);

                    Game game = load.LoadPlayersInfo();
                    if (game != null)
                    {
                        int idLev = PlayerPrefs.GetInt("Level");
                        int idCount = PlayerPrefs.GetInt("Country");

                        game.Levels[idLev].CountriesOpen[idCount].Parametrs[5].Value = kilkOurArmy;
                        game.Levels[idLev].CountriesOpen[idCount].Parametrs[4].Value += 50;
                    }

                    save.SavePlayers(game);

                    if (isOurWin)
                    {
                        PlayerPrefs.SetString("WhoWin", "our");
                    }
                    if (!isOurWin)
                    {
                        PlayerPrefs.SetString("WhoWin", "enemy");
                    }

                    a++;
                }

                ProvideEnemyPlansHintWithError(le, ce, re);
            }
        }

        void ProvideEnemyPlansHintWithError(int le, int ce, int re)
        {
            string hint = "Розвідка повідомляє (з імовірністю помилки): ";
            string hintEng = "Intelligence reports (with a probability of error): ";

            if (Random.value > 0.4f)
            {
                hint += le == 0 ? "ворог готує атаку на лівому фланзі; " : le == 1 ? "ворог укріплює оборону на лівому фланзі; " : "ворог планує штурм на лівому фланзі; ";
                hintEng += le == 0 ? "the enemy is preparing an attack on the left flank; " : le == 1 ? "the enemy strengthens the defense on the left flank; " : "the enemy is planning an assault on the left flank; ";
            }
            else
            {
                hint += "невідомо, що планує ворог на лівому фланзі; ";
                hintEng += "it is not known what the enemy is planning on the left flank; ";
            }

            if (Random.value > 0.4f)
            {
                hint += ce == 0 ? "ворог готує атаку в центрі; " : ce == 1 ? "ворог зміцнює оборону в центрі; " : "ворог планує штурм у центрі; ";
                hintEng += ce == 0 ? "the enemy is preparing an attack on the center; " : ce == 1 ? "the enemy strengthens the defense on the center; " : "the enemy is planning an assault on the center; ";
            }
            else
            {
                hint += "невідомо, що планує ворог у центрі; ";
                hintEng += "it is not known what the enemy is planning on the center; ";
            }

            if (Random.value > 0.4f)
            {
                hint += re == 0 ? "ворог готує атаку на правому фланзі." : re == 1 ? "ворог укріплює оборону на правому фланзі." : "ворог планує штурм на правому фланзі.";
                hintEng += re == 0 ? "the enemy is preparing an attack on the right flank;" : re == 1 ? "the enemy strengthens the defense on the right flank;" : "the enemy is planning an assault on the right flank;";
            }
            else
            {
                hint += "невідомо, що планує ворог на правому фланзі.";
                hintEng += "it is not known what the enemy is planning on the right flank;";
            }

            hintTxt.text = hint;
            hintTxt.GetComponent<TextLanguage>().textUkr = hint;
            hintTxt.GetComponent<TextLanguage>().textEng = hintEng;
            Debug.Log(hint);
            Debug.Log(hintEng);
        }
    }
}