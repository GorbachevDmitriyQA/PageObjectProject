using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TestProject1.DataModels;
using System.Xml.Serialization;

namespace Demos.TestManager
{
    public class Main
    {
        private static Main _manager;
        /// <summary>
        /// Перменная драйвера
        /// </summary>
        public static IWebDriver driver;

        public static Main Manager
        {
            get
            {
                if (_manager == null)
                {
                    _manager = new Main();
                }
                return _manager;
            }
            set => _manager = value;
        }
        protected FeedHabrSteps feedHabrsteps;
        protected HeaderSteps headerSteps;
        protected SearchingSteps searchingSteps;
        /// <summary>
        /// Шаги для Новости.Хабр
        /// </summary>
        public FeedHabrSteps FeedHabrSteps
        {
            get
            {
                if (feedHabrsteps == null)
                {
                    feedHabrsteps = new FeedHabrSteps();
                }
                return feedHabrsteps;
            }
            set => feedHabrsteps = value;
        }
        /// <summary>
        /// Шаги для шапки Хабр
        /// </summary>
        public HeaderSteps HeaderSteps
        {
            get
            {
                if (headerSteps == null)
                {
                    headerSteps = new HeaderSteps();
                }
                return headerSteps;
            }
            set => headerSteps = value;
        }
        /// <summary>
        /// Шаги для контекстного поиска
        /// </summary>
        public SearchingSteps SearchingSteps
        {
            get
            {
                if (searchingSteps == null)
                {
                    searchingSteps = new SearchingSteps();
                }
                return searchingSteps;
            }
            set => searchingSteps = value;
        }

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            driver = new ChromeDriver(options);
            driver.Url = "https://habr.com/ru/feed/";
            ContextSearchDataFromXml();

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        public static IEnumerable<SearchData> ContextSearchDataFromXml()
        {
            return (List<SearchData>)new XmlSerializer(typeof(List<SearchData>))
                .Deserialize(new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "/TestData/CheckContextSearching.xml"));
        }
    }
}
