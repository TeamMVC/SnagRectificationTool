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
        static string ConString = "Data Source=AZAM-PC\\SQLEXPRESS; Integrated Security=true; Initial Catalog=SnagRactificationTool;";
        SqlConnection con = new SqlConnection(ConString);
        public  Models.System GetSystem(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id",id);
            Models.System result = con.QuerySingle<Models.System>("GetRectifySystem",param:param,commandType:CommandType.StoredProcedure);
            return result;
        }
        public List<Models.SubSystem> GetSubSystem(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
           var  result = con.Query<Models.SubSystem>("GetRectifySubSystem", param: param, commandType: CommandType.StoredProcedure).ToList();
            return result;
        }
    }
}
