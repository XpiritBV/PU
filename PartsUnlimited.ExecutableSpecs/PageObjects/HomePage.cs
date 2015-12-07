using FluentAutomation;

namespace PartsUnlimited.ExecutableSpecs.PageObjects
{
    public class HomePage : PageObject<HomePage>
    {
        public HomePage(FluentTest test) : base (test)
        {
            this.Url = "http://localhost:5001/";
            this.At = () => this.I.Expect.Exists(SearchInput);
        }

        public HomePage EnterSearchCriteria(string searchText)
        {
            this.I.Enter(searchText).In(SearchInput);
            return this;
        }

        public SearchResultsPage Search()
        {
            this.I.Focus(SearchInput).Press("{ENTER}");
            return this.Switch<SearchResultsPage>();
        }


        private const string SearchInput = "#search-box";
    }

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
            this.I.Expect.Exists(string.Format(ResultTitle, title));
            return this;
        }

        private const string SearchResultsContainer = "#search-page";
        private const string ResultTitle = "#search-page > .list-item-part > h4:contains('{0}')";
    }
}
