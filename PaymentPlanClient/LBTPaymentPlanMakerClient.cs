namespace PaymentPlanClient
{
    using System.Net;
    using System.Web;

    using LBTCustomerCentricWebsite.WebApi2.ViewModel;
    using PaymentPlanClient.Exception;
    using PaymentPlanClient.Extensions;
    using PaymentPlanClient.Properties;
    using PaymentPlanClient.ViewModels.AddressManipulation;
    using PaymentPlanClient.ViewModels.AppointmentManipulation;
    using PaymentPlanClient.ViewModels.Authentication;
    using PaymentPlanClient.ViewModels.ComplaintManipulation;
    using PaymentPlanClient.ViewModels.EmailManipulation;
    using PaymentPlanClient.ViewModels.Payment;
    using PaymentPlanClient.ViewModels.PhoneManipulation;

    using RestSharp;
    using RestSharp.Serializers;


    public class LbtPaymentPlanMakerClient
    {
        readonly private RestClient restClient;
        public IRestResponse IRestResponse { get; private set; }
        public string ServiceUrl { get; set; }

        public JsonSerializer JsonSerializer { get; private set; }

        public LbtPaymentPlanMakerClient(RestClient restClient)
        {
            this.ServiceUrl = Resources.LBTPaymentPlanMakerClient_ServiceUrl;
            this.restClient = restClient;
            this.JsonSerializer = new JsonSerializer();
        }
        #region Authentication
        public AuthTicketResponse CreateTicket(AuthTicketRequest authTicketRequest)
        {
            if (string.IsNullOrWhiteSpace(authTicketRequest.IpAdress)) authTicketRequest.IpAdress = HttpContext.Current.GetIpAddress();
            var restRequest = new RestRequest(Resources.LBTLoginClient_Url, Method.PUT) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(authTicketRequest);
            var response = restClient.Execute<AuthTicketResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public ValidateTicketResponse ValidationTicket(ValidateTicketRequest validateTicketRequest)
        {
            var restRequest = new RestRequest(Resources.LBTLoginClient_Url, Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(validateTicketRequest);
            var response = restClient.Execute<ValidateTicketResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public LogOutResponse LogOut()
        {
            var restRequest = new RestRequest(Resources.LBTLoginClient_Url, Method.GET) { RequestFormat = DataFormat.Json };
            var response = restClient.Execute<LogOutResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        #endregion

        #region PaymentPlanManipulation

        public PaymentPlanPayTypeResponse GetPaymentPlanTypes(PaymentPlanPayTypeRequest paymentPlanPayTypeRequest)
        {
            var url = string.Format(Resources.LbtPaymentPlanMakerClient_GetPaymentPlanType_Url, paymentPlanPayTypeRequest.LoanId);
            var restRequest = new RestRequest(url, Method.GET) { RequestFormat = DataFormat.Json };
            var response = restClient.Execute<PaymentPlanPayTypeResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public DraftPaymentPlanDetailResponse MakeDraftPaymentPlan(DraftPaymentPlanDetailRequest draftPaymentPlanDetailRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_MakeDraftPaymentPlan_api_PaymentPlan_Url, Method.PUT) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(draftPaymentPlanDetailRequest);
            var response = restClient.Execute<DraftPaymentPlanDetailResponse>(restRequest);
            IRestResponse = response;
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public MakePaymentPlanResponse MakePaymentPlan(MakePaymentPlanRequest makePaymentPlanRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_MakeDraftPaymentPlan_api_PaymentPlan_Url, Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(makePaymentPlanRequest);
            var response = restClient.Execute<MakePaymentPlanResponse>(restRequest);
            IRestResponse = response;
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public CalculateRefreshPaymentPlanResponse CalculateRefreshPaymentPlan(CalculateRefreshPaymentPlanRequest calculateRefreshPaymentPlanRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_RefreshPaymentPlan_api_RefreshPayment_Url,
                Method.PUT) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(calculateRefreshPaymentPlanRequest);
            var response = restClient.Execute<CalculateRefreshPaymentPlanResponse>(restRequest);
            IRestResponse = response;
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public RefreshPaymentPlanResponse RefreshPaymentPlan(RefreshPaymentPlanRequest refreshPaymentPlanRequest)
        {
            var restRequest = new RestRequest(Resources.LbtPaymentPlanMakerClient_RefreshPaymentPlan_api_RefreshPayment_Url,
                Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(refreshPaymentPlanRequest);
            var response = restClient.Execute<RefreshPaymentPlanResponse>(restRequest);
            IRestResponse = response;
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }
        #endregion

        #region AddressManipulation

        public AddAdressResponse AddAddress(AddAdressRequest addAdressRequest)
        {
            var restRequest = new RestRequest(Resources.LBTAddress_Url, Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(addAdressRequest);
            var response = restClient.Execute<AddAdressResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public DeleteAdressResponse DeleteAddress(DeleteAdressRequest deleteAddressRequest)
        {
            var restRequest = new RestRequest(Resources.LBTAddress_Url, Method.DELETE) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(deleteAddressRequest);
            var response = restClient.Execute<DeleteAdressResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public IlRequestResponse GetIlCollection()
        {
            var restRequest = new RestRequest(Resources.LBTAddress_Url, Method.GET) { RequestFormat = DataFormat.Json };
            var response = restClient.Execute<IlRequestResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        #endregion

        #region EmailManipulation
        public AddEmailResponse AddEmail(AddEmailRequest addEmailRequest)
        {
            var restRequest = new RestRequest(Resources.LBTEmail_Url, Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(addEmailRequest);
            var response = restClient.Execute<AddEmailResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public DeleteEmailResponse DeleteEmail(DeleteEmailRequest deleteEmailRequest)
        {
            var restRequest = new RestRequest(Resources.LBTEmail_Url, Method.DELETE) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(deleteEmailRequest);
            var response = restClient.Execute<DeleteEmailResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        #endregion

        #region PhoneManipulation
        public AddPhoneResponse AddPhone(AddPhoneRequest addPhoneRequest)
        {
            var restRequest = new RestRequest(Resources.LBTPhone_Url, Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(addPhoneRequest);
            var response = restClient.Execute<AddPhoneResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public DeletePhoneResponse DeletePhone(DeletePhoneRequest deletePhoneRequest)
        {
            var restRequest = new RestRequest(Resources.LBTPhone_Url, Method.DELETE) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(deletePhoneRequest);
            var response = restClient.Execute<DeletePhoneResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        #endregion

        #region ComplaintManipulation

        public ComplaintResponse GetComplaintTopics()
        {
            var restRequest = new RestRequest(Resources.LBTComplaint_Url, Method.GET) { RequestFormat = DataFormat.Json };
            var response = restClient.Get<ComplaintResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        public AddComplaintResponse AddComplaint(AddComplaintRequest addComplaintRequest)
        {
            var restRequest = new RestRequest(Resources.LBTComplaint_Url, Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(addComplaintRequest);
            var response = restClient.Execute<AddComplaintResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        #endregion

        #region AppointmentManipulation

        public AppointmentResponse AddAppointment(AppointmentRequest appointmentRequest)
        {
            var restRequest = new RestRequest(Resources.LBTAppointment_Url, Method.POST) { RequestFormat = DataFormat.Json };
            restRequest.AddBody(appointmentRequest);
            var response = restClient.Execute<AppointmentResponse>(restRequest);
            IRestResponse = response;
            if (response.StatusCode != HttpStatusCode.OK) throw new PaymentPlanClientException(response.Content);
            if (response.Data != null) return response.Data;
            throw new PaymentPlanClientException(response.Content);
        }

        #endregion

    }
}
