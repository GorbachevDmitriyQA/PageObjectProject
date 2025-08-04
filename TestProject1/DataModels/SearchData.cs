namespace TestProject1.DataModels
{
    /// <summary>
    /// Модель данных для работы со страницей контекстного поиска
    /// </summary>
    public class SearchData
    {
        /// <summary>
        /// Текст для поиска
        /// </summary>
        public string TextForSearching { get; set; }
        /// <summary>
        /// Название первой отображаемой публикации
        /// </summary>
        public string ExpectedFirstPublicationHeader { get; set; }
        /// <summary>
        /// Категория поиска
        /// </summary>
        public string ActiveSearchCategory { get; set; }
    }
}
