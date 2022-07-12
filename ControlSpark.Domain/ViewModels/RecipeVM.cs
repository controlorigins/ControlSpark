using ControlSpark.Domain.Models;

namespace ControlSpark.Domain.ViewModels;

/// <summary>
/// Class RecipeVM.
/// Implements the <see cref="WebsiteVM" />
/// </summary>
/// <seealso cref="WebsiteVM" />
public class RecipeVM : WebsiteVM
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="website"></param>
    public RecipeVM(WebsiteVM website)
    {
        WebsiteId = website.WebsiteId;
        WebsiteName = website.WebsiteName;
        WebsiteStyle = website.WebsiteStyle;
        Template = website.Template;
        SiteUrl = website.SiteUrl;
        CategoryList = website.CategoryList;
        MetaDescription = website.MetaDescription;
        MetaKeywords = website.MetaKeywords;
        PageTitle = website.PageTitle;
        RecipeList = website.RecipeList;
        Menu = website.Menu;
        StyleList = website.StyleList;
        StyleUrl = website.StyleUrl;
        Recipe = new RecipeModel();
        Category = new RecipeCategoryModel();
    }
    /// <summary>
    /// Gets or sets the recipe.
    /// </summary>
    /// <value>The recipe.</value>
    public RecipeModel Recipe { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public RecipeCategoryModel Category { get; set; }
}
