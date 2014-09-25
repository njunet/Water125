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
namespace Maticsoft.Model
{
	/// <summary>
	/// HIS_MEASURAND_Performance_Evaluation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HIS_MEASURAND_Performance_Evaluation
	{
		public HIS_MEASURAND_Performance_Evaluation()
		{}
		#region Model
		private string _indicators;
		private string _unit;
		private decimal? _y2005;
		private decimal? _y2006;
		private decimal? _y2007;
		private decimal? _y2008;
		private decimal? _y2009;
		private decimal? _y2010;
		private decimal? _y2011;
		private decimal? _y2012;
		private decimal? _y2013;
		private decimal? _y2014;
		private decimal? _y2015;
		private decimal? _y2016;
		/// <summary>
		/// 
		/// </summary>
		public string Indicators
		{
			set{ _indicators=value;}
			get{return _indicators;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2005
		{
			set{ _y2005=value;}
			get{return _y2005;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2006
		{
			set{ _y2006=value;}
			get{return _y2006;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2007
		{
			set{ _y2007=value;}
			get{return _y2007;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2008
		{
			set{ _y2008=value;}
			get{return _y2008;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2009
		{
			set{ _y2009=value;}
			get{return _y2009;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2010
		{
			set{ _y2010=value;}
			get{return _y2010;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2011
		{
			set{ _y2011=value;}
			get{return _y2011;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2012
		{
			set{ _y2012=value;}
			get{return _y2012;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2013
		{
			set{ _y2013=value;}
			get{return _y2013;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2014
		{
			set{ _y2014=value;}
			get{return _y2014;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2015
		{
			set{ _y2015=value;}
			get{return _y2015;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Y2016
		{
			set{ _y2016=value;}
			get{return _y2016;}
		}
		#endregion Model

	}
}

