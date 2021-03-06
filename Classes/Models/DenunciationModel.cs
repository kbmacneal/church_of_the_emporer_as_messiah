namespace emperor_mvc.Models
{
    public class DenunciationModel
    {
        public string link
        {
            get;
            set;
        }

        public string html { get; set; }
        public string link_html { get; set; }

        public void set_html()
        {
            // this.html = "<iframe class=\"mx-auto d-block\" src=\"/Documents/ninth_virtue_charity.pdf\" width=\"100%\" height=\"100%\"> This browser does not support PDFs. Please download the PDF to view it: <a href=" + this.link + ">Download PDF</a></iframe>";

            // this.html = "<object class=\"mx-auto d-block w-100\" data=" + this.link + " type=\"application/pdf\"><embed src=" + this.link + " type=application/pdf />    </object></br>";

            // this.html = "<embed class=\"mx-auto d-block w-100\" src=" + this.link +"  alt=\"pdf\" pluginspage=\"http://www.adobe.com/products/acrobat/readstep2.html\">";

            this.html = "<iframe src=\"https://docs.google.com/gview?url=" + this.link + "&embedded=true\" class=\"mx-auto d-block w-100\" frameborder=\"0\"></iframe>";

            this.link_html = "<a class=\"mx-auto d-block\" href=\"" + this.link + "\" target=\"_blank\">Link to PDF</a>";
        }
    }
}