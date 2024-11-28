using Assets.Scripts.Clasess;
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
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
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
                                },
                                new Turn()
                                {
                                    Id = 4,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Олегу Віщий, твій похід проти сіверян став проявом мудрості, сили й стратегічного мистецтва. Коли твоє військо залишило Київ, потужний потік зброєносців і ополченців рушив уздовж Дніпра, прямуючи до земель сіверян. У кожному кроці відчувалась мета — розширення влади й об’єднання слов’янських земель під твоїм правлінням.",
                                            TextEng = "Oleg Vischy, your campaign against the northerners was a manifestation of wisdom, strength and strategic art. When your army left Kyiv, a powerful stream of gunmen and militia moved along the Dnieper, heading for the lands of the northerners. In every step, the goal was felt - the expansion of power and the unification of the Slavic lands under your rule."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "На підступах до сіверянських укріплень відчувалася напруга. Місцеві племена зібралися, щоб захистити свою землю, але твоя армія була сильнішою. Перші зіткнення на околицях сіверянських поселень показали їхню рішучість, та твої дружинники, зміцнені попередніми перемогами, зламали цей спротив.",
                                            TextEng = "Tension was felt on the approaches to the northern fortifications. The local tribes gathered to defend their land, but your army was stronger. The first clashes on the outskirts of the northern settlements showed their determination, and your soldiers, strengthened by previous victories, broke this resistance."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Олегу Віщий, битва вже близько, і кожна деталь твоєї підготовки вплине на її результат. Ти стоїш перед вирішальним моментом, коли сила, мудрість і віра в перемогу об’єднаються в один могутній удар.\r\n\r\nТвоя армія готується до останнього кроку — облоги головного укріплення сіверян. Ти особисто перевіряєш все: від готовності лучників до стану облогових машин. Дерев’яні тарани стоять напоготові, їхнє дерево скрипить під натиском твоїх дружинників, які тренуються розбивати ворота. Металеві наконечники стріл блищать на сонці, готові розпочати нищівний обстріл. На світанку ти даєш сигнал. Облогові машини рухаються вперед, тарани розгойдуються під натиском дружинників, а в небі з’являється перший дощ із палаючих стріл. Битва починається, і ти, Олегу, стоїш на передовій, ведучи своїх людей до ще однієї славетної перемоги.",
                                            TextEng = "Oleg Vishchy, the battle is near, and every detail of your preparation will affect its outcome. You are facing a decisive moment, when strength, wisdom and faith in victory will unite in one powerful blow.\r\n\r\nYour army is preparing for the last step - the siege of the main stronghold of the northerners. You personally check everything: from the readiness of archers to the condition of siege engines. The wooden battering rams stand at the ready, their wood creaking under the onslaught of your squires, who are trained to break down gates. Metal arrowheads glisten in the sun, ready to launch a devastating barrage. At dawn you give the signal. The siege machines move forward, the battering rams swing under the onslaught of the soldiers, and the first rain of flaming arrows appears in the sky. The battle begins, and you, Oleg, stand on the front line, leading your men to another glorious victory."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Облога укріплень сіверян",
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
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 5,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Олегу Віщий, твоє завоювання сіверян не стало лише перемогою меча — це був початок нової епохи єдності та могутності Русі.\r\n\r\nПісля тріумфу твої воїни увійшли до землі сіверян як господарі, але з мудрістю та далекоглядністю ти не прагнув знищити цих людей. Ти наказав зібрати їхніх старійшин, щоб укласти мир і домовитися про їхню нову роль у Русі. Сіверяни, вражені твоєю силою та стратегією, прийняли твої умови, визнавши владу Києва.",
                                            TextEng = "Oleg Vishchy, your conquest of the northerners was not only a victory of the sword - it was the beginning of a new era of unity and power of Russia.\r\n\r\nAfter the triumph, your warriors entered the land of the Northmen as masters, but with wisdom and foresight you did not seek to destroy these people. You ordered to gather their elders to make peace and agree on their new role in Russia. The northerners, impressed by your strength and strategy, accepted your terms, recognizing the authority of Kyiv."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Землі сіверян тепер стали частиною твоєї держави. Ти встановив чіткі правила данини, яка тепер ішла не до хозарів, а до Києва. Це не лише підривало вплив ворога, але й посилювало твій авторитет серед інших племен. Відтепер твої ресурси зросли, скарбниця наповнювалася, а землі стали важливим щитом між Київською державою та кочівниками.\r\n\r\nНе зупиняючись на цьому, ти побачив у сіверянах нову силу для свого війська. Ти залучив їхніх найкращих воїнів до дружини, підготувавши їх до майбутніх походів. Їхні руки, які ще недавно тримали зброю проти тебе, тепер тримали мечі за тебе. Завдяки цьому твоє військо стало ще чисельнішим і сильнішим.",
                                            TextEng = "The lands of the northerners have now become part of your state. You established clear rules for the tribute, which now went not to the Khazars, but to Kyiv. This not only undermined the influence of the enemy, but also strengthened your authority among other tribes. From now on, your resources increased, the treasury was filled, and the lands became an important shield between the Kyivan state and the nomads.\r\n\r\nNot stopping at this, you saw in the northerners a new strength for your army. You brought their best warriors to wife, preparing them for the coming campaigns. Their hands, which not long ago held weapons against you, now held swords for you. Thanks to this, your army became even more numerous and stronger."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Однак, Олегу, це була не лише перемога зброї, але й перемога духу. Ти показав усій Русі, що під твоєю владою різні племена можуть об’єднатися в одну могутню державу, яка диктує свої умови ворогам. Сіверяни, відчувши твою силу й справедливість, стали частиною цього великого об’єднання.\r\n\r\nІ ось ти стоїш, дивлячись на свої нові володіння, впевнений, що ця перемога стане лише початком для ще більших звершень. Бо Київ тепер — не лише центр влади, а й серце землі, що прагне до єдності й слави.",
                                            TextEng = "However, Oleg, it was not only a victory of weapons, but also a victory of the spirit. You showed all of Russia that under your rule different tribes can unite into one powerful state that dictates its terms to the enemies. Northerners, feeling your strength and justice, became part of this great union.\r\n\r\nAnd here you stand, looking at your new possessions, confident that this victory will be only the beginning of even greater achievements. Because Kyiv is now not only the center of power, but also the heart of the earth, striving for unity and glory."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
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
                                        Name = "Кінець 884",
                                        Description = "Ось і кінець 884 року, великий княже Олегу!\r\nТвої знамена вже майоріють над землями сіверян, а їхня данина тепер наповнює скарбницю Києва. Але на південному заході, вздовж приток Дністра й Прута, знаходиться плем’я тиверців. Їхні укріплені поселення й густі ліси створюють природний захист, але вони не можуть сховатися від твоєї далекоглядності.\r\nТиверці, як і сіверяни, перебувають під впливом Хозарського каганату, сплачуючи їм данину. Це ставить під загрозу твоє бачення єдності всіх слов’янських племен під Київською короною. Їхні землі — ключ до повного контролю над південними торговими шляхами, що ведуть до Чорного моря. Без цього Київ не зможе стати центром усієї Русі.\r\nЗимові дні вже принесли спокій у табори твоїх воїнів, але ти, Олегу, не знаєш відпочинку. Ти міркуєш, як краще провести новий похід. Важливо, щоб твої сили були підготовлені до гірських стежок і річкових переправ, які захищають ці землі. Ти розумієш, що підкорення тиверців не лише посилить Київ, але й підірве залишки хозарського впливу. Пора підняти прапор над цими землями, княже. Твоє ім’я має стати символом єдності й могутності, що веде Русь до слави!",
                                        DescriptionEng = "This is the end of the year 884, Grand Duke Oleg!\r\nYour banners already fly over the lands of the northerners, and their tribute now fills the treasury of Kyiv. But in the southwest, along the tributaries of the Dniester and Prut rivers, there is a tribe of Tivers. Their fortified settlements and dense forests provide natural protection, but they cannot hide from your foresight.\r\nThe Tiberians, like the Northerners, are under the influence of the Khazar Khaganate, paying tribute to them. This endangers your vision of the unity of all Slavic tribes under the Kyivan crown. Their lands are the key to complete control of the southern trade routes leading to the Black Sea. Without this, Kyiv will not be able to become the center of all of Rus.\r\nThe winter days have already brought peace to the camps of your soldiers, but you, Oleg, know no rest. You think about how best to spend a new campaign. It is important that your forces are prepared for the mountain trails and river crossings that protect these lands. You understand that conquering the Tiberians will not only strengthen Kyiv, but also undermine the remnants of Khazar influence. It's time to raise the flag over these lands, prince. Your name should become a symbol of unity and power, leading Rus' to glory!",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 103
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
                                    Id = 6,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Похід проти тиверців, великий княже Олегу, став наступним кроком у твоєму шляху до об’єднання всіх слов’янських племен під владою Києва. Ця кампанія була не лише воєнною, але й стратегічною та символічною — вона затверджувала твій авторитет як великого правителя Русі.",
                                            TextEng = "The campaign against the Tivertians, Grand Prince Oleg, was the next step on your path to uniting all Slavic tribes under the rule of Kyiv. This campaign was not only military, but also strategic and symbolic - it affirmed your authority as the great ruler of Rus."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Тиверці, захищені річками та гірськими стежками, покладалися на свої природні укріплення й досвід у партизанській війні. Вони були гордим народом, але залежність від Хозарського каганату зробила їх вразливими до зовнішнього впливу. Ти вирішив діяти швидко та рішуче, щоби захопити їхні землі й зламати хозарський контроль.\r\n\r\nТвій похід розпочався ранньою весною. Об’єднавши дружинників, ти провів їх через ліси й рівнини, використовуючи знання місцевості, зібрані твоїми розвідниками. Річки, які раніше служили тиверцям оборонним бар’єром, стали шляхами для твоїх легких човнів, що рухалися вгору по течії, доставляючи війська до самих укріплених поселень.",
                                            TextEng = "Protected by rivers and mountain passes, the Tiverts relied on their natural fortifications and their experience in guerrilla warfare. They were a proud people, but their dependence on the Khazar Khaganate made them vulnerable to outside influence. You decided to act quickly and decisively to seize their lands and break Khazar control.\r\n\r\nYour campaign began in early spring. Uniting your warriors, you led them through forests and plains, using the knowledge of the terrain gathered by your scouts. The rivers that had previously served as a defensive barrier for the Tiverts became the paths for your light boats, moving upstream, delivering troops to the most fortified settlements."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Звістка надійшла перед світанком, великий княже Олегу. Розвідники, які ризикували життям, пробираючись крізь болота й густі ліси, донесли, що головні сили тиверців зосереджені на західному березі Прута. Їхній табір стоїть серед природного укріплення — річка захищає з одного боку, густі хащі — з іншого. Вороги впевнені, що ця місцевість робить їх неприступними. Вони помиляються.",
                                            TextEng = "The news came before dawn, Grand Duke Oleg. The scouts, who risked their lives, making their way through the swamps and dense forests, reported that the main forces of the Tiverians were concentrated on the western bank of the Prut. Their camp is located among natural fortifications - the river protects on one side, dense thickets - on the other. The enemies are sure that this terrain makes them impregnable. They are mistaken."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Ти уважно слухаєш кожне слово розвідників. Їхні описи деталей — розташування сторожових постів, чисельність воїнів, наявність бродів через річку — малюють чітку картину. Тиверців близько п’яти тисяч. Вони під проводом місцевих ватажків, і це їхній недолік: бракує єдиного лідера, який міг би організувати справжню оборону.\r\n\r\nТи вирішуєш діяти негайно. Накази лунають швидко й чітко: дружина починає готуватися до маршу. Ти обираєш найкращих лучників для першого удару, який має спричинити паніку серед ворога. Піхота отримує наказ пробиватися через передній вал оборони, а кіннота займе обхідний маршрут через ліс, щоб замкнути ворога в кільце.",
                                            TextEng = "You listen carefully to every word the scouts say. Their descriptions of the details—the location of the guard posts, the number of soldiers, the presence of fords across the river—paint a clear picture. There are about five thousand Tivertians. They are led by local leaders, and this is their disadvantage: they lack a single leader who could organize a real defense.\r\n\r\nYou decide to act immediately. The orders come quickly and clearly: the squad begins to prepare for the march. You choose the best archers for the first strike, which is to cause panic among the enemy. The infantry is ordered to break through the front defense wall, while the cavalry will take a roundabout route through the forest to encircle the enemy."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Твоя присутність серед воїнів надихає. Вони бачать у тобі не лише князя, а й полководця, що йде з ними в бій. Ти обходиш лави, перевіряєш зброю, вислуховуєш останні поради старійшин дружини. Лучники поправляють тятиви, піхотинці перевіряють гостроту мечів і надійність щитів, кіннотники готують коней до швидкого маневру.\r\n\r\nТвій план чіткий, як стріла, що летить до цілі. Ти знаєш, що ця перемога не лише зламає опір тиверців, але й остаточно підкреслить силу Києва. Ти дивишся на горизонт, де ще ніч тримає небо, і знаєш: світанок принесе не лише новий день, а й нову славу для Русі.",
                                            TextEng = "Your presence among the warriors is inspiring. They see you not only as a prince, but also as a commander who is going into battle with them. You go around the ranks, inspect your weapons, and listen to the latest advice from the elders of the squad. Archers adjust their bowstrings, infantrymen check the sharpness of their swords and the reliability of their shields, and cavalrymen prepare their horses for a quick maneuver.\r\n\r\nYour plan is as clear as an arrow flying to its target. You know that this victory will not only break the resistance of the Tiverians, but will also finally emphasize the power of Kiev. You look at the horizon, where night still holds the sky, and you know: dawn will bring not only a new day, but also new glory for Rus."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Облога укріплень сіверян",
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
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 7,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Землі тиверців, багаті на родючі поля та зручні торгові шляхи, стали важливим додатком до Київської держави. Ти розпорядився встановити контроль над головними річковими шляхами, які пролягали через їхні території, забезпечуючи зв’язок між північчю та півднем. Це дозволило зміцнити торгівлю із землями на узбережжі Чорного моря й послабити залежність від хозарських шляхів.\r\n\r\nТиверці, визнавши твою владу, погодилися сплачувати данину Києву. Замість хозарів, їхні багатства тепер ішли на зміцнення твоєї держави. Але ти діяв не тільки силою: ти знав, що союз із тиверцями буде більш надійним, якщо вони відчують користь від твого правління. Ти дозволив їхнім старійшинам зберігати частину самоуправління, але під твоїм чітким наглядом.",
                                            TextEng = "The lands of the Tiverts, rich in fertile fields and convenient trade routes, became an important addition to the Kievan state. You ordered to establish control over the main river routes that ran through their territories, providing a connection between the north and the south. This allowed to strengthen trade with the lands on the Black Sea coast and to weaken dependence on the Khazar routes.\r\n\r\nThe Tiverts, recognizing your authority, agreed to pay tribute to Kiev. Instead of the Khazars, their wealth now went to strengthen your state. But you acted not only by force: you knew that the alliance with the Tiverts would be more reliable if they felt the benefits of your rule. You allowed their elders to retain some self-government, but under your strict supervision."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Щоб гарантувати лояльність, ти залишив частину своєї дружини для охорони ключових місць і водночас запропонував тиверським воїнам увійти до твоїх лав. Ті, хто ще вчора стояв проти тебе, тепер воювали на твоєму боці, готові брати участь у нових походах. Їхній досвід у партизанській війні став корисним у майбутніх кампаніях.\r\n\r\nЦя перемога мала значення не лише для Києва, а й для твоєї репутації серед інших слов’янських племен. Вони бачили, що під твоєю владою зникають внутрішні конфлікти й посилюється зовнішній захист. Київська Русь дедалі більше ставала не просто зібранням племен, а потужною державою, яка прагне до об’єднання всіх слов’ян.",
                                            TextEng = "To ensure loyalty, you left part of your squad to guard key places and at the same time invited the Tiver warriors to join your ranks. Those who had been against you yesterday were now fighting on your side, ready to take part in new campaigns. Their experience in guerrilla warfare became useful in future campaigns.\r\n\r\nThis victory was important not only for Kiev, but also for your reputation among other Slavic tribes. They saw that under your rule internal conflicts were disappearing and external protection was strengthening. Kievan Rus was increasingly becoming not just a gathering of tribes, but a powerful state striving to unite all Slavs."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Кінець 885 року",
                                        Description = "Тепер, коли тиверці визнали твою владу, твій погляд міг звернутися до нових цілей. Попереду лежали інші племена, а також могутні сусіди, які ще не відчули на собі силу твоєї держави. Цей успіх був лише черговим кроком на шляху до створення великої і єдиної Русі.",
                                        DescriptionEng = "Now that the Tyvets recognized your authority, your gaze could turn to new goals. Other tribes lay ahead, as well as powerful neighbors who had not yet felt the power of your state. This success was just another step on the path to creating a great and united Rus.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
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
                                    Id = 8,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Ти, великий княже Олегу, вирішив кинути виклик хозарському пануванню над радимичами. Ця підготовка була не лише військовою кампанією, але й стратегічним кроком, щоб закріпити владу Києва як центру сили на Русі.\r\n\r\nТвої радники доповіли, що радимичі досі платять данину хозарам, вбачаючи в них непереможну силу. Але ти, зібравши свою дружину, був переконаний: це питання не тільки честі, а й права. Землі радимичів розташовані у самому серці торговельних шляхів, і їхній контроль означав би значне підсилення твоєї влади.",
                                            TextEng = "You, Grand Prince Oleg, decided to challenge the Khazar rule over the Radimichs. This preparation was not only a military campaign, but also a strategic step to consolidate the power of Kiev as the center of power in Rus.\r\n\r\nYour advisors reported that the Radimichs still pay tribute to the Khazars, seeing in them an invincible force. But you, having gathered your squad, were convinced: this is not only a matter of honor, but also of right. The lands of the Radimichs are located in the very heart of trade routes, and their control would mean a significant strengthening of your power."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "До цієї кампанії ти підійшов ґрунтовно. Зима 884 року стала часом розвідки. Твої люди вирушили на північний схід, збираючи інформацію про місця зібрання радимичів, чисельність їхніх воїнів і оборонні споруди. Повернувшись із подробицями, вони підтвердили: радимичі мають силу, але їхня організація поступається твоїй армії.\r\n\r\nТи також звернувся до племен, які вже були під твоєю владою. Сіверяни, що стали вірними після минулої кампанії, надали додаткові загони, а також постачання для походу. З їхніх рядів було обрано провідників, які добре знали місцевість, що мала стати ареною бойових дій.",
                                            TextEng = "You approached this campaign thoroughly. The winter of 884 was a time of reconnaissance. Your men set out to the northeast, gathering information about the gathering places of the Radimichi, the number of their warriors, and the defensive structures. Returning with details, they confirmed: the Radimichi are strong, but their organization is inferior to your army.\r\n\r\nYou also turned to the tribes that were already under your rule. The northerners, who had become loyal after the previous campaign, provided additional detachments, as well as supplies for the campaign. Leaders were chosen from their ranks who knew well the terrain that was to become the arena of hostilities."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Перед початком походу ти провів раду з дружиною. Там обговорювали не лише військову стратегію, але й дипломатичні кроки після перемоги. Твій план був простий, але вражаючий: розбити радимичів у відкритому бою, але не знищувати їх повністю. Їхнє підкорення мало бути не лише військовим, а й символічним кроком до об’єднання Русі.\r\n\r\nКоли лід у річках почав танути, ти відчув, що час настав. Дружина зібралася на київських пагорбах, готова до великого походу. Воїни співали пісень, налаштовуючи себе на перемогу. Ти, великий княже, з мечем у руках піднявся на пагорб, дивлячись на тих, хто вирушить із тобою в цю доленосну подорож.",
                                            TextEng = "Before the campaign, you held a council with your wife. They discussed not only military strategy, but also diplomatic steps after the victory. Your plan was simple but impressive: to defeat the Radimichi in open battle, but not to destroy them completely. Their subjugation was to be not only military, but also a symbolic step towards the unification of Rus.\r\n\r\nWhen the ice in the rivers began to melt, you felt that the time had come. Your wife gathered on the Kiev hills, ready for a great campaign. The warriors sang songs, setting themselves up for victory. You, the great prince, climbed the hill with a sword in your hands, looking at those who would go with you on this fateful journey."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Підготовка до бою",
                                        Description = "Ти, великий княже, на чолі дружини наблизився до поселення на берегах річки Сож, де радимичі зібралися, сподіваючись зупинити твій похід. Звістка про те, що вони облаштовують укріплення, прийшла з розвідки, і ти негайно віддав наказ готуватися до битви.",
                                        DescriptionEng = "You, the Grand Duke, at the head of your army approached the settlement on the banks of the Sozh River, where the Radimichi had gathered, hoping to stop your march. The news that they were equipping fortifications came from reconnaissance, and you immediately gave the order to prepare for battle.",
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
                                    Id = 9,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Табір твоєї армії розташувався на пагорбі неподалік поселення. Це місце дозволяло спостерігати за рухами ворога та оцінювати їхні сили. У ніч перед боєм ти провів раду з воєводами. Були обговорені всі аспекти битви: можливі маневри ворога, використання місцевості для засідок, а також стратегія прориву оборонного рубежу радимичів.\r\n\r\nНа світанку твоя армія почала готуватися. Дружинники перевіряли свої мечі й списи, підганяли обладунки, напинали тятиви на луках. Ти особисто обійшов війська, підбадьорюючи своїх воїнів, які відчували твою рішучість і силу.",
                                            TextEng = "Your army camp was located on a hill near the settlement. This place allowed you to observe the enemy's movements and assess their strength. The night before the battle, you held a council with the voivodes. All aspects of the battle were discussed: possible enemy maneuvers, the use of the terrain for ambushes, as well as the strategy for breaking through the Radimichi defensive line.\r\n\r\nAt dawn, your army began to prepare. The cadets checked their swords and spears, adjusted their armor, and strung their bowstrings. You personally went around the troops, encouraging your soldiers, who felt your determination and strength."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Перед початком бою ти виступив перед військом. Твоя промова була короткою, але потужною. Ти нагадав воїнам, що вони захищають не лише Київську державу, а й честь Русі, об'єднуючи слов’янські землі під єдиним прапором. \"Хозари більше не будуть диктувати нашим братам, хто має бути їхнім господарем!\" — ці слова збурили дух дружинників, і вони були готові до боротьби. Коли сонце піднялося над горизонтом, твоє військо виступило.",
                                            TextEng = "Before the battle began, you addressed the army. Your speech was short but powerful. You reminded the soldiers that they were defending not only the Kievan state, but also the honor of Rus, uniting the Slavic lands under a single banner. \"The Khazars will no longer dictate to our brothers who should be their master!\" - these words stirred the spirit of the Druzhny warriors, and they were ready to fight. When the sun rose above the horizon, your army advanced."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Бій в Сожі",
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
                                                Value = 3000
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
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 10,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Після перемоги над радимичами, великий княже, настав час закріпити успіх і встановити новий порядок. Битва продемонструвала силу Києва та твою майстерність як воєначальника, але цього було недостатньо. Перемога мала бути не лише військовою, а й політичною.",
                                            TextEng = "After the victory over the Radimichs, Grand Duke, it was time to consolidate the success and establish a new order. The battle demonstrated the strength of Kyiv and your skill as a military leader, but this was not enough. The victory had to be not only military, but also political."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Старійшини радимичів, побачивши поразку свого війська, зрозуміли, що Київ є тією силою, яка змінить їхню долю. Вони зібралися на перемовини, і ти прийняв їх у своєму таборі. Говорили вони про збереження своїх традицій і звичаїв, але ти наполіг: вони мають припинити сплачувати данину хозарам і почати визнавати владу Києва. Це був не лише акт підкорення, а й символ звільнення від іноземного впливу.\r\n\r\nТи встановив новий порядок: радимичі мали платити данину Києву, але значно меншу, ніж та, яку вимагали хозари. Це стало першим кроком до зміцнення їхньої лояльності. Щоб закріпити новий союз, ти залишив свої гарнізони в ключових поселеннях і взяв із собою молодих радимичів у свою дружину, навчаючи їх київському військовому мистецтву.",
                                            TextEng = "The elders of the Radimichi, seeing the defeat of their army, realized that Kyiv was the force that would change their fate. They gathered for negotiations, and you received them in your camp. They talked about preserving their traditions and customs, but you insisted: they must stop paying tribute to the Khazars and begin to recognize the authority of Kyiv. This was not only an act of submission, but also a symbol of liberation from foreign influence.\r\n\r\nYou established a new order: the Radimichi were to pay tribute to Kyiv, but much less than the one demanded by the Khazars. This was the first step towards strengthening their loyalty. To consolidate the new alliance, you left your garrisons in key settlements and took young Radimichi with you into your squad, teaching them the Kyivan military art."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "886",
                                        Description = "Перемога над радимичами мала велике значення, великий княже. Проте вона була лише початком великої роботи, яка чекала тебе, щоб закріпити свій тріумф і зміцнити нові здобутки. Після битви, коли шум мечів і криків вщух, настав час діяти мудро і стратегічно.\r\n\r\nТи прийняв радимичівських старійшин у своєму таборі. Вони стояли перед тобою, ще похмурі після поразки, але вже готові слухати. Їхня данина хозарам була тягарем для їхнього народу, і ти наголосив, що Київ прийшов не як загарбник, а як визволитель. Цей аргумент, підкріплений твоєю могутністю, швидко вплинув на їхню волю. Вони визнали твою владу й погодилися платити данину Києву.",
                                        DescriptionEng = "The victory over the Radimichi was of great importance, great prince. However, it was only the beginning of the great work that awaited you to consolidate your triumph and consolidate new achievements. After the battle, when the noise of swords and shouts subsided, it was time to act wisely and strategically.\r\n\r\nYou received the Radimichi elders in your camp. They stood before you, still gloomy after their defeat, but already ready to listen. Their tribute to the Khazars was a burden for their people, and you emphasized that Kyiv had come not as an invader, but as a liberator. This argument, reinforced by your power, quickly influenced their will. They recognized your authority and agreed to pay tribute to Kyiv.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
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
                                    Id = 10,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Після цього ти вирішив укріпити контроль над їхньою землею. Твої люди розмістили гарнізони в ключових містах радимичів, зокрема біля переправ і торгових шляхів, щоб забезпечити стабільність. Це також стало знаком того, що Київ тепер бере на себе відповідальність за захист цих земель від майбутніх загроз.\r\n\r\nТи не лише захищав нові території, але й дбав про їхнє інтегрування до своєї держави. Молодь із радимичів було залучено до твоєї дружини, щоб вони могли навчитися київської військової дисципліни та стати майбутніми провідниками своєї землі під твоїм знаменом.",
                                            TextEng = "After that, you decided to consolidate your control over their land. Your men stationed garrisons in key Radimichi cities, particularly near crossings and trade routes, to ensure stability. This also became a sign that Kyiv now took responsibility for protecting these lands from future threats.\r\n\r\nYou not only defended the new territories, but also ensured their integration into your state. Young Radimichi were recruited into your squad so that they could learn Kyivan military discipline and become future leaders of their land under your banner."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Проте ти не зупинився лише на військових і адміністративних діях. Торгові шляхи, які проходили через землі радимичів, тепер перебували під твоїм контролем. Ти наказав розвивати їх, щоб забезпечити постійний потік товарів і данини до Києва.\r\n\r\nЦя перемога була не лише символічною. Вона продемонструвала хозарам, що їхній вплив слабшає, і ти готовий відвоювати кожен клаптик землі, який вони раніше контролювали. Інші слов'янські племена почали розуміти, що Київ стає новим центром сили, до якого вони також можуть приєднатися.",
                                            TextEng = "However, you did not stop only at military and administrative actions. The trade routes that passed through the lands of the Radimichi were now under your control. You ordered them to be developed to ensure a constant flow of goods and tribute to Kiev.\r\n\r\nThis victory was not only symbolic. It demonstrated to the Khazars that their influence was weakening, and that you were ready to win back every piece of land that they had previously controlled. Other Slavic tribes began to understand that Kiev was becoming a new center of power, to which they could also join."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "887",
                                        Description = "Ці події стали важливим кроком на шляху до великої мети — об'єднання Русі під твоїм правлінням. Твоя мудрість і сила, великий княже, ведуть тебе до того, щоб зробити Київ серцем великої держави, яка встоїть перед будь-якими ворогами.",
                                        DescriptionEng = "These events were an important step towards the great goal of uniting Russia under your rule. Your wisdom and strength, great prince, lead you to make Kyiv the heart of a great state that will stand against any enemies.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
                                            },
                                            new Parametrs()
                                            {
                                                Id = 1,
                                                Name = "Кількість нашої армії",
                                                Description = "",
                                                Value = 3000
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 11,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Під вечір, коли сонце опускалося за обрій, в твоєму наметі панувала напружена тиша. Розвідники доповіли: печеніги готові до перемовин. Це були ті самі кочовики, чиї наскоки завдавали великих збитків сусідам. Їхня стрімка кіннота могла обернутися як проти Києва, так і на твою користь, Олегу. Але якою ціною?",
                                            TextEng = "In the evening, as the sun sank below the horizon, a tense silence reigned in your tent. The scouts reported: the Pechenegs were ready for negotiations. These were the same nomads whose raids had caused great damage to their neighbors. Their swift cavalry could turn against Kyiv as well as in your favor, Oleg. But at what cost?"
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Перед тобою постав вибір. Мир із ними міг забезпечити спокій на східних кордонах, давши змогу зосередити всю увагу на хозарах. Проте чи можна довіряти тим, хто поважає лише силу? Їхня згода на ненапад може стати тимчасовим тріумфом, але чи не стане вона пасткою в майбутньому?",
                                            TextEng = "You have a choice to make. Peace with them could bring peace to the eastern borders, allowing you to focus all your attention on the Khazars. But can you trust those who respect only strength? Their agreement to non-aggression may be a temporary triumph, but will it not become a trap in the future?"
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "З іншого боку, ти міг обрати інший шлях — не домовлятися, а діяти рішуче. Відкрита війна з печенігами показала б твою міць усім сусіднім племенам. Але чи варто було ризикувати, коли головна битва попереду, і твоїм справжнім ворогом залишається Хозарський каганат?",
                                            TextEng = "On the other hand, you could have chosen another path - not to negotiate, but to act decisively. An open war with the Pechenegs would have shown your power to all neighboring tribes. But was it worth the risk when the main battle was ahead, and your real enemy remained the Khazar Khaganate?"
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "А ще був третій варіант: домовленість із болгарами, які прагнуть послабити хозар. Їхній торговий інтерес збігався з твоїм бажанням зміцнити економічну базу Києва. Вони могли стати надійними союзниками, але чи буде достатньо їхньої підтримки, якщо печеніги раптом змінять позицію?",
                                            TextEng = "And there was a third option: an agreement with the Bulgarians, who sought to weaken the Khazars. Their commercial interest coincided with your desire to strengthen the economic base of Kiev. They could become reliable allies, but would their support be enough if the Pechenegs suddenly changed their position?"
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "У цей момент, великий княже, ти стояв перед вирішальним вибором. Важкі думки та холодний розрахунок супроводжували тебе, бо доля Києва залежала не лише від сили меча, а й від мудрості твоїх рішень.",
                                            TextEng = "At this moment, great prince, you were faced with a crucial choice. Heavy thoughts and cold calculation accompanied you, because the fate of Kyiv depended not only on the power of the sword, but also on the wisdom of your decisions."
                                        }
                                    },
                                    Choises = new List<Choise>()
                                    {
                                        new Choise()
                                        {
                                            Id = 0,
                                            Name = "Дипломатія",
                                            Elements = new List<ElementChoise>()
                                            {
                                                new ElementChoise()
                                                {
                                                    Id = 0,
                                                    Name = "Мир із печенігами",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 12500
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -300
                                                        }
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 1,
                                                    Name = "Домовленість із болгарами",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Кількість нашої армії",
                                                            Description = "",
                                                            Value = 25000
                                                        },
                                                        new Parametrs()
                                                        {
                                                            Id = 0,
                                                            Name = "Скарбниця",
                                                            Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                            Value = -500
                                                        }
                                                    }
                                                },
                                                new ElementChoise()
                                                {
                                                    Id = 2,
                                                    Name = "Ні з ким не домовлятися",
                                                    Result = new List<Parametrs>()
                                                    {
                                                        
                                                    }
                                                }
                                            }
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "888",
                                        Description = "Підготовка до перемовин завершувалася, і всі рішення, великокняже, тепер лежали на твоїх плечах. Посли печенігів, чи, можливо, болгари або інші союзники, вже чекали на твоє слово, вірячи у твою мудрість і силу. Ти стояв перед вибором, що міг визначити майбутнє не лише твого правління, а й самої Русі.\r\n\r\nЧоловіки у дружині готували свої обладунки, а радники шепотіли про важливість кожного слова на цих переговорах. Хтось радив обережність, аби не спровокувати нові конфлікти, інші ж закликали до рішучості, аби нав’язати умови, які б принесли найбільшу користь Києву.",
                                        DescriptionEng = "The preparations for the negotiations were being completed, and all decisions, Grand Duke, now lay on your shoulders. The ambassadors of the Pechenegs, or perhaps the Bulgarians or other allies, were already waiting for your word, believing in your wisdom and strength. You were faced with a choice that could determine the future not only of your reign, but also of Rus' itself.\r\n\r\nThe men in the squad prepared their armor, and the advisors whispered about the importance of every word in these negotiations. Some advised caution so as not to provoke new conflicts, while others called for decisiveness in order to impose conditions that would bring the greatest benefit to Kiev.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 20
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 12,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Минули роки, великий княже Олегу, і Київська держава продовжувала зростати у своїй силі та впливі. З 889 по 906 рік ти не лише укріплював владу всередині країни, але й розширював її межі, готуючи ґрунт для великих звершень.",
                                            TextEng = "Years passed, Grand Prince Oleg, and the Kyivan state continued to grow in strength and influence. From 889 to 906, you not only strengthened your power within the country, but also expanded its borders, preparing the ground for great achievements."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Після встановлення союзів із печенігами та болгарами ти скерував свою увагу на внутрішню стабільність. У ці роки Київ об’єднував навколишні племена під одним знаменом, створюючи основу для єдиної держави. Землі деревлян, сіверян і тиверців поступово інтегрувалися в Київську Русь, забезпечуючи військову підтримку та економічну базу.\r\n\r\nТи не залишив поза увагою і хозар. Війна на східних рубежах тривала, але щоразу, коли їхні загони наближалися до твоїх земель, їх відкидали назад, немов хвилі об скелі. Ти навчив своїх людей захищати кордони й не дозволяв ворогу закріплюватися на підконтрольних землях.",
                                            TextEng = "After establishing alliances with the Pechenegs and Bulgarians, you turned your attention to internal stability. During these years, Kyiv united the surrounding tribes under one banner, creating the basis for a single state. The lands of the Drevlyans, Severians, and Tiverts gradually integrated into Kyivan Rus, providing military support and an economic base.\r\n\r\nYou did not ignore the Khazars. The war on the eastern borders continued, but every time their detachments approached your lands, they were thrown back like waves against a rock. You taught your people to defend the borders and did not allow the enemy to gain a foothold in the lands under your control."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Водночас, Олегу, ти розумів, що сила держави полягає не лише в мечі. Торгівля Києва процвітала, і шляхи «з варягів у греки» стали безпечними. Твої купці вільно плавали Дніпром, обмінюючи мед, хутро й віск на заморські товари. Болгари стали надійними партнерами, а печеніги більше не ризикували порушувати укладені угоди.",
                                            TextEng = "At the same time, Oleg, you understood that the power of the state lies not only in the sword. Kyiv's trade flourished, and the routes \"from the Varangians to the Greeks\" became safe. Your merchants sailed freely on the Dnieper, exchanging honey, furs, and wax for overseas goods. The Bulgarians became reliable partners, and the Pechenegs no longer risked violating the agreements they had made."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "907",
                                        Description = "Але ти завжди дивився далі. Візантія, найбагатша імперія свого часу, привертала твою увагу. Твої радники шепотіли про багатства Константинополя, про його незліченні скарби й незрівнянну торгівлю. У ці роки ти, великий княже, готувався. Ти знав, що прийде час, коли Київська Русь заявить про себе перед світом, і цей час наближався.\r\n\r\nІ ось тепер, на порозі 907 року, ти стоїш перед вирішальним кроком. Константинополь чекає. Його мури ще не знають, що означає гнів Києва, але скоро дізнаються. Це буде твоїм найславетнішим походом, який увійде в історію як доказ того, що Київська держава є силою, з якою рахуватиметься кожен.",
                                        DescriptionEng = "But you always looked further. Byzantium, the richest empire of its time, attracted your attention. Your advisors whispered about the riches of Constantinople, its countless treasures and unparalleled trade. During these years, you, the great prince, were preparing. You knew that the time would come when Kievan Rus would declare itself to the world, and that time was approaching.\r\n\r\nAnd now, on the threshold of 907, you stand before a decisive step. Constantinople awaits. Its walls do not yet know what the wrath of Kiev means, but they will soon find out. This will be your most glorious campaign, which will go down in history as proof that the Kievan state is a force to be reckoned with.",
                                        Result = new List<Parametrs>
                                        {
                                            new Parametrs()
                                            {
                                                Id = 0,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 113
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 13,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Великий княже Олегу, перед тобою завдання, що вимагає неабиякої підготовки. Похід на Константинополь — це не просто військовий крок, це виклик самому порядку речей у цих землях. Щоб успішно провести кампанію, ти маєш зібрати всі сили Київської держави та забезпечити їхню повну готовність до випробувань, які чекатимуть на шляху.",
                                            TextEng= "Grand Prince Oleg, you have a task before you that requires considerable preparation. The campaign against Constantinople is not just a military step, it is a challenge to the very order of things in these lands. To successfully conduct the campaign, you must gather all the forces of the Kievan state and ensure their full readiness for the trials that will await you on the way."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "У твоєму дворі вже кипить робота. Старійшини радять про те, як краще організувати флот і військо. Кожен меч, кожна стріла, кожен човен — це не просто зброя, а частина твоєї великої стратегії. Ти віддав накази зміцнити судна, обшивши їх деревом для захисту від стріл і вогню.\r\n\r\nВійськові майстри вдосконалюють озброєння. Щити варягів виблискують на сонці, мечі загострюють, а луки перевіряють на натяг. Твої дружинники тренуються щодня, відточуючи майстерність у стрільбі, фехтуванні та спільних побудовах.\r\n\r\nЗ усіх земель Київської держави ти зібрав найкращих воїнів. Слов'янські племена, варязькі найманці, навіть союзники з Болгарії й печенігів стоять під твоїм прапором. Їх об'єднує не лише сила меча, а й віра в твою мудрість.",
                                            TextEng = "Work is already in full swing in your yard. The elders advise on how to better organize the fleet and army. Every sword, every arrow, every boat is not just a weapon, but part of your grand strategy. You have given orders to strengthen the ships, sheathing them with wood to protect them from arrows and fire.\r\n\r\nMilitary masters are perfecting their weapons. The shields of the Varangians sparkle in the sun, swords are sharpened, and bows are checked for tension. Your warriors train daily, honing their skills in shooting, fencing, and joint construction.\r\n\r\nFrom all the lands of the Kievan state, you have gathered the best warriors. Slavic tribes, Varangian mercenaries, even allies from Bulgaria and the Pechenegs stand under your banner. They are united not only by the power of the sword, but also by faith in your wisdom."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Ти також дбаєш про провізію. По складах збирають запаси зерна, м'яса й меду, аби воїни не знали голоду в дорозі. Кожен човен облаштовують так, щоб він міг витримати тривалу подорож — як по річках, так і морем.\r\n\r\nРадники доповідають про стан доріг і шляхів. Шлях «з варягів у греки» перевірено, а дозорці слідкують, щоб жодна ворожа засада не порушила твого плану.\r\n\r\nНарешті, ти сам розробляєш стратегію. Головне — не лише дістатися до Константинополя, а й змусити імперію скоритися. Ти обмірковуєш кожен крок: як розташувати флот, як захистити людей від можливої засідки, як вразити ворога так, щоб він навіть не думав про спротив.",
                                            TextEng = "You also take care of provisions. Warehouses are stockpiled with grain, meat, and honey so that the soldiers do not know hunger on the way. Each boat is equipped so that it can withstand a long journey - both on rivers and at sea.\r\n\r\nAdvisors report on the condition of the roads and paths. The path \"from the Varangians to the Greeks\" has been checked, and sentries make sure that no enemy ambush disrupts your plan.\r\n\r\nFinally, you develop a strategy yourself. The main thing is not only to reach Constantinople, but also to force the empire to submit. You think over every step: how to position the fleet, how to protect people from a possible ambush, how to strike the enemy so that he does not even think about resistance."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Початок походу, великий княже Олегу, був сповнений рішучості та величі. Коли останні приготування завершилися, військо почало свій рух. Воїни збиралися на березі Дніпра, готові вирушити в дорогу. Човни стояли рівними рядами, їхні весла блищали на сонці. Кожен із них був завантажений провізією, зброєю та всім необхідним для тривалої подорожі.\r\n\r\nТи, великий княже, вийшов до дружини у бойових обладунках. Твій голос лунав упевнено й владно, коли ти закликав своїх воїнів бути непохитними. Ти говорив про велич Києва, про необхідність змусити Візантію визнати силу Русі та про ті багатства, які чекають на нас у Константинополі.",
                                            TextEng = "The beginning of the campaign, Grand Duke Oleg, was full of determination and grandeur. When the final preparations were completed, the army began its movement. The warriors gathered on the banks of the Dnieper, ready to set off. The boats stood in even rows, their oars gleaming in the sun. Each of them was loaded with provisions, weapons and everything necessary for a long journey.\r\n\r\nYou, Grand Duke, went out to the squad in battle armor. Your voice sounded confident and authoritative when you called on your warriors to be steadfast. You spoke of the greatness of Kiev, of the need to force Byzantium to recognize the power of Rus, and of the riches that await us in Constantinople."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Військо рушило вниз по Дніпру. Спершу пливли спокійно, розмірено, тримаючи бойовий порядок. Люди в човнах співали старовинні пісні, згадували перемоги минулих років. Це був момент, коли кожен відчував, що він — частина чогось більшого, ніж він сам.\r\n\r\nНа порогах Дніпра дружина показала свою витримку та злагодженість. Ти особисто слідкував за тим, як човни обережно обносилися по суші. Це була перша перевірка для всього війська, і вони її успішно витримали.",
                                            TextEng = "The army moved down the Dnieper. At first they sailed calmly, measuredly, maintaining battle order. People in boats sang old songs, remembered the victories of past years. It was a moment when everyone felt that they were a part of something bigger than themselves.\r\n\r\nOn the rapids of the Dnieper, the squad showed its endurance and coordination. You personally watched as the boats carefully swept along the land. This was the first test for the entire army, and they successfully passed it."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Після порогів війська дісталися до Чорного моря. Там тебе зустрів свіжий вітер і простори, що тягнулися до самого обрію. Ти знав, що це лише початок великого шляху, і попереду — головне випробування, яке увійде в літописи як одна з найбільших перемог Київської держави.",
                                            TextEng = "After the rapids, the troops reached the Black Sea. There you were met by a fresh wind and expanses stretching to the very horizon. You knew that this was only the beginning of a great journey, and ahead was the main test, which would go down in the annals as one of the greatest victories of the Kyivan state."
                                        },
                                        new Content()
                                        {
                                            Id = 6,
                                            Text = "З наближенням до Константинополя напруга зростала. Місто було могутньою твердинею, захищеною високими мурами, але твої воїни не знали страху. Приставши до берега, ти одразу організував блокаду: численні човни заполонили узбережжя, а твої дружинники облягли підступи до міста.",
                                            TextEng = "As you approached Constantinople, the tension grew. The city was a mighty fortress, protected by high walls, but your soldiers knew no fear. Having landed on the shore, you immediately organized a blockade: numerous boats flooded the coast, and your warriors besieged the approaches to the city."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Бій за Константинополь",
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
                                                Value = 25000
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
                                                Value = 45
                                            },
                                            new Parametrs()
                                            {
                                                Id = 4,
                                                Name = "Oleg"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 5,
                                                Name = "LevVIMudriy"
                                            },
                                            new Parametrs()
                                            {
                                                Id = 6,
                                                Name = "Скарбниця",
                                                Description = "Скарбниця — це центральний елемент фінансової системи вашої держави чи цивілізації. Вона зберігає всі кошти, що належать вашій імперії, і є основним ресурсом для фінансування армій, будівництва споруд, розвитку економіки та здійснення торгових операцій. Чим більша та краще охороняється скарбниця, тим більше можливостей для зростання вашої держави. Управління скарбницею потребує стратегічного підходу, оскільки правильне розподілення фінансів може вплинути на стабільність і процвітання вашої держави, а помилки у фінансуванні можуть призвести до економічної кризи чи падіння.",
                                                Value = 33
                                            },
                                            new Parametrs()
                                            {
                                                Id = 7,
                                                Name = "Підтримка народу",
                                                Description = "Підтримка народу — це рівень задоволення та довіри, яку населення має до правлячої влади чи уряду. Цей параметр прямо впливає на економічні показники та прибутки держави, адже високий рівень підтримки народу стимулює продуктивність, сприяє стабільності і росту доходів від податків. Водночас низький рівень підтримки може призвести до соціальних заворушень, страйків або навіть повстань, що негативно позначиться на економічному розвитку та здатності ефективно управляти ресурсами. Підтримка народу залежить від таких факторів, як рівень життя, ефективність управлінських рішень, військові перемоги та культурна політика, а також від реакції на кризи та зовнішні загрози.",
                                                Value = 10
                                            }
                                        }
                                    }
                                },
                                new Turn()
                                {
                                    Id = 14,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "На умовах, вигідних Києву, було укладено мир. Візантія зобов’язалася сплатити щедру данину — 12 гривень срібла на кожного руського воїна, що брав участь у поході. Окрім того, торгові угоди забезпечили київським купцям безпечний і вигідний доступ до ринків імперії.\r\n\r\nЯк символ перемоги твій щит, великий княже, був прибитий до воріт Константинополя. Цей акт став символом підкорення гордого міста волі Русі.",
                                            TextEng = "Peace was concluded on terms favorable to Kiev. Byzantium undertook to pay a generous tribute — 12 hryvnias of silver for each Rus’ soldier who took part in the campaign. In addition, trade agreements provided Kievan merchants with safe and profitable access to the empire’s markets.\r\n\r\nAs a symbol of victory, your shield, O Grand Duke, was nailed to the gates of Constantinople. This act became a symbol of the conquest of the proud city of the will of Rus’."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Олег, мудрий і далекоглядний княже, останні роки твого правління стали гідним продовженням твоєї славної долі. Ти не зупинився на досягненнях. Після тріумфу над Константинополем ти спрямував сили на зміцнення Київської держави та розширення її впливу.",
                                            TextEng = "Oleg, wise and far-sighted prince, the last years of your reign were a worthy continuation of your glorious destiny. You did not stop at your achievements. After the triumph over Constantinople, you directed your forces to strengthen the Kievan state and expand its influence."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Ти приділяв увагу встановленню миру на вже завойованих землях. Тиверці, сіверяни та древляни під твоїм мудрим керівництвом перетворилися з ворогів на вірних союзників. Ти встановив чіткі закони сплати данини, щоб не лише поповнювати скарбницю, а й зміцнювати зв'язки між племенами. Завдяки цьому Київська Русь почала перетворюватися на потужний державний організм, де кожне плем’я бачило свою роль у спільній справі.",
                                            TextEng = "You paid attention to establishing peace in the already conquered lands. The Tivertsi, Severians and Drevlyans under your wise leadership turned from enemies into loyal allies. You established clear laws for paying tribute in order not only to replenish the treasury, but also to strengthen ties between the tribes. Thanks to this, Kievan Rus began to transform into a powerful state organism, where each tribe saw its role in the common cause."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Description = "Згідно з переказами, твоє життя завершилося несподівано. Літописи згадують, що смерть прийшла до тебе у вигляді пророцтва, коли змія, символ неминучої долі, завдала тобі смертельного укусу. Цей момент став легендою, яка показує, що навіть наймогутніші князі не можуть уникнути вироку долі.",
                                        DescriptionEng = "According to legend, your life ended unexpectedly. Chronicles mention that death came to you in the form of a prophecy, when a snake, a symbol of inevitable fate, inflicted a fatal bite on you. This moment became a legend, showing that even the most powerful princes cannot escape the sentence of fate."
                                    }
                                },
                                new Turn()
                                {
                                    Id = 15,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Після славного правління Олега, Київська держава отримала нового правителя — князя Ігоря, сина Рюрика. Його правління стало новою сторінкою в історії Русі, сповненою як викликів, так і досягнень. На відміну від свого попередника, Ігор успадкував могутню, але складну державу, яка потребувала як сильної руки, так і розумної дипломатії.",
                                            TextEng = "After the glorious reign of Oleg, the Kievan state received a new ruler - Prince Igor, the son of Rurik. His reign became a new page in the history of Rus, full of both challenges and achievements. Unlike his predecessor, Igor inherited a powerful but complex state that required both a strong hand and clever diplomacy."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "На початку свого правління Ігор зіткнувся з необхідністю зберегти єдність Русі, яку забезпечив Олег. Племена, що платили данину Києву, потребували постійного контролю, щоб уникнути бунтів і зрад. У той час на кордонах дедалі активніше діяли печеніги, які час від часу пробували свої сили у спробах атакувати. Ігор, хоча й не мав слави великого завойовника, показав себе майстром політичної гри: він посилював владу Києва не лише військовими походами, але й дипломатією.",
                                            TextEng = "At the beginning of his reign, Igor was faced with the need to preserve the unity of Rus, which Oleg had secured. The tribes that paid tribute to Kiev needed constant control to avoid rebellions and betrayals. At that time, the Pechenegs were increasingly active on the borders, and from time to time they tried their hand at attacks. Igor, although he did not have the glory of a great conqueror, showed himself to be a master of the political game: he strengthened the power of Kiev not only through military campaigns, but also through diplomacy."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Період правління Ігоря був також відзначений кількома визначними походами. Особливого значення набули його експедиції на Візантію. Перший великий похід у 941 році закінчився невдачею: візантійський «грецький вогонь» знищив частину його флоту, і Русь змушена була відступити. Проте Ігор не здався. У 944 році він зібрав нові сили і знову рушив до Константинополя. Цього разу справа закінчилася дипломатично: між Києвом і Візантією було укладено новий договір, вигідний для обох сторін. Ігор показав, що навіть поразка може стати основою для нових досягнень.",
                                            TextEng = "The period of Igor's reign was also marked by several notable campaigns. Of particular importance were his expeditions to Byzantium. The first major campaign in 941 ended in failure: Byzantine \"Greek fire\" destroyed part of his fleet, and Rus was forced to retreat. However, Igor did not give up. In 944, he gathered new forces and again set out for Constantinople. This time the matter ended diplomatically: a new treaty was concluded between Kiev and Byzantium, beneficial to both sides. Igor showed that even defeat can become the basis for new achievements."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Description = "Однак найбільшим викликом для Ігоря стала внутрішня політика. Його спроба збільшити данину з древлян у 945 році обернулася трагедією. Старійшини древлян, розлючені надмірними поборами, підняли повстання, яке завершилося смертю князя. Цей момент став переломним для Русі, а його наслідки — поштовхом для радикальних реформ, які згодом провела княгиня Ольга.",
                                        DescriptionEng = "However, Igor’s greatest challenge was domestic politics. His attempt to increase tribute from the Drevlyans in 945 ended in tragedy. The Drevlyan elders, angered by the excessive levies, revolted, resulting in the prince’s death. This moment was a turning point for Rus’, and its consequences were the impetus for the radical reforms later carried out by Princess Olga."
                                    }
                                },
                                new Turn()
                                {
                                    Id = 16,
                                    Contents = new List<Content>
                                    {
                                        new Content()
                                        {
                                            Id = 0,
                                            Text = "Період правління Ольги, вдови Ігоря, став однією з найбільш визначних етапів в історії Київської Русі. Її правління виявилося не лише відновленням стабільності після трагічної смерті її чоловіка, але й періодом значних змін у внутрішній та зовнішній політиці держави.",
                                            TextEng = "The reign of Olga, Igor's widow, was one of the most significant periods in the history of Kievan Rus'. Her reign was not only a restoration of stability after the tragic death of her husband, but also a period of significant changes in the state's domestic and foreign policy."
                                        },
                                        new Content()
                                        {
                                            Id = 1,
                                            Text = "Після смерті Ігоря Ольга стала регенткою при малолітньому синові Святославі. Хоча її роль початково обмежувалася функціями опіки, Ольга швидко продемонструвала свою рішучість і здатність до владарювання. Вона відразу ж зіткнулася з наслідками повстання древлян, що стало причиною загибелі її чоловіка. Ольга вирішила не пробачити їм цього і застосувала жорстокі репресії. Літописи описують її помсту як безпрецедентну. Вона спочатку використала дипломатичні прийоми, щоб заманити представників древлян до Києва, де їх було вбито. Потім вона організувала жорстоку кару, заподіяну самому племені, що ще раз показало її здатність діяти безжально, коли це було необхідно для зміцнення влади.",
                                            TextEng = "After Igor's death, Olga became regent for her young son Svyatoslav. Although her role was initially limited to guardianship, Olga quickly demonstrated her determination and ability to rule. She immediately faced the consequences of the Drevlyan uprising that had led to her husband's death. Olga decided not to forgive them and resorted to brutal repression. The chronicles describe her revenge as unprecedented. She first used diplomatic tactics to lure the Drevlyan representatives to Kiev, where they were killed. She then organized a brutal punishment inflicted on the tribe itself, which once again demonstrated her ability to act ruthlessly when necessary to consolidate power."
                                        },
                                        new Content()
                                        {
                                            Id = 2,
                                            Text = "Однак, на відміну від жорстоких методів попередніх правителів, Ольга почала вводити нові адміністративні реформи. Однією з її основних заслуг було створення системи збору данини, яка замінила старі традиційні методи і забезпечила стабільний потік доходів у державну скарбницю. Ольга також упровадила нові міри для покращення адміністративного контролю на місцях, що дозволяло зменшити відцентрові сили та укріпити центр.",
                                            TextEng = "However, in contrast to the brutal methods of previous rulers, Olga began to introduce new administrative reforms. One of her main achievements was the creation of a tribute collection system that replaced the old traditional methods and ensured a stable flow of revenue to the state treasury. Olga also introduced new measures to improve administrative control at the local level, which allowed for the reduction of centrifugal forces and the strengthening of the center."
                                        },
                                        new Content()
                                        {
                                            Id = 3,
                                            Text = "Важливим етапом її правління стало встановлення дипломатичних відносин з Візантією. Ольга, прагнучи зміцнити міжнародний статус Русі, вирушила до Константинополя в 957 році, ставши однією з перших великих княгинь, що уклали договір з імператором. Візантія погодилася знизити податки для київських купців і навіть надала спеціальні привілеї для руських торговців. Цей візит до Візантії не лише підвищив статус Ольги на міжнародній арені, але й зміцнив зв’язки між Київською Руссю та могутньою імперією.",
                                            TextEng = "An important stage of her reign was the establishment of diplomatic relations with Byzantium. Olga, seeking to strengthen the international status of Rus, went to Constantinople in 957, becoming one of the first grand duchesses to conclude an agreement with the emperor. Byzantium agreed to reduce taxes for Kievan merchants and even granted special privileges for Rus' traders. This visit to Byzantium not only increased Olga's status in the international arena, but also strengthened ties between Kievan Rus' and the powerful empire."
                                        },
                                        new Content()
                                        {
                                            Id = 4,
                                            Text = "Також важливою подією стала християнізація Ольги. Хоча вона сама не прийняла християнство в той час, цей візит став початком духовної трансформації Київської Русі, яка під її владою все більше відкривалася для візантійської культури та релігії. Її дипломатичні зусилля в контексті християнства стали основою для пізнішого прийняття християнства Святославом та Володимиром.",
                                            TextEng = "Another important event was Olga's Christianization. Although she herself did not convert to Christianity at the time, this visit marked the beginning of a spiritual transformation of Kievan Rus', which under her rule increasingly opened up to Byzantine culture and religion. Her diplomatic efforts in the context of Christianity became the basis for the later adoption of Christianity by Svyatoslav and Volodymyr."
                                        },
                                        new Content()
                                        {
                                            Id = 5,
                                            Text = "Однак після того, як Святослав став дорослим і повністю взяв владу в свої руки, Ольга більше не могла залишатися при владі. Вона залишила за собою важливі духовні та політичні функції, але її пряме правління завершилося. Святослав, прагнучи до військових завоювань і більш прагматичних рішень, не підтримував матір у її прагненні зберігати стабільність через дипломатію і внутрішні реформи. Відтак, Ольга поступилася своїми владними повноваженнями на користь сина, хоча й залишалася почесною і важливою фігурою в історії Русі.",
                                            TextEng = "However, after Svyatoslav became an adult and took full power into his own hands, Olga could no longer remain in power. She retained important spiritual and political functions, but her direct rule ended. Svyatoslav, striving for military conquests and more pragmatic decisions, did not support her mother in her desire to maintain stability through diplomacy and internal reforms. Therefore, Olga ceded her power to her son, although she remained an honorable and important figure in the history of Rus."
                                        }
                                    },
                                    End = new End()
                                    {
                                        Id = 0,
                                        Name = "Ольга",
                                        Description = "Правління Ольги залишило великий слід, оскільки вона стала однією з перших, хто продемонстрував прагнення до розбудови держави через зовнішню політику, мирні переговори та адміністративні реформи. Її діяльність заклала підвалини для подальшого розширення і розвитку Київської Русі за часів Святослава та Володимира.",
                                        DescriptionEng = "Olga's reign left a great mark, as she was one of the first to demonstrate a commitment to state-building through foreign policy, peace negotiations, and administrative reforms. Her activities laid the foundation for the further expansion and development of Kyivan Rus' under Svyatoslav and Volodymyr."
                                    }
                                },
                                new Turn()
                                {
                                    Id = 17,
                                    Contents = new List<Content>()
                                    {
                                        new Content()
                                        {

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
            PlayerPrefs.SetString("WhoWin", "");
            PlayerPrefs.SetInt("OurArmy", 0);
            PlayerPrefs.SetInt("EnemyArmy", 0);
            PlayerPrefs.SetInt("OurOrg", 0);
            PlayerPrefs.SetInt("EnemyOrg", 0);
            PlayerPrefs.SetInt("OurBoyDuh", 0);
            PlayerPrefs.SetInt("EnemyBoyDuh", 0);
        }
    }
}