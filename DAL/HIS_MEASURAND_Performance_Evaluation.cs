/**  版本信息模板在安装目录下，可自行修改。
* HIS_MEASURAND_Performance_Evaluation.cs
*
* 功 能： N/A
* 类 名： HIS_MEASURAND_Performance_Evaluation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/9/23 22:27:58   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:HIS_MEASURAND_Performance_Evaluation
	/// </summary>
	public partial class HIS_MEASURAND_Performance_Evaluation
	{
		public HIS_MEASURAND_Performance_Evaluation()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.HIS_MEASURAND_Performance_Evaluation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HIS_MEASURAND_Performance_Evaluation(");
			strSql.Append("Indicators,Unit,Y2005,Y2006,Y2007,Y2008,Y2009,Y2010,Y2011,Y2012,Y2013,Y2014,Y2015,Y2016)");
			strSql.Append(" values (");
			strSql.Append("@Indicators,@Unit,@Y2005,@Y2006,@Y2007,@Y2008,@Y2009,@Y2010,@Y2011,@Y2012,@Y2013,@Y2014,@Y2015,@Y2016)");
			SqlParameter[] parameters = {
					new SqlParameter("@Indicators", SqlDbType.NVarChar,255),
					new SqlParameter("@Unit", SqlDbType.NVarChar,255),
					new SqlParameter("@Y2005", SqlDbType.Decimal,9),
					new SqlParameter("@Y2006", SqlDbType.Decimal,9),
					new SqlParameter("@Y2007", SqlDbType.Decimal,9),
					new SqlParameter("@Y2008", SqlDbType.Decimal,9),
					new SqlParameter("@Y2009", SqlDbType.Decimal,9),
					new SqlParameter("@Y2010", SqlDbType.Decimal,9),
					new SqlParameter("@Y2011", SqlDbType.Decimal,9),
					new SqlParameter("@Y2012", SqlDbType.Decimal,9),
					new SqlParameter("@Y2013", SqlDbType.Decimal,9),
					new SqlParameter("@Y2014", SqlDbType.Decimal,9),
					new SqlParameter("@Y2015", SqlDbType.Decimal,9),
					new SqlParameter("@Y2016", SqlDbType.Decimal,9)};
			parameters[0].Value = model.Indicators;
			parameters[1].Value = model.Unit;
			parameters[2].Value = model.Y2005;
			parameters[3].Value = model.Y2006;
			parameters[4].Value = model.Y2007;
			parameters[5].Value = model.Y2008;
			parameters[6].Value = model.Y2009;
			parameters[7].Value = model.Y2010;
			parameters[8].Value = model.Y2011;
			parameters[9].Value = model.Y2012;
			parameters[10].Value = model.Y2013;
			parameters[11].Value = model.Y2014;
			parameters[12].Value = model.Y2015;
			parameters[13].Value = model.Y2016;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.HIS_MEASURAND_Performance_Evaluation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HIS_MEASURAND_Performance_Evaluation set ");
			strSql.Append("Indicators=@Indicators,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("Y2005=@Y2005,");
			strSql.Append("Y2006=@Y2006,");
			strSql.Append("Y2007=@Y2007,");
			strSql.Append("Y2008=@Y2008,");
			strSql.Append("Y2009=@Y2009,");
			strSql.Append("Y2010=@Y2010,");
			strSql.Append("Y2011=@Y2011,");
			strSql.Append("Y2012=@Y2012,");
			strSql.Append("Y2013=@Y2013,");
			strSql.Append("Y2014=@Y2014,");
			strSql.Append("Y2015=@Y2015,");
			strSql.Append("Y2016=@Y2016");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Indicators", SqlDbType.NVarChar,255),
					new SqlParameter("@Unit", SqlDbType.NVarChar,255),
					new SqlParameter("@Y2005", SqlDbType.Decimal,9),
					new SqlParameter("@Y2006", SqlDbType.Decimal,9),
					new SqlParameter("@Y2007", SqlDbType.Decimal,9),
					new SqlParameter("@Y2008", SqlDbType.Decimal,9),
					new SqlParameter("@Y2009", SqlDbType.Decimal,9),
					new SqlParameter("@Y2010", SqlDbType.Decimal,9),
					new SqlParameter("@Y2011", SqlDbType.Decimal,9),
					new SqlParameter("@Y2012", SqlDbType.Decimal,9),
					new SqlParameter("@Y2013", SqlDbType.Decimal,9),
					new SqlParameter("@Y2014", SqlDbType.Decimal,9),
					new SqlParameter("@Y2015", SqlDbType.Decimal,9),
					new SqlParameter("@Y2016", SqlDbType.Decimal,9)};
			parameters[0].Value = model.Indicators;
			parameters[1].Value = model.Unit;
			parameters[2].Value = model.Y2005;
			parameters[3].Value = model.Y2006;
			parameters[4].Value = model.Y2007;
			parameters[5].Value = model.Y2008;
			parameters[6].Value = model.Y2009;
			parameters[7].Value = model.Y2010;
			parameters[8].Value = model.Y2011;
			parameters[9].Value = model.Y2012;
			parameters[10].Value = model.Y2013;
			parameters[11].Value = model.Y2014;
			parameters[12].Value = model.Y2015;
			parameters[13].Value = model.Y2016;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HIS_MEASURAND_Performance_Evaluation ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.HIS_MEASURAND_Performance_Evaluation GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Indicators,Unit,Y2005,Y2006,Y2007,Y2008,Y2009,Y2010,Y2011,Y2012,Y2013,Y2014,Y2015,Y2016 from HIS_MEASURAND_Performance_Evaluation ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.HIS_MEASURAND_Performance_Evaluation model=new Maticsoft.Model.HIS_MEASURAND_Performance_Evaluation();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.HIS_MEASURAND_Performance_Evaluation DataRowToModel(DataRow row)
		{
			Maticsoft.Model.HIS_MEASURAND_Performance_Evaluation model=new Maticsoft.Model.HIS_MEASURAND_Performance_Evaluation();
			if (row != null)
			{
				if(row["Indicators"]!=null)
				{
					model.Indicators=row["Indicators"].ToString();
				}
				if(row["Unit"]!=null)
				{
					model.Unit=row["Unit"].ToString();
				}
				if(row["Y2005"]!=null && row["Y2005"].ToString()!="")
				{
					model.Y2005=decimal.Parse(row["Y2005"].ToString());
				}
				if(row["Y2006"]!=null && row["Y2006"].ToString()!="")
				{
					model.Y2006=decimal.Parse(row["Y2006"].ToString());
				}
				if(row["Y2007"]!=null && row["Y2007"].ToString()!="")
				{
					model.Y2007=decimal.Parse(row["Y2007"].ToString());
				}
				if(row["Y2008"]!=null && row["Y2008"].ToString()!="")
				{
					model.Y2008=decimal.Parse(row["Y2008"].ToString());
				}
				if(row["Y2009"]!=null && row["Y2009"].ToString()!="")
				{
					model.Y2009=decimal.Parse(row["Y2009"].ToString());
				}
				if(row["Y2010"]!=null && row["Y2010"].ToString()!="")
				{
					model.Y2010=decimal.Parse(row["Y2010"].ToString());
				}
				if(row["Y2011"]!=null && row["Y2011"].ToString()!="")
				{
					model.Y2011=decimal.Parse(row["Y2011"].ToString());
				}
				if(row["Y2012"]!=null && row["Y2012"].ToString()!="")
				{
					model.Y2012=decimal.Parse(row["Y2012"].ToString());
				}
				if(row["Y2013"]!=null && row["Y2013"].ToString()!="")
				{
					model.Y2013=decimal.Parse(row["Y2013"].ToString());
				}
				if(row["Y2014"]!=null && row["Y2014"].ToString()!="")
				{
					model.Y2014=decimal.Parse(row["Y2014"].ToString());
				}
				if(row["Y2015"]!=null && row["Y2015"].ToString()!="")
				{
					model.Y2015=decimal.Parse(row["Y2015"].ToString());
				}
				if(row["Y2016"]!=null && row["Y2016"].ToString()!="")
				{
					model.Y2016=decimal.Parse(row["Y2016"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Indicators,Unit,Y2005,Y2006,Y2007,Y2008,Y2009,Y2010,Y2011,Y2012,Y2013,Y2014,Y2015,Y2016 ");
			strSql.Append(" FROM HIS_MEASURAND_Performance_Evaluation ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Indicators,Unit,Y2005,Y2006,Y2007,Y2008,Y2009,Y2010,Y2011,Y2012,Y2013,Y2014,Y2015,Y2016 ");
			strSql.Append(" FROM HIS_MEASURAND_Performance_Evaluation ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM HIS_MEASURAND_Performance_Evaluation ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from HIS_MEASURAND_Performance_Evaluation T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "HIS_MEASURAND_Performance_Evaluation";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

