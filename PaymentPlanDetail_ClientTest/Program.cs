namespace PaymentPlanDetail_ClientTest
{
    using System;
    using System.Globalization;
    using System.Net;

    using PaymentPlanClient;
    using PaymentPlanClient.Entity;
    using PaymentPlanClient.ViewModels;

    using RestSharp;

    class Program
    {
        static void Main(string[] args)
        {
            var cookieContainer = new CookieContainer();
            var restClient = new RestClient("https://fb.lbtvarlik.com.tr/webcentricapi/api/") { CookieContainer = cookieContainer };

            var paymentPlanMakerClient = new LbtPaymentPlanMakerClient(restClient);
            var authTicketRequest = new AuthTicketRequest(
                "Ali Güneş",
                "NECLA",
                "28387364584",
                DateTime.Parse("09.09.1967").ToLocalTime(),
                "5422476935",
                "",
                "",
                "");
            var t = paymentPlanMakerClient.CreateTicket(authTicketRequest);
            var smsCode = Console.ReadLine();
            var validationRequest = new ValidateTicketRequest { BirthDate = authTicketRequest.BirthDate, HttpUserAgent = string.Empty, IpAdress = string.Empty, MotherName = authTicketRequest.MotherName, PhoneNo = authTicketRequest.PhoneNo, SessionId = string.Empty, SmsCode = smsCode, Tckn = authTicketRequest.Tckn, Ticket = t.Ticket };
            var s = paymentPlanMakerClient.ValidationTicket(validationRequest);
            var k =
                paymentPlanMakerClient.CalculateRefreshPaymentPlan(
                    new CalculateRefreshPaymentPlanRequest(494444, DateTime.Now.ToLocalTime(), RefreshPaymentPlanType.AddLastPayment));
        }
    }
}
