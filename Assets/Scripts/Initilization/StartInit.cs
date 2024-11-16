﻿using Assets.Scripts.Clasess;
using Assets.Scripts.Clasess.Levels;
using Assets.Scripts.Clasess.Profile;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Initilization
{
    public class StartInit : MonoBehaviour
    {
        public List<Parametrs> InitParam()
        {
            return new List<Parametrs>()
            {
                new Parametrs()
                {
                    Id = 0,
                    Name = "Підтримка еліти",
                    Description = "Підтримка еліти — це ключовий параметр, що визначає рівень впливу соціальної та політичної еліти на армію. Висока підтримка еліти забезпечує армії кращу організацію, більш ефективне командування та доступ до передових тактичних і технологічних нововведень. Еліта може сприяти фінансуванню армії, забезпеченню ресурсами та вербуванню елітних підрозділів, що в свою чергу підвищує боєздатність і мобільність війська.\r\n\r\nОднак низький рівень підтримки еліти може призвести до погіршення морального стану військ, зменшення фінансування і навіть до виникнення внутрішніх конфліктів, що ускладнює ефективне керування армією. Враховуючи її значення, важливо підтримувати баланс між вимогами еліти та інтересами народу, аби не дати можливість розколоти внутрішню стабільність держави.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 1,
                    Name = "Підтримка армії",
                    Description = "Підтримка армії – цей параметр визначає рівень моральної та матеріальної підтримки, яку отримує ваша армія від населення, уряду та інших союзників. Високий рівень підтримки значно підвищує бойовий дух солдатів, мотивуючи їх до подвигів на полі бою, покращуючи ефективність у боях та знижуючи ймовірність дезертирства. Навпаки, низька підтримка може призвести до зниження морального стану, що негативно впливатиме на швидкість руху армії, точність атак і здатність витримувати довготривалі бої. Підтримка може змінюватися в залежності від внутрішньополітичної ситуації, економічного становища та результатів попередніх битв.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 2,
                    Name = "Підтримка народу",
                    Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 3,
                    Name = "Стан армії",
                    Description = "Стан армії — цей параметр визначає бойову готовність та моральний стан військових сил вашої нації. Він включає в себе декілька факторів, таких як рівень підготовки солдатів, наявність зброї та техніки, а також мораль і дисципліну в рядах армії. Високий рівень стану армії свідчить про добре оснащені та мотивовані війська, здатні ефективно вести бойові дії. Низький рівень, навпаки, може призвести до втрат у битвах, зниження моралі та навіть до бунтів серед військових.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 4,
                    Name = "Скарбниця",
                    Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 5,
                    Name = "Кількість нашої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 6,
                    Name = "Кількість ворожої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 7,
                    Name = "Бойовий дух нашої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 8,
                    Name = "Бойовий дух ворожої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 9,
                    Name = "Організація нашої армії",
                    Description = "",
                    Value = 0
                },
                new Parametrs()
                {
                    Id = 10,
                    Name = "Організація ворожої армії",
                    Description = "",
                    Value = 0
                },
            };
        }

        public List<Level> InitLevels(List<Parametrs> parametrs)
        {
            return new List<Level>
            {
                new Level()
                {
                    Id = 0,
                    Name = "Період Київської держави",
                    Description = "Олег став правителем Київської держави після того, як завоював Київ, вигнавши Аскольда і Діра, ймовірно, через внутрішні суперечки і нестабільність їхнього правління. Олег спочатку був регентом для малолітнього сина Аскольда, Ігоря, і взяв під контроль місто. Він встановив стабільну владу, зміцнивши союз з новгородцями та поширивши свою політичну і військову впливовість на території Русі.",
                    YearStart = 882,
                    CountriesOpen = new List<Country>()
                    {
                        new Country()
                        {
                            Id = 0,
                            Name = "Київська держава",
                            Description = "Київська держава — це середньовічне об'єднання східнослов'янських племен, яке існувало з кінця IX століття до середини XIII століття. Київ, столиця держави, став важливим політичним, економічним і культурним центром. Держава розвивалась під впливом варязьких правителів, таких як Рюрик і Олег, і здобула значну незалежність після укладення договорів з Візантією. Русь досягла розквіту за князювання Володимира Великого та Ярослава Мудрого, активно розвиваючи християнство, торгівлю і дипломатичні зв'язки.",
                            NameLeader = "Олег",
                            UrlLeader = "Oleg",
                            Parametrs = new List<Parametrs>
                            {
                                new Parametrs
                                {
                                    Id = 0,
                                    Name = parametrs[0].Name,
                                    Description = parametrs[0].Description,
                                    Value = 60
                                },
                                new Parametrs
                                {
                                    Id = 1,
                                    Name = parametrs[1].Name,
                                    Description = parametrs[1].Description,
                                    Value = 50
                                },
                                new Parametrs
                                {
                                    Id = 2,
                                    Name = parametrs[2].Name,
                                    Description = parametrs[2].Description,
                                    Value = 60
                                },
                                new Parametrs
                                {
                                    Id = 3,
                                    Name = parametrs[3].Name,
                                    Description = parametrs[3].Description,
                                    Value = 50
                                },
                                new Parametrs
                                {
                                    Id = 4,
                                    Name = parametrs[4].Name,
                                    Description = parametrs[4].Description,
                                    Value = 83
                                },
                                new Parametrs
                                {
                                    Id = 5,
                                    Name = parametrs[5].Name,
                                    Description = parametrs[5].Description,
                                    Value = 11000
                                },
                            }
                        }
                    }
                }
            };
        }

        public Game InitGame(List<Level> levels)
        {
            return new Game()
            {
                Id = 0,
                PlayerData = new Player()
                {
                    Id = 0,
                    Name = "Default Name",
                    Email = "",
                    AchievementsOpen = new List<Achievements>()
                },
                Levels = levels,
                Achievements = new List<Achievements>()
            };
        }

        private void Start()
        {
            List<Parametrs> parametrs = new List<Parametrs>();
            List<Level> levels = new List<Level>();

            parametrs = InitParam();
            levels = InitLevels(parametrs);

            Game game = InitGame(levels);
            Save save = new Save();
            save.SaveStartGame(game);
        }
    }
}