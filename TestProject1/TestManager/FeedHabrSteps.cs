using TestProject1.PageObject;
using TestProject1.TestManager.Validations;
using TestProject1.TestManager;

namespace Demos.TestManager
{
    public class FeedHabrSteps : StepsBase
    {
        /// <summary>
        /// Пременная для вызова цепочки событий
        /// </summary>
        public readonly FeedHabrValidator Validate = new();
        /// <summary>
        /// Страница Новости.Хабра
        /// </summary>
        private FeedHabrPage feedHabrPage = new();
        /// <summary>
        /// Нажать на кнопку "Настройка ленты"
        /// </summary>
        public FeedHabrSteps LentaSettingClick()
        {
            feedHabrPage.LentaSettingButtonClick();
            return this;
        }
    }
}
