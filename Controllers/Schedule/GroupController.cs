#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult Group()
        {
            List<AirlineRes> airlines = new List<AirlineRes>();
            airlines.Add(new AirlineRes { AirlineName = "Airways 1", AirlineId = 1, AirlineColor = "#EA7A57" });
            airlines.Add(new AirlineRes { AirlineName = "Airways 2", AirlineId = 2, AirlineColor = "#357cd2" });
            airlines.Add(new AirlineRes { AirlineName = "Airways 3", AirlineId = 3, AirlineColor = "#7fa900" });
            ViewBag.Airlines = airlines;

            string[] resources = new string[] { "Airlines" };
            ViewBag.Resources = resources;
            return View();
        }
    }

    public class AirlineRes
    {
        public string AirlineName { set; get; }
        public int AirlineId { set; get; }
        public string AirlineColor { set; get; }
    }
}