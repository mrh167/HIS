using System;
using System.Collections.Generic;
using System.Text;

namespace ts_mz_class.PhysicalExamineCharge
{
    /// <summary>
    /// 查询条件对象
    /// </summary>
    public class QueryCondiction
    {
        private string examineNo;
        private string fileNo;
        private string name;
        private string sex;
        private DateTime? examineBeginDate;
        private DateTime? examineEndDate;
        /// <summary>
        /// 检查截止时间
        /// </summary>
        public DateTime? ExamineEndDate
        {
            get
            {
                return examineEndDate;
            }
            set
            {
                examineEndDate = value;
            }
        }
        /// <summary>
        /// 检查开始时间
        /// </summary>
        public DateTime? ExamineBeginDate
        {
            get
            {
                return examineBeginDate;
            }
            set
            {
                examineBeginDate = value;
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        /// <summary>
        /// 体检人姓名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// 档案号
        /// </summary>
        public string FileNo
        {
            get
            {
                return fileNo;
            }
            set
            {
                fileNo = value;
            }
        }
        /// <summary>
        /// 体检号
        /// </summary>
        public string ExamineNo
        {
            get
            {
                return examineNo;
            }
            set
            {
                examineNo = value;
            }
        }
    }
}
