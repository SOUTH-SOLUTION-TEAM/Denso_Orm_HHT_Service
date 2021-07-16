using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DensoORM_Service.Entity_Layer
{
    public static class Transaction
    {
       static string _Type,_MachineName,_MachineGroup,_RecepientType,_RecepientNo,_ShiftName,_Time,_TransactionType,_Kanban,_PartNo,_Qty, _ModelNo,_UserID,_Password, _Operation, _ChangeOver;

        public static string Type { get => _Type; set => _Type = value; }
        public static string MachineName { get => _MachineName; set => _MachineName = value; }
        public static string MachineGroup { get => _MachineGroup; set => _MachineGroup = value; }
        public static string RecepientType { get => _RecepientType; set => _RecepientType = value; }
        public static string RecepientNo { get => _RecepientNo; set => _RecepientNo = value; }
        public static string ShiftName { get => _ShiftName; set => _ShiftName = value; }
        public static string Time { get => _Time; set => _Time = value; }
        public static string TransactionType { get => _TransactionType; set => _TransactionType = value; }
        public static string Kanban { get => _Kanban; set => _Kanban = value; }
        public static string PartNo { get => _PartNo; set => _PartNo = value; }
        public static string Qty { get => _Qty; set => _Qty = value; }
        public static string ModelNo { get => _ModelNo; set => _ModelNo = value; }
        public static string UserID { get => _UserID; set => _UserID = value; }
        public static string Password { get => _Password; set => _Password = value; }
        public static string Operation { get => _Operation; set => _Operation = value; }
        public static string ChangeOver { get => _ChangeOver; set => _ChangeOver = value; }
    }
}