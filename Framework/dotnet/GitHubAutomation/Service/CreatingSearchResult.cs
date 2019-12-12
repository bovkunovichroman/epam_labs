using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubAutomation.Model;
using GitHubAutomation.Utils;

namespace GitHubAutomation.Service
{
    class CreatingSearchResultWithoutDateModel
    {
        public static SearchResultWithoutDate WithSearchResultWithoutDateProperties()
        {
            return new SearchResultWithoutDate(TestDataReader.GetData("InputSityTo"));
        }
    }
}
