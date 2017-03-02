using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess;
using System.Data;

namespace NineVigor.Domain.HealthRecord.Repository
{
    public class ICDMaintenceRepository : BaseRepository, IICDMaintenceRepository
    {

        /// <summary>
        /// 查询所有的诊断信息
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable SelectDiagnoseAll()
        {
            string exeSqlContent = string.Empty;
            if (base.GetSqlContent("CAS.Domain.ICDMatienctRepository.Diagnose.Query|CAS.Domain.ICDMatienctRepository.Diagnose.Query.Sort1", ref exeSqlContent) < 0)
            {
                return null;
            };
            DataSet ds = new DataSet();
            base.ExecQuery(exeSqlContent, ref ds);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return null;
        }
    }
}
