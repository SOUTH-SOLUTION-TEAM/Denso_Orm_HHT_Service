using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace DensoORM_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]

    public interface IService1
    {

        [OperationContract]
        string Connect();
        [OperationContract]
        //string  APKDetails(string RecepientType, string MachineGroup, string MachineName, string ModelName, string time, string ShiftName, string Operation,string Type);
       // [OperationContract]
        DataSet GetMachineGroup(string Type);
        [OperationContract]
        DataSet Kanban_Progress(string MachineGroup, string MachineName, string Barcode, string TransactionType, string Type, string PartNo, string Qty,string ModelNo, string UserdID, string ChangeOver);
        //[OperationContract]
        //DataSet Get_ShiftName(string MachineGroup, string MachineName);
        [OperationContract]
        string LoginValidate(string UserID,string Password ,string Type);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}
