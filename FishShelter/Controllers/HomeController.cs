using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace FishShelter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Room()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Notice()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Location()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string a)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.To.Add("a33428144@hotmail.com");
                msg.From = new MailAddress("a33428144@gmail.com", "Felix", System.Text.Encoding.UTF8);
                //郵件標題 
                msg.Subject = "魚礁十五號網站留言";
                //郵件標題編碼  
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                //郵件內容
                msg.Body = "嘿嘿嘿";
                msg.IsBodyHtml = true;
                msg.BodyEncoding = System.Text.Encoding.UTF8;//郵件內容編碼 
                msg.Priority = MailPriority.Normal;//郵件優先級 
                                                   //建立 SmtpClient 物件 並設定 Gmail的smtp主機及Port 

                SmtpClient smtep = new SmtpClient("smtp.gmail.com", 587);
                //設定你的帳號密碼
                smtep.Credentials = new System.Net.NetworkCredential("a33428144@gmail.com", "Aa84586138");
                //Gmial 的 smtp 使用 SSL
                smtep.EnableSsl = true;
                smtep.Send(msg);
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}