/*******************************************************************************
 * Copyright © 2016 CCM.Framework 版權所有
 * Author: CCM
 * Description: CCM快速開發平臺
 * Website：http://www.CCM.cn
*********************************************************************************/

namespace CCM.Code
{
    /// <summary>
    /// 分頁資訊
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// 每頁行數
        /// </summary>
        public int rows { get; set; }
        /// <summary>
        /// 當前頁
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 排序列
        /// </summary>
        public string sidx { get; set; }
        /// <summary>
        /// 排序類型
        /// </summary>
        public string sord { get; set; }
        /// <summary>
        /// 總記錄數
        /// </summary>
        public int records { get; set; }
        /// <summary>
        /// 總頁數
        /// </summary>
        public int total
        {
            get
            {
                if (records > 0)
                {
                    return records % this.rows == 0 ? records / this.rows : records / this.rows + 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

