using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace HtmlGroupHelper
{
    public static class DropDownHelpers
    {
        private static string _template
        {
            get
            {
                if (_templateManager == null)
                {
                    _templateManager = new TemplateManager();
                }
                return _templateManager.GetTemplate("DropDownTemplate");
            }
        }

        private static TemplateManager _templateManager;

        #region  selectList/viewDataName

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string viewDataName)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, (IEnumerable<SelectListItem>)htmlHelper.ViewData[viewDataName], new {@class="form-control"}).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, selectList, new {@class="form-control"}).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        #endregion

        #region selectlist/viewDataName - htmlAttributes(IDictionary)

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, selectList, htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string viewDataName, IDictionary<string, object> htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, (IEnumerable<SelectListItem>)htmlHelper.ViewData[viewDataName], htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        #endregion

        #region selectlist/viewDataName - htmlAttributes(object)

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, selectList, htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string viewDataName, object htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, (IEnumerable<SelectListItem>)htmlHelper.ViewData[viewDataName], htmlAttributes).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }


        #endregion

        #region selectList/viewdataName -optionLabel

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string optionLabel)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, selectList, optionLabel, new {@class="form-control"}).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }
        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string viewDataName, string optionLabel)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, (IEnumerable<SelectListItem>)htmlHelper.ViewData[viewDataName], optionLabel, new {@class="form-control"}).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        #endregion

        #region selectList/viewDataName -optionLabel htmlAttributes(Dictionary)

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string viewDataName, string optionLabel, IDictionary<string, object> htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, (IEnumerable<SelectListItem>)htmlHelper.ViewData[viewDataName], optionLabel).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string optionLabel, IDictionary<string, object> htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, selectList, optionLabel).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        #endregion

        #region selectList/viewDataName -optionLabel htmlAttributes(object)

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string viewDataName, string optionLabel, object htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, (IEnumerable<SelectListItem>)htmlHelper.ViewData[viewDataName], optionLabel).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        public static MvcHtmlString DropDownGroupFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string optionLabel, object htmlAttributes)
        {
            Properties<TModel, TProperty> props = new Properties<TModel, TProperty>(expression, htmlHelper);
            string dropDown = htmlHelper.DropDownListFor(expression, selectList, optionLabel).ToString();
            string htmlValue = _template.Replace("{{input-item}}", dropDown).Replace("{{display-name}}", props.LabelInner).Replace("{{display-for}}", props.PropertyName);
            return new MvcHtmlString(htmlValue);
        }

        #endregion

    }
}
