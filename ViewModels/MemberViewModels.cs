namespace MemberStorage.ViewModels
{
    public class MemberViewModels
    {
    }
    public class ChangeMemberNameViewModels
    {
        public int MemberId {  get; set; }
        public string MemberName { get; set;}
    }
    public class Json
    {
        
        public int Code {  get; set; }
        public string Message {  get; set; }
        public Json(int c, string m)
        {
            this.Code = c;
            this.Message = m;
        }
    }
}
