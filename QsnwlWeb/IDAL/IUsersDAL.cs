using System;
using System.Data;
namespace TFXK.IDAL
{
	/// <summary>
	/// 接口层IUsersDAL 的摘要说明。
	/// </summary>
	public interface IUsersDAL
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(string uerName,string pass);
         /// <summary>
        /// 是否存在name
        /// </summary>
        bool Exists(string userName);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(TFXK.Model.Users model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(TFXK.Model.Users model);
        /// <summary>
        ///  更新密码
        /// </summary>
        void UpdatePassword(TFXK.Model.Users model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		void Delete(int id);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		TFXK.Model.Users GetModel(int id);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        TFXK.Model.Users GetModelByUserName(string username);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);

		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
	}
}
