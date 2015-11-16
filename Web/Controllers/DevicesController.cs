// ---------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------

namespace Microsoft.Azure.Devices.Applications.PredictiveMaintenance.Web.Controllers
{
    using System.Web.Mvc;

    public sealed class DevicesController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}