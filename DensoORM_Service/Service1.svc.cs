using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DensoORM_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        Business_Layer.Transaction obj_Trans = new Business_Layer.Transaction();


        //public string  APKDetails(string RecepientType, string MachineGroup,string MachineName,string ModelName,string time,string ShiftName,string Operation, string Type)
        //{
        //    string Result ="";
        //    try
        //    {
        //        Entity_Layer.Transaction.Type = "GetDetails";
        //        DataTable dt= obj_Trans.BL_APKMasterDetails().Tables[0];

        //        Entity_Layer.Transaction.Type = "GetRecepientDetais";
        //        Entity_Layer.Transaction.MachineGroup = MachineGroup;
        //        Entity_Layer.Transaction.MachineName = MachineName;
        //        Entity_Layer.Transaction.RecepientType = RecepientType;
        //        Entity_Layer.Transaction.ModelNo = ModelName;
        //        Entity_Layer.Transaction.ShiftName = ShiftName;
        //        Entity_Layer.Transaction.Operation = Operation;
        //        Entity_Layer.Transaction.Time = time;
        //        Entity_Layer.Transaction.Type = "GetRecepientDetais";
        //        DataTable dt1 = obj_Trans.BL_SMSandCALLConfigDetails().Tables[0];
        //        Entity_Layer.Transaction.Type = Type;
        //        Result = obj_Trans.BL_AndonCall();
        //        if (Result == "Saved" || Type== "MaintenanceConfimatiom")
        //            if (RecepientType != "PART FEADER")
        //            {
        //                if (dt.Rows.Count > 0)
        //                {
        //                    if (dt1.Rows.Count > 0)
        //                    {
        //                        var request = (HttpWebRequest)WebRequest.Create("" + dt.Rows[0]["APKLink"].ToString() + "" + dt1.Rows[0]["RecipientNo"].ToString() + "&message=" + dt1.Rows[0]["RecipientMsg"].ToString() + "&authkey=" + dt.Rows[0]["Authendication"].ToString() + "");
        //                        var response = (HttpWebResponse)request.GetResponse();
        //                        var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        //                        if (responseString.Contains("success"))
        //                        {
        //                            Result = "Sent Successfully";
        //                        }
        //                        else
        //                        {
        //                            Result = responseString;
        //                        }

        //                        var request1 = (HttpWebRequest)WebRequest.Create("" + dt.Rows[1]["APKLink"].ToString() + "" + dt1.Rows[0]["RecipientMsg"].ToString() + "&country=91&mobiles=91" + dt1.Rows[0]["RecipientNo"].ToString() + "&authkey=" + dt.Rows[0]["Authendication"].ToString() + "");
        //                        var response1 = (HttpWebResponse)request1.GetResponse();
        //                        var responseString1 = new StreamReader(response1.GetResponseStream()).ReadToEnd();
        //                        if (responseString1.Length == 24)
        //                        {
        //                            Result = "Sent Successfully";
        //                        }
        //                        else
        //                        {
        //                            Result = responseString;
        //                        }
        //                    }
        //                }
        //            }
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return Result;
        //}

        public string Connect()
        {
            try
            {
                return string.Format("You entered: {0}", "True");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetMachineGroup(string Type)
        {
            try
            {
                Entity_Layer.Transaction.Type = Type;
                return obj_Trans.BL_MachineGroupDetails();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataSet Get_ShiftName(string MachineGroup, string MachineName)
        //{
        //    try
        //    {
        //        Entity_Layer.Transaction.MachineGroup = MachineGroup;
        //        Entity_Layer.Transaction.MachineName = MachineName;
        //        return obj_Trans.BL_GetShiftName();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public DataSet Kanban_Progress(string MachineGroup, string MachineName,  string Barcode, string TransactionType, string Type, string PartNo, string Qty, string ModelNo, string UserdID, string ChangeOver)
        {
            try
            {
                Entity_Layer.Transaction.MachineGroup = MachineGroup;
                Entity_Layer.Transaction.MachineName = MachineName;              
                Entity_Layer.Transaction.Kanban = Barcode;
                Entity_Layer.Transaction.TransactionType = TransactionType;
                Entity_Layer.Transaction.Type = Type;
                Entity_Layer.Transaction.PartNo = PartNo;
                Entity_Layer.Transaction.Qty = Qty;
                Entity_Layer.Transaction.ModelNo = ModelNo;
                Entity_Layer.Transaction.UserID = UserdID;
                Entity_Layer.Transaction.ChangeOver = ChangeOver;
                return obj_Trans.BL_KanbanProgress();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LoginValidate(string UserID, string Password,string Type)
        {
            try
            {
                Entity_Layer.Transaction.UserID = UserID;
                Entity_Layer.Transaction.Password = Password;
                Entity_Layer.Transaction.Type = Type;
                return obj_Trans.BL_ValidateLogin();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
