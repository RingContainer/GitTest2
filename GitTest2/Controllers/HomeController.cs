using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTest2.Controllers
{
    public class HomeController : Controller
    {


        // private LNMSRSReportingEntities db = new LNMSRSReportingEntities();




        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {



            ViewBag.Message = "Your contact page.";

            return View();
        }

        public class CofA
        {
            public string CoaId { get; set; }

            public string BOLNumber { get; set; }

            public Boolean IsUltra35 { get; set; }
            public string MPRDNumber { get; set; }
            public string CustomerNumber { get; set; }

            public string CustomerName { get; set; }
            public DateTime ShipDate { get; set; }
            public string ItemNumber { get; set; }
            public int Quantity { get; set; }
            public string Phone { get; set; }
            public string Street { get; set; }
            public string Zip { get; set; }
            public string State { get; set; }
            public string RingLocation { get; set; }
            public string City { get; set; }
            public string Lotnumber { get; set; }
            public string ReportText { get; set; }
            public string Division { get; set; }
            public DateTime DateEntered { get; set; }
            public string AdditionalInfo { get; set; }
            public string AlternateItem { get; set; }
            public string MPRD { get; set; }
            public int GramWgtLsl { get; set; }
            public int GramWgtUsl { get; set; }
            public int MinWalLsl { get; set; }
            public int CartonHgtTar { get; set; }
            public int CartonHgtLsl { get; set; }
            public int CartonHgtUsl { get; set; }
            public int CartonWidthTar { get; set; }
            public int CartonWidthLsl { get; set; }
            public int CartonWidthUsl { get; set; }
            public int CartonDepthTar { get; set; }
            public int CartonDepthLsl { get; set; }
            public int CartonDepthUsl { get; set; }
            public float TDiameterTar { get; set; }
            public float TDiameterLsl { get; set; }
            public float TDiameterUsl { get; set; }
            public float TOvalityUsl { get; set; }
            public string Material { get; set; }
            public string Category { get; set; }
            public string SpecialMPRDValue { get; set; }
            public string lot { get; set; }
            public string HolderMPRD { get; set; }
            public float GramWgtCoa { get; set; }
            public float MinWalCoa { get; set; }
            public float TDiameterCoa { get; set; }
            public float TOvalityCoa { get; set; }
            public float CartonHgtCoa { get; set; }
            public float CartonWidthCoa { get; set; }
            public float CartonDepthCoa { get; set; }
            public string PlantMgr { get; set; }
            public string ProcessImpvMgr { get; set; }
            public string EnteredByUserName { get; set; }

        }
    }

}

