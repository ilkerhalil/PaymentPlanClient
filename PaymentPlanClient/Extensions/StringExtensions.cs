namespace PaymentPlanClient.Extensions
{
    public static class StringExtensions
    {
        public static string GetIpAddress(this System.Web.HttpContext context)
        {
            if (context == null) return string.Empty;
            var ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ipAddress)) return context.Request.ServerVariables["REMOTE_ADDR"];
            var addresses = ipAddress.Split(',');
            return addresses.Length != 0 ? addresses[0] : context.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}
