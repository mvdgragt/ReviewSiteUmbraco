
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace BB.Site.Components;

public class Navigation : ViewComponent
		
{
	public async Task<IViewComponentResult> InvokeAsync(IPublishedContent content)
	{   
        var homePage = content.AncestorOrSelf<HomePage>();
        var navigationItems = homePage.Navigation;
		return View(navigationItems);
	}
}
	


