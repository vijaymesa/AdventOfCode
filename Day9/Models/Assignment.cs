using System.Net;

namespace Day9.Models
{
    public class Assignment
    {
        public int GroupScore { get; set; }
        public bool State { get; set; }
        public string Message { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}