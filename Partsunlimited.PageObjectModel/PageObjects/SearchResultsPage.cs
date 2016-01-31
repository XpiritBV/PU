using FluentAutomation;

namespace PartsUnlimited.ExecutableSpecs.PageObjects
{
    public class SearchResultsPage : PageObject<SearchResultsPage>
    {
        public SearchResultsPage(FluentTest test)
            : base(test)
        {
            this.Url = "http://localhost:5001/Search";
            this.At = () => this.I.Expect.Exists(SearchResultsContainer);
        }

        public SearchResultsPage FindResultByTitle(string title)
        {
            this.I.Wait(4);
            this.I.Expect.Exists(string.Format(ResultTitle, title));
            return this;
        }

        private const string SearchResultsContainer = "#search-page";
        private const string ResultTitle = "#search-page > .list-item-part > h4:contains('{0}')";
    }
}