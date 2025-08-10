namespace StudioBookingSystem
{
    public class ApiResponse
    {
        private ApiResponse(object data, int statusCode, bool hasError, string errorMessage, string successMessage)
        {
            Data = data;
            StatusCode = statusCode;
            HasError = hasError;
            ErrorMessage = errorMessage;
            SuccessMessage = successMessage;
        }
        public static ApiResponse CreateSuccessResponse(object data, int statusCode, string successMessage)
        {
            return new ApiResponse(data, statusCode, false,"", successMessage);
        }
        public static ApiResponse CreateFailResponse(int statusCode, string errorMessage = "")
        {
            return new ApiResponse(null, statusCode, true, errorMessage, "");
        }

        public object Data { get; set; }
        public int StatusCode { get; set; }
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
    }
}
