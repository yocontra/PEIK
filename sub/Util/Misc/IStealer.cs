using System.Net.Mail;

namespace sub.Util.Misc
{
    interface IStealer
    {
        Attachment Attachment { get; set; }
        string Name { get; set; }
        string Data { get; set; }
        void Collect();
    }
}