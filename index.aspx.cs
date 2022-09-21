using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataGateWay
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string[] keys = Request.Form.AllKeys;

                if (keys.Length > 0)
                {
                    LabelsAction log = new LabelsAction();

                    for (int i = 0; i < keys.Length; i++)
                    {
                      

                        if (keys[i] == "SerialID")
                        {
                            log.LabelSerialId = Request.Form[keys[i]];
                        }

                        if (keys[i] == "BatteryVoltage")
                        {
                            log.BatteryVoltage = Request.Form[keys[i]];
                        }

                        if (keys[i] == "BatterLevel")
                        {
                            log.BatterLevel = "%" + Request.Form[keys[i]];
                        }

                        if (keys[i] == "SsId")
                        {
                            log.SsId = Request.Form[keys[i]];
                        }

                        if (keys[i] == "Wifipassword")
                        {
                            log.WifiPassword = Request.Form[keys[i]];
                        }

                        if (keys[i] == "interval")
                        {
                            log.Interval = Request.Form[keys[i]];
                        }

                        if (keys[i] == "Variable1")
                        {
                            log.Variable1 = Request.Form[keys[i]];
                        }

                        if (keys[i] == "Variable2")
                        {
                            log.Variable2 = Request.Form[keys[i]];
                        }

                        if (keys[i] == "Variable3")
                        {
                            log.Variable3 = Request.Form[keys[i]];
                        }

                        if (keys[i] == "HttpPostLink")
                        {
                            log.HttpPostLink = Request.Form[keys[i]];
                        }

                        if (keys[i] == "ClvUsername")
                        {
                            log.ClvUserName = Request.Form[keys[i]];
                        }

                        if (keys[i] == "ClvPassword")
                        {
                            log.ClvPassword = Request.Form[keys[i]];
                        }

                        if (keys[i] == "GeoRequestData")
                        {
                            try
                            {
                                log.GeoRequestData = Request.Form[keys[i]].ToString();
                            }
                            catch (Exception)
                            {


                            }
                        }

                        if (keys[i] == "networks")
                        {
                            try
                            {
                                log.Networks = Request.Form[keys[i]].ToString();
                            }
                            catch (Exception)
                            {


                            }
                        }

                        log.CreDate = DateTime.Now;
                        Response.Write(log);
                        
                    }


                   
                }


            }
            catch (Exception ex)
            {


            }
        }
    }
}