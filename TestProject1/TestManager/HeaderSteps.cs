using TestProject1.PageObject;
using TestProject1.TestManager;

namespace Demos.TestManager
{
    /// <summary>
    /// Класс шагов для шапки Хабр
    /// </summary>
    public class HeaderSteps : StepsBase
    {
        private HeaderBlock headerBlock = new();
        /// <summary>
        /// Нажимаем на кнопку поиска
        /// </summary>
        /// <returns></returns>
        public HeaderSteps ClickSearchButton()
        {
            headerBlock.SearchButtonClick();
            return this;
        }
    }
}
