using System;
using System.Drawing.Imaging;
using MessagingToolkit.QRCode.Codec;

namespace CodeCreator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var qRCode = new QRCodeEncoder();
            var img = qRCode.Encode("zhang");
            img.Save("E:\\Code\\GitHub\\QRCode\\CodeCreator\\CodeCreator\\Contents\\Images\\img.jpg", ImageFormat.Jpeg);
            QRCode.ImageUrl = "~/Contents/Images/img.jpg";
        }
    }
}