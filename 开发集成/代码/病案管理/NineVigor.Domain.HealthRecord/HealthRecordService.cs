using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NineVigor.FrameWork.DataAccess.Service;
using NineVigor.Domain.HealthRecord.Repository;
using NineVigor.FrameWork.DataAccess;

namespace NineVigor.Domain.HealthRecord
{
    public class HealthRecordService : BaseService, IHealthRecordService
    {
          /// 权限服务构造函数
        /// </summary>
        public HealthRecordService()
            : base()
        {
            
        }

        #region Repository 使用内容

        protected NineVigor.Domain.HealthRecord.Repository.ICasBaseRepository casBaseRepository = null;
        protected virtual NineVigor.Domain.HealthRecord.Repository.ICasBaseRepository CasBaseRepository
        {
            get
            {
                if (this.casBaseRepository == null)
                {
                    casBaseRepository = RepositoryFactory.CreateRepository<ICasBaseRepository>();
                }
                return casBaseRepository;
            }
        }
        #endregion
    }
}
