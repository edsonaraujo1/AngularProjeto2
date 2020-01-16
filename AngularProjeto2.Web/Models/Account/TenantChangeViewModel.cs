using Abp.AutoMapper;
using AngularProjeto2.Sessions.Dto;

namespace AngularProjeto2.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}