using Demos.TestManager;
using TestProject1.TestManager.Validations;

namespace TestProject1.TestManager
{
    /// <summary>
    /// Класс для доступа ко всем шагам
    /// </summary>
    public class StepsBase
    {
        /// <summary>
        /// Шаги для Новости.Хабр
        /// </summary>
        public FeedHabrSteps FeedHabrSteps => new();
        /// <summary>
        /// Проверка для Новости.Хабр
        /// </summary>
        public FeedHabrValidator FeedHabrValidator => new();
        /// <summary>
        /// Шаги для контекстного поиска по Хабр
        /// </summary>
        public SearchingSteps SearchingSteps => new();
    }
}
