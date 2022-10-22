﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MoneyManager")]
	public partial class MoneyManagerDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMONTH(MONTH instance);
    partial void UpdateMONTH(MONTH instance);
    partial void DeleteMONTH(MONTH instance);
    partial void InsertTYPESOFEXPANSE(TYPESOFEXPANSE instance);
    partial void UpdateTYPESOFEXPANSE(TYPESOFEXPANSE instance);
    partial void DeleteTYPESOFEXPANSE(TYPESOFEXPANSE instance);
    partial void InsertUSER(USER instance);
    partial void UpdateUSER(USER instance);
    partial void DeleteUSER(USER instance);
    partial void InsertYEAR(YEAR instance);
    partial void UpdateYEAR(YEAR instance);
    partial void DeleteYEAR(YEAR instance);
    partial void InsertTYPE_INCOME_EXPANSE(TYPE_INCOME_EXPANSE instance);
    partial void UpdateTYPE_INCOME_EXPANSE(TYPE_INCOME_EXPANSE instance);
    partial void DeleteTYPE_INCOME_EXPANSE(TYPE_INCOME_EXPANSE instance);
    partial void InsertPOSITION(POSITION instance);
    partial void UpdatePOSITION(POSITION instance);
    partial void DeletePOSITION(POSITION instance);
    partial void InsertYearOverview(YearOverview instance);
    partial void UpdateYearOverview(YearOverview instance);
    partial void DeleteYearOverview(YearOverview instance);
    #endregion
		
		public MoneyManagerDataClassDataContext() : 
				base(global::DAL.Properties.Settings.Default.MoneyManagerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MoneyManagerDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MoneyManagerDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MoneyManagerDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MoneyManagerDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MONTH> MONTHs
		{
			get
			{
				return this.GetTable<MONTH>();
			}
		}
		
		public System.Data.Linq.Table<TYPESOFEXPANSE> TYPESOFEXPANSEs
		{
			get
			{
				return this.GetTable<TYPESOFEXPANSE>();
			}
		}
		
		public System.Data.Linq.Table<USER> USERs
		{
			get
			{
				return this.GetTable<USER>();
			}
		}
		
		public System.Data.Linq.Table<YEAR> YEARs
		{
			get
			{
				return this.GetTable<YEAR>();
			}
		}
		
		public System.Data.Linq.Table<TYPE_INCOME_EXPANSE> TYPE_INCOME_EXPANSEs
		{
			get
			{
				return this.GetTable<TYPE_INCOME_EXPANSE>();
			}
		}
		
		public System.Data.Linq.Table<POSITION> POSITIONs
		{
			get
			{
				return this.GetTable<POSITION>();
			}
		}
		
		public System.Data.Linq.Table<YearOverview> YearOverviews
		{
			get
			{
				return this.GetTable<YearOverview>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MONTHS")]
	public partial class MONTH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MonthName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMonthNameChanging(string value);
    partial void OnMonthNameChanged();
    #endregion
		
		public MONTH()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MonthName
		{
			get
			{
				return this._MonthName;
			}
			set
			{
				if ((this._MonthName != value))
				{
					this.OnMonthNameChanging(value);
					this.SendPropertyChanging();
					this._MonthName = value;
					this.SendPropertyChanged("MonthName");
					this.OnMonthNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TYPESOFEXPANSE")]
	public partial class TYPESOFEXPANSE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TypeOfExpanse;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTypeOfExpanseChanging(string value);
    partial void OnTypeOfExpanseChanged();
    #endregion
		
		public TYPESOFEXPANSE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeOfExpanse", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TypeOfExpanse
		{
			get
			{
				return this._TypeOfExpanse;
			}
			set
			{
				if ((this._TypeOfExpanse != value))
				{
					this.OnTypeOfExpanseChanging(value);
					this.SendPropertyChanging();
					this._TypeOfExpanse = value;
					this.SendPropertyChanged("TypeOfExpanse");
					this.OnTypeOfExpanseChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USERS")]
	public partial class USER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _InitialMoney;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnInitialMoneyChanging(int value);
    partial void OnInitialMoneyChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public USER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InitialMoney", DbType="Int NOT NULL")]
		public int InitialMoney
		{
			get
			{
				return this._InitialMoney;
			}
			set
			{
				if ((this._InitialMoney != value))
				{
					this.OnInitialMoneyChanging(value);
					this.SendPropertyChanging();
					this._InitialMoney = value;
					this.SendPropertyChanged("InitialMoney");
					this.OnInitialMoneyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.YEARS")]
	public partial class YEAR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _YearNumber;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnYearNumberChanging(int value);
    partial void OnYearNumberChanged();
    #endregion
		
		public YEAR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearNumber", DbType="Int NOT NULL")]
		public int YearNumber
		{
			get
			{
				return this._YearNumber;
			}
			set
			{
				if ((this._YearNumber != value))
				{
					this.OnYearNumberChanging(value);
					this.SendPropertyChanging();
					this._YearNumber = value;
					this.SendPropertyChanged("YearNumber");
					this.OnYearNumberChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TYPE_INCOME_EXPANSE")]
	public partial class TYPE_INCOME_EXPANSE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Income_Expanse;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIncome_ExpanseChanging(string value);
    partial void OnIncome_ExpanseChanged();
    #endregion
		
		public TYPE_INCOME_EXPANSE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Income/Expanse]", Storage="_Income_Expanse", DbType="VarChar(50)")]
		public string Income_Expanse
		{
			get
			{
				return this._Income_Expanse;
			}
			set
			{
				if ((this._Income_Expanse != value))
				{
					this.OnIncome_ExpanseChanging(value);
					this.SendPropertyChanging();
					this._Income_Expanse = value;
					this.SendPropertyChanged("Income_Expanse");
					this.OnIncome_ExpanseChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.POSITIONS")]
	public partial class POSITION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _TypeOfExpanseID;
		
		private int _Amount_of_Expanse;
		
		private System.DateTime _CreationDate;
		
		private int _YearID;
		
		private int _MonthID;
		
		private int _Income_ExpnaseID;
		
		private string _Income_ExpansePosition;
		
		private System.Nullable<int> _UserID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTypeOfExpanseIDChanging(int value);
    partial void OnTypeOfExpanseIDChanged();
    partial void OnAmount_of_ExpanseChanging(int value);
    partial void OnAmount_of_ExpanseChanged();
    partial void OnCreationDateChanging(System.DateTime value);
    partial void OnCreationDateChanged();
    partial void OnYearIDChanging(int value);
    partial void OnYearIDChanged();
    partial void OnMonthIDChanging(int value);
    partial void OnMonthIDChanged();
    partial void OnIncome_ExpnaseIDChanging(int value);
    partial void OnIncome_ExpnaseIDChanged();
    partial void OnIncome_ExpansePositionChanging(string value);
    partial void OnIncome_ExpansePositionChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    #endregion
		
		public POSITION()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeOfExpanseID", DbType="Int NOT NULL")]
		public int TypeOfExpanseID
		{
			get
			{
				return this._TypeOfExpanseID;
			}
			set
			{
				if ((this._TypeOfExpanseID != value))
				{
					this.OnTypeOfExpanseIDChanging(value);
					this.SendPropertyChanging();
					this._TypeOfExpanseID = value;
					this.SendPropertyChanged("TypeOfExpanseID");
					this.OnTypeOfExpanseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Amount of Expanse]", Storage="_Amount_of_Expanse", DbType="Int NOT NULL")]
		public int Amount_of_Expanse
		{
			get
			{
				return this._Amount_of_Expanse;
			}
			set
			{
				if ((this._Amount_of_Expanse != value))
				{
					this.OnAmount_of_ExpanseChanging(value);
					this.SendPropertyChanging();
					this._Amount_of_Expanse = value;
					this.SendPropertyChanged("Amount_of_Expanse");
					this.OnAmount_of_ExpanseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreationDate", DbType="Date NOT NULL")]
		public System.DateTime CreationDate
		{
			get
			{
				return this._CreationDate;
			}
			set
			{
				if ((this._CreationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._CreationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearID", DbType="Int NOT NULL")]
		public int YearID
		{
			get
			{
				return this._YearID;
			}
			set
			{
				if ((this._YearID != value))
				{
					this.OnYearIDChanging(value);
					this.SendPropertyChanging();
					this._YearID = value;
					this.SendPropertyChanged("YearID");
					this.OnYearIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthID", DbType="Int NOT NULL")]
		public int MonthID
		{
			get
			{
				return this._MonthID;
			}
			set
			{
				if ((this._MonthID != value))
				{
					this.OnMonthIDChanging(value);
					this.SendPropertyChanging();
					this._MonthID = value;
					this.SendPropertyChanged("MonthID");
					this.OnMonthIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Income/ExpnaseID]", Storage="_Income_ExpnaseID", DbType="Int NOT NULL")]
		public int Income_ExpnaseID
		{
			get
			{
				return this._Income_ExpnaseID;
			}
			set
			{
				if ((this._Income_ExpnaseID != value))
				{
					this.OnIncome_ExpnaseIDChanging(value);
					this.SendPropertyChanging();
					this._Income_ExpnaseID = value;
					this.SendPropertyChanged("Income_ExpnaseID");
					this.OnIncome_ExpnaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Income/ExpansePosition]", Storage="_Income_ExpansePosition", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Income_ExpansePosition
		{
			get
			{
				return this._Income_ExpansePosition;
			}
			set
			{
				if ((this._Income_ExpansePosition != value))
				{
					this.OnIncome_ExpansePositionChanging(value);
					this.SendPropertyChanging();
					this._Income_ExpansePosition = value;
					this.SendPropertyChanged("Income_ExpansePosition");
					this.OnIncome_ExpansePositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.YearOverview")]
	public partial class YearOverview : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _TypeOfExpanseID;
		
		private int _Total;
		
		private int _Average;
		
		private int _Income_ExpnaseID;
		
		private string _Income_ExpansePosition;
		
		private int _YearID;
		
		private int _UserID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTypeOfExpanseIDChanging(int value);
    partial void OnTypeOfExpanseIDChanged();
    partial void OnTotalChanging(int value);
    partial void OnTotalChanged();
    partial void OnAverageChanging(int value);
    partial void OnAverageChanged();
    partial void OnIncome_ExpnaseIDChanging(int value);
    partial void OnIncome_ExpnaseIDChanged();
    partial void OnIncome_ExpansePositionChanging(string value);
    partial void OnIncome_ExpansePositionChanged();
    partial void OnYearIDChanging(int value);
    partial void OnYearIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    #endregion
		
		public YearOverview()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeOfExpanseID", DbType="Int NOT NULL")]
		public int TypeOfExpanseID
		{
			get
			{
				return this._TypeOfExpanseID;
			}
			set
			{
				if ((this._TypeOfExpanseID != value))
				{
					this.OnTypeOfExpanseIDChanging(value);
					this.SendPropertyChanging();
					this._TypeOfExpanseID = value;
					this.SendPropertyChanged("TypeOfExpanseID");
					this.OnTypeOfExpanseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Int NOT NULL")]
		public int Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Average", DbType="Int NOT NULL")]
		public int Average
		{
			get
			{
				return this._Average;
			}
			set
			{
				if ((this._Average != value))
				{
					this.OnAverageChanging(value);
					this.SendPropertyChanging();
					this._Average = value;
					this.SendPropertyChanged("Average");
					this.OnAverageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Income/ExpnaseID]", Storage="_Income_ExpnaseID", DbType="Int NOT NULL")]
		public int Income_ExpnaseID
		{
			get
			{
				return this._Income_ExpnaseID;
			}
			set
			{
				if ((this._Income_ExpnaseID != value))
				{
					this.OnIncome_ExpnaseIDChanging(value);
					this.SendPropertyChanging();
					this._Income_ExpnaseID = value;
					this.SendPropertyChanged("Income_ExpnaseID");
					this.OnIncome_ExpnaseIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Income/ExpansePosition]", Storage="_Income_ExpansePosition", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Income_ExpansePosition
		{
			get
			{
				return this._Income_ExpansePosition;
			}
			set
			{
				if ((this._Income_ExpansePosition != value))
				{
					this.OnIncome_ExpansePositionChanging(value);
					this.SendPropertyChanging();
					this._Income_ExpansePosition = value;
					this.SendPropertyChanged("Income_ExpansePosition");
					this.OnIncome_ExpansePositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearID", DbType="Int NOT NULL")]
		public int YearID
		{
			get
			{
				return this._YearID;
			}
			set
			{
				if ((this._YearID != value))
				{
					this.OnYearIDChanging(value);
					this.SendPropertyChanging();
					this._YearID = value;
					this.SendPropertyChanged("YearID");
					this.OnYearIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591