using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpersDemo.TagHelpers;

public class DisplayFieldTagHelper : TagHelper
{
    private readonly IHtmlGenerator _htmlGenerator;

    public DisplayFieldTagHelper(IHtmlGenerator htmlGenerator)
    {
        _htmlGenerator = htmlGenerator;
    }
    /// <summary>
    /// Gets the <see cref="Rendering.ViewContext"/> of the executing view.
    /// </summary>
    [HtmlAttributeNotBound]
    [ViewContext]
    public ViewContext ViewContext { get; set; }

    [HtmlAttributeName("asp-for")]
    public ModelExpression For { get; set; }

    public string ContainerCss { get; set; }

    public string LabelText { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);


        output.TagName = "span";
        output.TagMode = TagMode.StartTagAndEndTag;

        //start outer div
        output.PreElement.AppendHtml($"<div class=\"{this.ContainerCss}\">");

        //start flex
        output.PreElement.AppendHtml("<div class=\"d-flex\">");

        var label = _htmlGenerator.GenerateLabel(
            ViewContext, For.ModelExplorer, For.Name, labelText: LabelText, new { });
        label.AddCssClass("opacity-50 small mb-0");

        output.PreElement.AppendHtml(label);

        //end flex
        output.PreElement.AppendHtml("</div>");

        //setting content
        string content = this.For.ModelExplorer.GetSimpleDisplayText();
        output.Content.SetContent(content);

        //end outer div
        output.PostElement.AppendHtml("</div>");

    }

}