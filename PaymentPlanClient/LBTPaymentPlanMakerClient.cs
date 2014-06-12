namespace PaymentPlanClient
{
    using System;

    using LBTCustomerCentricWebsite.WebApi2.ViewModel;

    using PaymentPlanClient.Properties;
    using PaymentPlanClient.ViewModels;

    using RestSharp;


    public class LbtPaymentPlanMakerClient
    {
        readonly private RestClient restClient;
        public  IRestResponse IRestResponse { get; private set; }
        public string ServiceUrl { get; set; }

        public LbtPaymentPlanMakerClient(RestClient restClient)
        {
            this.ServiceUrl = Resources.LBTPaymentPlanMakerClient_ServiceUrl;
            this.restClient = restClient;
        }

        public PaymentPlanPayTypeResponse GetPaymentPlanTypes(PaymentPlanPayTypeRequest paymentPlanPayTypeRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_GetPaymentPlanType_Url, Method.GET) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(paymentPlanPayTypeRequest);
            var response = restClient.Execute<PaymentPlanPayTypeResponse>(restRequest);
            IRestResponse = response;
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

    }
}
