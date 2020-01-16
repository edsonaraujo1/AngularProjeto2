using Abp.Web.Mvc.Views;

namespace AngularProjeto2.Web.Views
{
    public abstract class AngularProjeto2WebViewPageBase : AngularProjeto2WebViewPageBase<dynamic>
    {

    }

    public abstract class AngularProjeto2WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AngularProjeto2WebViewPageBase()
        {
            LocalizationSourceName = AngularProjeto2Consts.LocalizationSourceName;
        }
    }
}