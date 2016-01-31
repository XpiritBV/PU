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
            this.I.Focus(SearchInput);
            this.I.Scroll(SearchInput);
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
}
