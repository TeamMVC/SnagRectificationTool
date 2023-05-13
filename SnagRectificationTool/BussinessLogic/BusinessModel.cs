using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace SnagRectificationTool.BussinessLogic
{


    public class BusinessModel
    {
        static string ConString = "Data Source=DESKTOP-B666D0S; Integrated Security=true; Initial Catalog=SnagRactificationTool;";
        SqlConnection con = new SqlConnection(ConString);
        public Models.System GetSystem(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
            Models.System result = con.QuerySingle<Models.System>("GetRectifySystem", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }
        public List<Models.SubSystem> GetSubSystem(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
            var result = con.Query<Models.SubSystem>("GetRectifySubSystem", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }


        public List<Models.ReqtificationItems> GetRectItems(int subSystemId)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@subSystemId", subSystemId);
            var result = con.Query<Models.ReqtificationItems>("GetRectificationItems", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }

        public int SaveAeroEngineSubstemForm(Models.SubsytemInitialFormModel aero)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@RefId", aero.RefId);
            param.Add("@Unit", aero.Unit);
            param.Add("@Ac_no", aero.AC_No);
            param.Add("@StartDt", aero.StartDate);
            param.Add("@AFHrs", aero.AFHrs);
            param.Add("@AFVal", aero.AFVal);
            param.Add("@ENGHrs", aero.ENGHrs);
            param.Add("@ENGVal", aero.ENGVal);
            param.Add("@BriefOfSnag", aero.BriefOfSnag);
            param.Add("@ENGOilLife", aero.ENGOilLife);
            param.Add("@SpareOnEXTN", aero.SpareOnEXTN);
            param.Add("@date", aero.Date);

            var result = con.Execute("InsertInitialDataCapture", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

        public List<Models.Symptoms> GetSymptom(int RectificationId)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@RectificationId", RectificationId);
            var result = con.Query<Models.Symptoms>("GetSymptomData", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }



        public int RemovedInitialFormData(string _refId)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@RefId", _refId);


            var result = con.Execute("Update_DataCaptureForm", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

        public List<Models.StepsModel> SendStepsByRectfid(int RectificationId)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@RectificationId", RectificationId);
            var result = con.Query<Models.StepsModel>("GetRectificationSteps", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
        public List<Models.StepsModel> SendStepsByRectfid(int RectificationId,int StepID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@RectificationId", RectificationId);
            param.Add("@StepID", StepID);
            var result = con.Query<Models.StepsModel>("GetRectificationStepsById", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
        public List<Models.ReqtificationItems> GetRectdataByRectfid(int RectificationId)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@RectificationId", RectificationId);
            var result = con.Query<Models.ReqtificationItems>("GetRectificationNameByID", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
        public List<Models.StepsData> GetModelStepsComponentData(int StepID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@StepID", StepID);
            var result = con.Query<Models.StepsData>("GetRectificationProcedure", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
        public List<Models.StepReferenceData> GetModelStepsReferenceData(int StepID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@StepID", StepID);
            var result = con.Query<Models.StepReferenceData>("GetRectificationStepReferences", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
        public List<Models.StepReferenceData> GetModelStepsReferenceData(int StepID,int ID )
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@StepID", StepID);
            param.Add("@StepReferences", StepID);
            var result = con.Query<Models.StepReferenceData>("GetRectificationStepReferencesById", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
        public int UpdateCompletionForm(Models.SubsytemInitialFormModel aero)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@RefId", aero.RefId);
            param.Add("@DateOfCompletion", aero.DateOfCompletion);
            param.Add("@TimeForRepairHrs", aero.TimeForRepairHrs);

            param.Add("@MANPOWER_UTILISED", aero.MANPOWER_UTILISED);
            param.Add("@AIR_FRAME", aero.AIR_FRAME);
            param.Add("@ELECT", aero.ELECT);
            param.Add("@AEROENGINE", aero.AEROENGINE);

            var result = con.Execute("UpdateCompletionForm", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }
        public Models.SubsytemInitialFormModel validReferenceId(string referenceId)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@referenceId", referenceId);
            var result = con.Query<Models.SubsytemInitialFormModel>("GetReference", param: param, commandType: CommandType.StoredProcedure).FirstOrDefault();

            return result;
        }
        public List<Models.SubSystem> GetAllSubSystem()
        {
            var result = con.Query<Models.SubSystem>("GetAllSubsystem", commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
    }
}
