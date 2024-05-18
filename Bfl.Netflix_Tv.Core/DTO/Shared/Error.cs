namespace Bfl.Netflix_Tv.Core.DTO.Shared
{
    public class Error : Exception
    {
        public override string Message { get; }
        public string Type { get; set; }
        public int Status { get; set; }

        public string Description { get; set; }

        public Error(string message)
        {
            Message = message;
        }
        public Error(string message,string type,int status,string description)
        {
            Message=message;
            Type = type;
            Status = status;
            Description = description;
        }

    }
}
