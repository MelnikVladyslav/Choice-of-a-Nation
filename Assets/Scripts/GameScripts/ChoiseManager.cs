using Assets.Scripts.Clasess;
using Assets.Scripts.Clasess.Levels;
using Assets.Scripts.Menu.Settings.Localization;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GameScripts
{
    public class ChoiseManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        Game game = new Game();
        bool isOpen = false;

        public GameObject choisePr;
        public GameObject contentPar;

        public Text nameChoises;
        Text choise;
        Button choiseBtn;

        int idLev, idCoun, idTurn;

        // Use this for initialization
        void Start()
        {
            isOpen = true;
            game = load.LoadStartInfo();
            idLev = PlayerPrefs.GetInt("Level");
            idCoun = PlayerPrefs.GetInt("Country");
            idTurn = PlayerPrefs.GetInt("Turn");
        }

        // Update is called once per frame
        void Update()
        {
            if (isOpen)
            {
                idLev = PlayerPrefs.GetInt("Level");
                idCoun = PlayerPrefs.GetInt("Country");
                idTurn = PlayerPrefs.GetInt("Turn");
                Debug.Log(idTurn + " turn");

                if (game.Levels[idLev].CountriesOpen[idCoun].Turns[idTurn].Choises.Count > 0)
                {
                    foreach (Transform child in contentPar.transform)
                    {
                        Destroy(child.gameObject);
                    }
                    for (int i = 0; i < game.Levels[idLev].CountriesOpen[idCoun].Turns[idTurn].Choises[0].Elements.Count; i++)
                    {
                        GameObject curEff = Instantiate(choisePr, contentPar.transform);
                        curEff.transform.position = new Vector3(curEff.transform.position.x, curEff.transform.position.y - (2 * i), curEff.transform.position.z);

                        nameChoises.text = game.Levels[idLev].CountriesOpen[idCoun].Turns[idTurn].Choises[0].Name;

                        int a = i;

                        choiseBtn = curEff.GetComponent<Button>();
                        choiseBtn.GetComponentInChildren<Text>().text = game.Levels[idLev].CountriesOpen[idCoun].Turns[idTurn].Choises[0].Elements[i].Name;
                        choiseBtn.onClick.AddListener(() => ResultChoise(a));
                    }
                    isOpen = false;
                }
            }
        }

        void ResultChoise(int id)
        {
            PlayerPrefs.SetInt("EnterChoise", id);
            Debug.Log("choise " + id);
        }
    }
}