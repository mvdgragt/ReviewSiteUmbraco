namespace BB.Site.Models;

public class NavigationViewModel {
    public string HomeUrl { get;set; }
    public IEnumerable<Umbraco.Cms.Core.Models.Link> Navigation { get;set; }
}