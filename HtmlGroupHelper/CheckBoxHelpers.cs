using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace HtmlGroupHelper
{
    public static class CheckBoxHelpers
    {
        private static string _template
        {
            get
            {
                if (_templateManager == null)
                {
                    _templateManager = new TemplateManager();
                }
                return _templateManager.GetTemplate("CheckBoxTemplate");
            }
        }

        private static TemplateManager _templateManager;

        public static MvcHtmlString CheckBoxGroupFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression)
        {
            Properties<TModel, bool> props = new Properties<TModel, bool>(expression, htmlHelper);
            string checkBox = htmlHelper.CheckBoxFor(expression).ToString();
            string htmlValue = _template.Replace("{{input-item}}", checkBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString CheckBoxGroupFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes)
        {
            Properties<TModel, bool> props = new Properties<TModel, bool>(expression, htmlHelper);
            string checkBox = htmlHelper.CheckBoxFor(expression,htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", checkBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString CheckBoxGroupFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression, object htmlAttributes)
        {
            Properties<TModel, bool> props = new Properties<TModel, bool>(expression, htmlHelper);
            string checkBox = htmlHelper.CheckBoxFor(expression, htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", checkBox).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

    }
}
