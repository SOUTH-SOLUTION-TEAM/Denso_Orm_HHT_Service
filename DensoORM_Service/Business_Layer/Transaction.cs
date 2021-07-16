using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DensoORM_Service.Business_Layer
{
    public class Transaction
    {
        Data_Layer.DatabaseConnections obj_DB = new Data_Layer.DatabaseConnections();
        #region Login

        public string BL_ValidateLogin()
        {
            try
            {
                return obj_DB.ExecuteProcedureParam("Proc_Login", Entity_Layer.Transaction.UserID,Entity_Layer.Transaction.Password,"", Entity_Layer.Transaction.Type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region APKMASTER

        public DataSet BL_APKMasterDetails()
        {
            try
            {
                return obj_DB.ExecuteDataSetParam("Proc_APKMaster", Entity_Layer.Transaction.Type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region SMSandCALLConfig

        public DataSet BL_SMSandCALLConfigDetails()
        {
            try
            {
                return obj_DB.ExecuteDataSetParam("Proc_SMSandCALConfiguration",0,Entity_Layer.Transaction.MachineGroup,Entity_Layer.Transaction.MachineName,Entity_Layer.Transaction.RecepientType,"","","", Entity_Layer.Transaction.Type,"");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region MachineGroup
      
        public DataSet BL_MachineGroupDetails()
        {
            try
            {
                return obj_DB.ExecuteDataSetParam("Proc_MachineGroupMaster",0, "", "", "", "","","", Entity_Layer.Transaction.Type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region KanbanProgress
        public DataSet BL_KanbanProgress()
        {
            try
            {
                return obj_DB.ExecuteDataSetParam("Proc_KanbanProgress", Entity_Layer.Transaction.MachineGroup, Entity_Layer.Transaction.MachineName, Entity_Layer.Transaction.Kanban, Entity_Layer.Transaction.TransactionType, Entity_Layer.Transaction.Type, Entity_Layer.Transaction.PartNo, Entity_Layer.Transaction.Qty, Entity_Layer.Transaction.ModelNo, Entity_Layer.Transaction.UserID, Entity_Layer.Transaction.ChangeOver);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GetShiftName
        public DataSet BL_GetShiftName()
        {
            try
            {
                return obj_DB.ExecuteDataSetParam("Proc_GetShiftName", Entity_Layer.Transaction.MachineGroup, Entity_Layer.Transaction.MachineName);
                    }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region AndonCall
        public string BL_AndonCall()
        {
            try
            {
                return obj_DB.ExecuteProcedureParam("Proc_AndonCall", Entity_Layer.Transaction.MachineGroup, Entity_Layer.Transaction.MachineName, Entity_Layer.Transaction.RecepientType, Entity_Layer.Transaction.Operation, Entity_Layer.Transaction.ModelNo, Entity_Layer.Transaction.Time, Entity_Layer.Transaction.ShiftName, Entity_Layer.Transaction.Type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}