﻿using Assets.Scripts.Clasess;
using Assets.Scripts.Clasess.Chois;
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
                    NameEng = "The period of the Kyiv state",
                    Description = "Олег став правителем Київської держави після того, як завоював Київ, вигнавши Аскольда і Діра, ймовірно, через внутрішні суперечки і нестабільність їхнього правління. Олег спочатку був регентом для малолітнього сина Аскольда, Ігоря, і взяв під контроль місто. Він встановив стабільну владу, зміцнивши союз з новгородцями та поширивши свою політичну і військову впливовість на території Русі.",
                    DescriptionEng = "Oleg became the ruler of the Kyivan state after conquering Kyiv, expelling Askold and Dir, probably due to internal disputes and the instability of their rule. Oleg was initially regent for Askold's young son, Igor, and took control of the city. He established stable power, strengthening the alliance with the Novgorodians and spreading his political and military influence on the territory of Rus.",
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
                            },
                            Turns = new List<Turn>
                            {
                                new Turn()
                                {
                                    Id = 0,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Ти вже захопив Київ, зробив його серцем нової держави, але тепер тобі необхідно поширити свою владу далі на південь і захід. Плем'я древлян — ключ до зміцнення твоєї позиції. Вони володіють багатими землями, густими лісами та важливими торговими шляхами. Однак їхня незалежність і відмова сплачувати данину — це виклик твоїй владі, а також загроза стабільності новоствореного об'єднання.",
                                            TextEng = "You have already captured Kyiv, made it the heart of the new state, but now you need to extend your power further to the south and west. The Drevlian tribe is the key to strengthening your position. They have rich lands, dense forests and important trade routes. However, their independence and refusal to pay tribute is a challenge to your authority, as well as a threat to the stability of the newly formed association."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Древляни досі платили данину хозарам, але тепер ти маєш замінити хозарів. Це зміцнить економічну базу твоєї держави та покаже іншим племенам силу твоєї влади: «Не давайте хозарам, але мені давайте». Також, землі древлян розташовані на шляху з півночі на захід, це важливий перехід між Дніпром та західними землями. Якщо вони підкоряться тобі, ти зможеш використовувати ці землі для походів далі на захід і підкорення нових територій.",
                                            TextEng = "The Drevlians still paid tribute to the Khazars, but now you must replace the Khazars. This will strengthen the economic base of your state and show other tribes the strength of your power: \"Don't give to the Khazars, but give to me.\" Also, the lands of the Drevlians are located on the way from the north to the west, this is an important transition between the Dnieper and the western lands. If they submit to you, you can use these lands to march further west and conquer new territories."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Армія древлян не велика за чисельністю, але небезпечна завдяки своїм знанням місцевості та вмінню використовувати природні укріплення лісів. Їхнє ополчення налічує приблизно 3–5 тисяч воїнів, озброєних луками, сокирами та дротиками. Основу їхніх сил складають селяни-ополченці, які звикли боронити свої землі від сусідніх племен.",
                                            TextEng = "The Drevlian army is not large in number, but dangerous due to its knowledge of the area and the ability to use the natural fortifications of the forests. Their militia numbers approximately 3,000 to 5,000 warriors armed with bows, axes, and darts. The basis of their forces are militia peasants who are used to defending their lands from neighboring tribes."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Проте їхня слабкість — це відсутність єдиного командування та стратегічного мислення. Вони звикли діяти розосереджено, тому твоя дисциплінована дружина, підкріплена кіннотою та варязькою піхотою, здатна швидко розгромити їх у відкритій битві.",
                                            TextEng = "However, their weakness is the lack of unified command and strategic thinking. They are used to operating in a dispersed manner, so your disciplined wife, supported by cavalry and Varangian infantry, can quickly defeat them in an open battle."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Підготовка до походу",
                                        Description = "З Києва ти вже розіслав вістунів по всіх землях півночі, збираючи під свої знамена дружинників з Новгорода, Смоленська та інших міст. Твоя мета — підкорити древлян і змусити їх сплачувати данину Києву. Ти знаєш, що це плем’я відоме своєю войовничістю, але їхні укріплення — це лише ліси й болотяні перепони, а не кам’яні стіни. Тому перший крок — зібрати силу, яка зможе здолати їхній опір.",
                                        DescriptionEng = "From Kyiv, you have already sent messengers to all the lands of the north, gathering soldiers from Novgorod, Smolensk and other cities under your banner. Your goal is to conquer the Drevlians and force them to pay tribute to Kyiv. You know that this tribe is known for its wariness, but their fortifications are only forests and marshy barriers, not stone walls. Therefore, the first step is to gather a force that can overcome their resistance.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 1,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Великий княже Олегу!\nТи вже підготувався до походу на древлян, зібравши велику дружину, підготувавши флотилію на Дніпрі та залучивши союзників зі слов’янських племен. Твоє військо вирушає з Києва у напрямку Іскоростеня, щоб примусити древлян визнати твою владу та сплачувати данину Києву замість хозарів.",
                                            TextEng = "Great Prince Oleg!\nYou have already prepared for the campaign against the Drevlians, gathering a large army, preparing a flotilla on the Dnieper and attracting allies from the Slavic tribes. Your army is leaving Kyiv in the direction of Iskorosten to force the Drevlians to recognize your authority and pay tribute to Kyiv instead of the Khazars."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Ти вирушив на початку весни 883 року, коли річки вже розлилися після зими, але шляхи ще не заросли густим лісом. Твоя флотилія пливе вниз по Дніпру, а за нею крокує піхота та кіннота через густі ліси Полісся. Древляни спробували створити засідки, використовуючи болотяні місця та природні перепони, але твоя розвідка вчасно виявила ці пастки. Ти обрав обхідний шлях, уникнувши втрат і заощадивши час.",
                                            TextEng = "You set out in the early spring of 883, when the rivers had already overflowed after the winter, but the paths were not yet overgrown with dense forest. Your flotilla sails down the Dnieper, followed by infantry and cavalry through the dense forests of Polissia. The Drevlians tried to set up ambushes, using swampy areas and natural obstacles, but your reconnaissance detected these traps in time. You chose a detour, avoiding losses and saving time."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Ти стоїш перед вирішальним моментом походу на древлян — облогою Іскоростеня. Саме зараз твоя здатність командувати військом і приймати швидкі рішення буде випробувана. Це місто — останній оплот древлянського опору, і його падіння засвідчить твою непохитну владу. Щоб успішно взяти місто, тобі слід врахувати декілька ключових моментів і продумати тактику атаки.",
                                            TextEng = "You are facing the decisive moment of the campaign against the Drevlyans - the siege of Iskorosten. Right now, your ability to command troops and make quick decisions will be tested. This city is the last stronghold of the Drevlyan resistance, and its fall will testify to your steadfast power. In order to successfully take the city, you should consider several key points and think through the tactics of the attack."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Облога Іскоростення",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Бій"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість ворожої армії",
                                                Value = 5000
                                            },
                                            new Parametrs()
                                            {
                                                Id = 2,
                                                Name = "Бойовий дух ворожої армії",
                                                Value = 50
                                            },
                                            new Parametrs()
                                            {
                                                Id = 3,
                                                Name = "Організація ворожої армії",
                                                Value = 30
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Oleg"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "default"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 83
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 2,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Великий княже Олегу!\r\n\r\nТвоя перемога над древлянами завершилася блискучим тріумфом. Іскоростень, головне місто древлян, впало перед твоєю військовою майстерністю і стратегією, а древляни визнали твою владу та схилили голову перед Києвом. Ця перемога стала ще однією славною сторінкою у твоїй кар’єрі володаря та завойовника.",
                                            TextEng = "Great Prince Oleg!\r\n\r\nYour victory over the Drevlians ended in a brilliant triumph. Iskorosten, the main city of the Drevlians, fell before your military skill and strategy, and the Drevlians recognized your authority and bowed their heads to Kiev. This victory became another glorious page in your career as a ruler and conqueror."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Ти продемонстрував мудрість великого правителя, не знищивши місто дощенту, але наказавши залишити мешканців живими. Древляни присягнули на вірність тобі, зобов’язалися щорічно сплачувати данину Києву медом, хутром та іншими цінними товарами. Цей жест не лише підкорив їхню волю, але й забезпечив стабільність у регіоні.\r\n\r\nТвоя перемога над древлянами підняла твій авторитет серед інших племен, які тепер бачать тебе як володаря всієї Русі, здатного здолати будь-якого ворога. Здобич і данина збагатили скарбницю Києва, а нові воїни поповнили ряди твоєї дружини.",
                                            TextEng = "You showed the wisdom of a great ruler, not destroying the city to the ground, but ordering to leave the inhabitants alive. The people of Drevlya swore allegiance to you, pledged to pay tribute to Kyiv annually with honey, fur and other valuable goods. This gesture not only conquered their will, but also ensured stability in the region.\r\n\r\nYour victory over the Drevlians raised your authority among other tribes, who now see you as the ruler of all of Russia, capable of defeating any enemy. Booty and tribute enriched the treasury of Kyiv, and new soldiers joined the ranks of your wife."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Перемога над древлянами принесла не лише територіальні та економічні вигоди, але й зміцнила військову міць Київської Русі. Підкорення цього племені дозволило тобі, великий княже Олегу, залучити місцевих ополченців і воїнів до складу своєї дружини. Багато древлянських чоловіків, які ще недавно тримали зброю проти тебе, тепер стали частиною твоїх військових сил. Це рішення було мудрим стратегічним кроком, оскільки ти не лише посилив армію, але й зменшив потенційну загрозу з боку повстань серед підкореного населення.",
                                            TextEng = "The victory over the Drevlians brought not only territorial and economic benefits, but also strengthened the military power of Kyivan Rus. The subjugation of this tribe allowed you, Grand Duke Oleg, to attract local militiamen and warriors to the composition of your wife. Many Drevlyan men who until recently took up arms against you have now become part of your military forces. This decision was a wise strategic move, as you not only strengthened the army, but also reduced the potential threat of rebellions among the conquered population."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Кінець 883",
                                        Description = "Ось і кінець 883 року, великий княже Олегу!\n\n Але неподаліік є ще одне плем'я котре є під впливом хозарів. Сіверяни, одне з потужних слов’янських племен, ще не визнали твоєї влади. Їхні землі розташовані на північному сході, вздовж приток Десни й Сейму, і мають стратегічне значення для зміцнення впливу Києва. Вони сплачують данину хозарам, і це неприйнятно для єдності Русі. Щоб підготуватися до походу проти них, ти маєш ретельно спланувати кожен крок.",
                                        DescriptionEng = "This is the end of the year 883, Grand Duke Oleg!\n\n But nearby there is another tribe that is under the influence of the Khazars. The Severians, one of the powerful Slavic tribes, have not yet recognized your authority. Their lands are located in the northeast, along the tributaries of the Desna and Seim rivers, and are of strategic importance for strengthening Kyiv's influence. They pay tribute to the Khazars, and this is unacceptable for the unity of Russia. To prepare for the campaign against them, you have to carefully plan every step.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 93
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 1500
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 3,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Олегу Віщий, наша сила і влада потребують постійного зміцнення, і для цього нам потрібно мобілізувати всі наявні ресурси для наступного походу проти сіверян. Цей похід — не просто завоювання нових земель, але й необхідність продемонструвати решті слов’янських племен, що Київська Русь є незаперечним лідером на цих теренах. Для цього потрібно не лише покладатися на дружину, а й залучити місцеві сили, створити потужну армію, яка здатна подолати будь-який опір.",
                                            TextEng = "Oleg Vishchy, our strength and power need constant strengthening, and for this we need to mobilize all available resources for the next campaign against the northerners. This campaign is not just the conquest of new lands, but also the need to demonstrate to the rest of the Slavic tribes that Kyivan Rus is the undisputed leader in these areas. For this, it is necessary not only to rely on the wife, but also to attract local forces, to create a powerful army capable of overcoming any resistance."
                                        }
                                    },
                                    Choises = new List<Choise>
                                    {
                                        new Choise()
                                        {
                                            Id = 0,
                                            Name = "Мобілізація",
                                            Elements = new List<ElementChoise>
                                            {
                                                new ElementChoise()
                                                {
                                                    Id = 0,
                                                    Name = "Мобілізувати населення",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 11000
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 1,
                                                            Name = "Підтримка народу",
                                                            Description = parametrs[2].Description,
                                                            Value = -10
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 2,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -150
                                                        },
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 1,
                                                    Name = "Не проводити мобілізацію"
                                                }
                                            }
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Підготовка",
                                        Description = "Олегу Віщий, твоя підготовка до походу завершена!\r\n\r\nТабори наповнені гомоном воїнів, які перевіряють зброю та спорядження. У кованих мечах блищить загартована сталь, стріли загострені й готові пронизати навіть найміцніший обладунок. Твої дружинники, досвідчені й загартовані в битвах, піднесені духом і готові до нових подвигів. Зібране ополчення з древлян і полян, хоча й менш досвідчене, та все ж сповнене рішучості підтримати свого князя. Коли настане світанок, твоя армія виступить у похід. Цей день стане початком нової сторінки в історії Київської Русі. Твоє військо, як непереможна хвиля, рушить уперед, аби зміцнити твою владу, об’єднати руські землі та принести Києву нові здобутки.",
                                        DescriptionEng = "Oleg Vishchy, your preparations for the campaign are complete!\r\n\r\nThe camps are filled with the noise of soldiers checking weapons and equipment. Forged swords gleam with hardened steel, arrows sharpened and ready to pierce even the strongest armor. Your soldiers, experienced and hardened in battles, are high in spirit and ready for new exploits. The assembled militia from the Drevlians and Polyans, although less experienced, is still determined to support their prince. When dawn comes, your army will march. This day will be the beginning of a new page in the history of Kyivan Rus. Your army, like an invincible wave, is moving forward to strengthen your power, unite the Russian lands and bring new gains to Kyiv.",
                                        Result = new List<Parametrs>()
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            }
                                        }
                                    }
                                }
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
            PlayerPrefs.SetString("OurLeader", "");
            PlayerPrefs.SetString("EnemyLeader", "");
            PlayerPrefs.SetInt("OurArmy", 0);
            PlayerPrefs.SetInt("EnemyArmy", 0);
            PlayerPrefs.SetInt("OurOrg", 0);
            PlayerPrefs.SetInt("EnemyOrg", 0);
            PlayerPrefs.SetInt("OurBoyDuh", 0);
            PlayerPrefs.SetInt("EnemyBoyDuh", 0);
        }
    }
}