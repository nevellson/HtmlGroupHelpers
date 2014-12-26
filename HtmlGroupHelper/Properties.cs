using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HtmlGroupHelper
{
    internal class Properties<TModel, TProperty>
    {
        internal Properties(Expression<Func<TModel, TProperty>> expression,HtmlHelper<TModel> helper)
        {
            ModelMetadata metaData = ModelMetadata.FromLambdaExpression(expression, helper.ViewData);
            this.LabelInner = metaData.DisplayName;
            this.PropertyName = metaData.PropertyName;

        }

        public string LabelInner { get; set; }

        public string PropertyName { get; set; }
    }
}
