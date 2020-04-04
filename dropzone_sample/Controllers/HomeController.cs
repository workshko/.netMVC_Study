using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dropzone_sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 1. dropzone에서는 파일을 여러개 올리더라도 옵션이 'uploadMultiple = false' 설정되어있으므로, 파일 올린 수만큼 해당 함수 호출
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UploadFiles() 
        {
            System.Diagnostics.Debug.Print(Request.Files.Count.ToString());

            return View();
        }


    }
}