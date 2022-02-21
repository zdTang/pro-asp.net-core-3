using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Components
{
    /// <summary>
    /// Create a view component
    /// Notice the name convention
    /// this component will be "navigation-menu"
    /// </summary>
    public class NavigationMenuViewComponent:ViewComponent
    {
        public string Invoke()
        {
            return "Hello, Mike from the Nav View Component";
        }
    }
}