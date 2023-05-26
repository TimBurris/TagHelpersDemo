using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace TagHelpersDemo.TagHelpers;

public class FloatFormInputTagHelper : InputTagHelper
{
    public FloatFormInputTagHelper(IHtmlGenerator htmlGenerator)
        : base(htmlGenerator)
    {

    }

    /// <summary>
    /// optional text to override default label text
    /// </summary>
    [HtmlAttributeName("label-text")]
    public string OverridingLabelText { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);

        output.TagName = "input";
        output.TagMode = TagMode.SelfClosing;
        output.AddClass("form-control", HtmlEncoder.Default);

        //open formgroup
        output.PreElement.AppendHtml("<div class=\"form-group has-validation\">");

        //open floating
        output.PreElement.AppendHtml("<div class=\"form-floating\">");

        //input will render here

        //render label
        var label = this.Generator.GenerateLabel(ViewContext, For.ModelExplorer,
            For.Name, labelText: this.OverridingLabelText, new { });
        output.PostElement.AppendHtml(label);

        //close floating
        output.PostElement.AppendHtml("</div>");

        //open validation div
        output.PostElement.AppendHtml("<div class=\"invalid-feedback\">");

        //validation element
        var validationElement =
            this.Generator.GenerateValidationMessage(ViewContext, For.ModelExplorer, For.Name,
                message: null, ViewContext.ValidationMessageElement, new { });
        output.PostElement.AppendHtml(validationElement);

        //close validation div
        output.PostElement.AppendHtml("</div>");

        //close formgroup
        output.PostElement.AppendHtml("</div>");
    }
}
