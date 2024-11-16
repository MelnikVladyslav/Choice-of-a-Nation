using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Menu.Settings.Localization
{
    public class LocalizationManager : MonoBehaviour
    {
        public void Ukr()
        {
            string language = "Ukr";
            PlayerPrefs.SetString("Language", language);
        }

        public void Eng()
        {
            string language = "Eng";
            PlayerPrefs.SetString("Language", language);
        }
    }
}