using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;
using System.Linq;
using System.Web.Mvc.Html;

namespace HtmlGroupHelper
{
    public static class TextBoxHelpers
    {

        private static string _template
        {
            get
            {
                if (_templateManager == null)
                {
                    _templateManager = new TemplateManager();
                }
                return _templateManager.GetTemplate("TextBoxTemplate");
            }
        }

        private static TemplateManager _templateManager;

        public static MvcHtmlString TextGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string textBox = htmlHelper.TextBoxFor(expression, "", new { @class = "form-control", @placeholder = props.LabelInner }).ToString();
            string htmlValue = _template.Replace("{{input-item}}", textBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString TextGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IDictionary<string, object> htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            
            string textBox = htmlHelper.TextBoxFor(expression, htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", textBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString TextGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object htmlAttributes)
        {

            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string textBox = htmlHelper.TextBoxFor(expression, htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", textBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);

        }

        public static MvcHtmlString TextGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string format)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string textBox = htmlHelper.TextBoxFor(expression, format, new { @class = "form-control", @placeholder = props.LabelInner }).ToString();
            string htmlValue = _template.Replace("{{input-item}}", textBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString TextGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string format, IDictionary<string, object> htmlAttributes)
        {

            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string textBox = htmlHelper.TextBoxFor(expression, format, htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", textBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString TextGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string format, object htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string textBox = htmlHelper.TextBoxFor(expression, format, htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", textBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }
    }
}
