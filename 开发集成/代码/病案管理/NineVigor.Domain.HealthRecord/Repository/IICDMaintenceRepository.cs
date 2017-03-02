using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace NineVigor.Domain.HealthRecord.Repository
{
    public interface IICDMaintenceRepository
    {
        /// <summary>
        /// 查询所有的病案诊断ICD10信息
        /// </summary>
        /// <returns></returns>
        DataTable SelectDiagnoseAll();
    }
}
