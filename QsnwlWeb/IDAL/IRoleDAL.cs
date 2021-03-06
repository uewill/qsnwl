using System;
using System.Data;
namespace TFXK.IDAL
{
	/// <summary>
	/// 接口层IRoleDAL 的摘要说明。
	/// </summary>
	public interface IRoleDAL
	{
		#region  成员方法
		bool Exists(int id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(TFXK.Model.Role model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(TFXK.Model.Role model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		void Delete(int id);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		TFXK.Model.Role GetModel(int id);
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
