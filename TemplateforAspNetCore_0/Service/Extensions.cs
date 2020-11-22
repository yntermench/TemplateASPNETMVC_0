namespace TemplateforAspNetCore_0.Areas.Admin.Views.ServiceItems
{
    public static class Extensions
    {
        public static string CutController(this string str)
        {
            return str.Replace("Controller", "");
        }
    }
}
