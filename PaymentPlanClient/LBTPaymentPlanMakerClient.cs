namespace PaymentPlanClient
{
    using System;
    using System.Net;

    using PaymentPlanClient.Properties;
    using PaymentPlanClient.ViewModels;

    using RestSharp;


    public class LbtPaymentPlanMakerClient
    {
        readonly private RestClient restClient;
        public IRestResponse IRestResponse { get; private set; }
        public string ServiceUrl { get; set; }

        public LbtPaymentPlanMakerClient(RestClient restClient)
        {
            this.ServiceUrl = Resources.LBTPaymentPlanMakerClient_ServiceUrl;
            this.restClient = restClient;
        }

        public PaymentPlanPayTypeResponse GetPaymentPlanTypes(PaymentPlanPayTypeRequest paymentPlanPayTypeRequest)
        {
            var url = string.Format(Resources.LbtPaymentPlanMakerClient_GetPaymentPlanType_Url, paymentPlanPayTypeRequest.LoanId);
            var restRequest = new RestRequest(url, Method.GET) { RequestFormat = DataFormat.Json };
            var response = restClient.Execute<PaymentPlanPayTypeResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new Exception(response.Content);
            if (response.Data != null) return response.Data;
            throw new Exception(response.Content);
        }

        public DraftPaymentPlanDetailResponse MakeDraftPaymentPlan(DraftPaymentPlanDetailRequest draftPaymentPlanDetailRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_MakeDraftPaymentPlan_api_PaymentPlan_Url, Method.PUT) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(draftPaymentPlanDetailRequest);
            var response = restClient.Execute<DraftPaymentPlanDetailResponse>(restRequest);
            IRestResponse = response;
            if (response.Data != null) return response.Data;
            throw new Exception(response.Content);
        }

        public MakePaymentPlanResponse MakePaymentPlan(MakePaymentPlanRequest makePaymentPlanRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_MakeDraftPaymentPlan_api_PaymentPlan_Url, Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(makePaymentPlanRequest);
            var response = restClient.Execute<MakePaymentPlanResponse>(restRequest);
            IRestResponse = response;
            if (response.Data != null) return response.Data;
            throw new Exception(response.Content);
        }

        public CalculateRefreshPaymentPlanResponse CalculateRefreshPaymentPlan(CalculateRefreshPaymentPlanRequest calculateRefreshPaymentPlanRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_RefreshPaymentPlan_api_RefreshPayment_Url,
                Method.PUT) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(calculateRefreshPaymentPlanRequest);
            var response = restClient.Execute<CalculateRefreshPaymentPlanResponse>(restRequest);
            IRestResponse = response;
            if (response.Data != null) return response.Data;
            throw new Exception(response.Content);
        }

        public RefreshPaymentPlanResponse RefreshPaymentPlan(RefreshPaymentPlanRequest refreshPaymentPlanRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_RefreshPaymentPlan_api_RefreshPayment_Url,
                Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(refreshPaymentPlanRequest);
            var response = restClient.Execute<RefreshPaymentPlanResponse>(restRequest);
            IRestResponse = response;
            if (response.Data != null) return response.Data;
            throw new Exception(response.Content);
        }

    }
}
