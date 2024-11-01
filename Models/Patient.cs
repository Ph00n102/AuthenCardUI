namespace AuthenCardUI.Models
{
    public class Patient
    {
        public string hn { get; set; }
        public string hcode { get; set; }
        public string hometel { get; set; }
        public string informtel { get; set; }
        public string pname { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateOnly? birthday { get; set; }
    }
}