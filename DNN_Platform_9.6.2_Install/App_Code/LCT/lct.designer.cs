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

namespace LCT
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="lctvue")]
	public partial class lctDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCanBo(CanBo instance);
    partial void UpdateCanBo(CanBo instance);
    partial void DeleteCanBo(CanBo instance);
    partial void InsertDonVi(DonVi instance);
    partial void UpdateDonVi(DonVi instance);
    partial void DeleteDonVi(DonVi instance);
    partial void InsertLichCongTac(LichCongTac instance);
    partial void UpdateLichCongTac(LichCongTac instance);
    partial void DeleteLichCongTac(LichCongTac instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public lctDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public lctDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lctDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lctDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lctDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CanBo> CanBos
		{
			get
			{
				return this.GetTable<CanBo>();
			}
		}
		
		public System.Data.Linq.Table<DonVi> DonVis
		{
			get
			{
				return this.GetTable<DonVi>();
			}
		}
		
		public System.Data.Linq.Table<LichCongTac> LichCongTacs
		{
			get
			{
				return this.GetTable<LichCongTac>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserInfo> UserInfos
		{
			get
			{
				return this.GetTable<UserInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CanBo")]
	public partial class CanBo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Canbo;
		
		private string _Hovaten;
		
		private string _Email;
		
		private string _Sodienthoai;
		
		private string _Phongban;
		
		private string _Chucvu;
		
		private string _Ghichu;
		
		private System.Nullable<int> _Donvi_ID;
		
		private EntitySet<LichCongTac> _LichCongTacs;
		
		private EntityRef<DonVi> _DonVi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_CanboChanging(int value);
    partial void OnID_CanboChanged();
    partial void OnHovatenChanging(string value);
    partial void OnHovatenChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSodienthoaiChanging(string value);
    partial void OnSodienthoaiChanged();
    partial void OnPhongbanChanging(string value);
    partial void OnPhongbanChanged();
    partial void OnChucvuChanging(string value);
    partial void OnChucvuChanged();
    partial void OnGhichuChanging(string value);
    partial void OnGhichuChanged();
    partial void OnDonvi_IDChanging(System.Nullable<int> value);
    partial void OnDonvi_IDChanged();
    #endregion
		
		public CanBo()
		{
			this._LichCongTacs = new EntitySet<LichCongTac>(new Action<LichCongTac>(this.attach_LichCongTacs), new Action<LichCongTac>(this.detach_LichCongTacs));
			this._DonVi = default(EntityRef<DonVi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Canbo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Canbo
		{
			get
			{
				return this._ID_Canbo;
			}
			set
			{
				if ((this._ID_Canbo != value))
				{
					this.OnID_CanboChanging(value);
					this.SendPropertyChanging();
					this._ID_Canbo = value;
					this.SendPropertyChanged("ID_Canbo");
					this.OnID_CanboChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hovaten", DbType="NVarChar(250)")]
		public string Hovaten
		{
			get
			{
				return this._Hovaten;
			}
			set
			{
				if ((this._Hovaten != value))
				{
					this.OnHovatenChanging(value);
					this.SendPropertyChanging();
					this._Hovaten = value;
					this.SendPropertyChanged("Hovaten");
					this.OnHovatenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(250)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sodienthoai", DbType="NVarChar(150)")]
		public string Sodienthoai
		{
			get
			{
				return this._Sodienthoai;
			}
			set
			{
				if ((this._Sodienthoai != value))
				{
					this.OnSodienthoaiChanging(value);
					this.SendPropertyChanging();
					this._Sodienthoai = value;
					this.SendPropertyChanged("Sodienthoai");
					this.OnSodienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phongban", DbType="NVarChar(MAX)")]
		public string Phongban
		{
			get
			{
				return this._Phongban;
			}
			set
			{
				if ((this._Phongban != value))
				{
					this.OnPhongbanChanging(value);
					this.SendPropertyChanging();
					this._Phongban = value;
					this.SendPropertyChanged("Phongban");
					this.OnPhongbanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chucvu", DbType="NVarChar(150)")]
		public string Chucvu
		{
			get
			{
				return this._Chucvu;
			}
			set
			{
				if ((this._Chucvu != value))
				{
					this.OnChucvuChanging(value);
					this.SendPropertyChanging();
					this._Chucvu = value;
					this.SendPropertyChanged("Chucvu");
					this.OnChucvuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ghichu", DbType="NVarChar(MAX)")]
		public string Ghichu
		{
			get
			{
				return this._Ghichu;
			}
			set
			{
				if ((this._Ghichu != value))
				{
					this.OnGhichuChanging(value);
					this.SendPropertyChanging();
					this._Ghichu = value;
					this.SendPropertyChanged("Ghichu");
					this.OnGhichuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Donvi_ID", DbType="Int")]
		public System.Nullable<int> Donvi_ID
		{
			get
			{
				return this._Donvi_ID;
			}
			set
			{
				if ((this._Donvi_ID != value))
				{
					if (this._DonVi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDonvi_IDChanging(value);
					this.SendPropertyChanging();
					this._Donvi_ID = value;
					this.SendPropertyChanged("Donvi_ID");
					this.OnDonvi_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CanBo_LichCongTac", Storage="_LichCongTacs", ThisKey="ID_Canbo", OtherKey="CanBo_ID")]
		public EntitySet<LichCongTac> LichCongTacs
		{
			get
			{
				return this._LichCongTacs;
			}
			set
			{
				this._LichCongTacs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonVi_CanBo", Storage="_DonVi", ThisKey="Donvi_ID", OtherKey="ID_Donvi", IsForeignKey=true)]
		public DonVi DonVi
		{
			get
			{
				return this._DonVi.Entity;
			}
			set
			{
				DonVi previousValue = this._DonVi.Entity;
				if (((previousValue != value) 
							|| (this._DonVi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonVi.Entity = null;
						previousValue.CanBos.Remove(this);
					}
					this._DonVi.Entity = value;
					if ((value != null))
					{
						value.CanBos.Add(this);
						this._Donvi_ID = value.ID_Donvi;
					}
					else
					{
						this._Donvi_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("DonVi");
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
		
		private void attach_LichCongTacs(LichCongTac entity)
		{
			this.SendPropertyChanging();
			entity.CanBo = this;
		}
		
		private void detach_LichCongTacs(LichCongTac entity)
		{
			this.SendPropertyChanging();
			entity.CanBo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonVi")]
	public partial class DonVi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Donvi;
		
		private string _Nhom_Donvi;
		
		private string _Ten_Donvi;
		
		private string _Mota_Donvi;
		
		private System.Nullable<int> _Thutu_Donvi;
		
		private EntitySet<CanBo> _CanBos;
		
		private EntitySet<LichCongTac> _LichCongTacs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_DonviChanging(int value);
    partial void OnID_DonviChanged();
    partial void OnNhom_DonviChanging(string value);
    partial void OnNhom_DonviChanged();
    partial void OnTen_DonviChanging(string value);
    partial void OnTen_DonviChanged();
    partial void OnMota_DonviChanging(string value);
    partial void OnMota_DonviChanged();
    partial void OnThutu_DonviChanging(System.Nullable<int> value);
    partial void OnThutu_DonviChanged();
    #endregion
		
		public DonVi()
		{
			this._CanBos = new EntitySet<CanBo>(new Action<CanBo>(this.attach_CanBos), new Action<CanBo>(this.detach_CanBos));
			this._LichCongTacs = new EntitySet<LichCongTac>(new Action<LichCongTac>(this.attach_LichCongTacs), new Action<LichCongTac>(this.detach_LichCongTacs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Donvi", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Donvi
		{
			get
			{
				return this._ID_Donvi;
			}
			set
			{
				if ((this._ID_Donvi != value))
				{
					this.OnID_DonviChanging(value);
					this.SendPropertyChanging();
					this._ID_Donvi = value;
					this.SendPropertyChanged("ID_Donvi");
					this.OnID_DonviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nhom_Donvi", DbType="VarChar(100)")]
		public string Nhom_Donvi
		{
			get
			{
				return this._Nhom_Donvi;
			}
			set
			{
				if ((this._Nhom_Donvi != value))
				{
					this.OnNhom_DonviChanging(value);
					this.SendPropertyChanging();
					this._Nhom_Donvi = value;
					this.SendPropertyChanged("Nhom_Donvi");
					this.OnNhom_DonviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten_Donvi", DbType="VarChar(100)")]
		public string Ten_Donvi
		{
			get
			{
				return this._Ten_Donvi;
			}
			set
			{
				if ((this._Ten_Donvi != value))
				{
					this.OnTen_DonviChanging(value);
					this.SendPropertyChanging();
					this._Ten_Donvi = value;
					this.SendPropertyChanged("Ten_Donvi");
					this.OnTen_DonviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mota_Donvi", DbType="VarChar(1000)")]
		public string Mota_Donvi
		{
			get
			{
				return this._Mota_Donvi;
			}
			set
			{
				if ((this._Mota_Donvi != value))
				{
					this.OnMota_DonviChanging(value);
					this.SendPropertyChanging();
					this._Mota_Donvi = value;
					this.SendPropertyChanged("Mota_Donvi");
					this.OnMota_DonviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thutu_Donvi", DbType="Int")]
		public System.Nullable<int> Thutu_Donvi
		{
			get
			{
				return this._Thutu_Donvi;
			}
			set
			{
				if ((this._Thutu_Donvi != value))
				{
					this.OnThutu_DonviChanging(value);
					this.SendPropertyChanging();
					this._Thutu_Donvi = value;
					this.SendPropertyChanged("Thutu_Donvi");
					this.OnThutu_DonviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonVi_CanBo", Storage="_CanBos", ThisKey="ID_Donvi", OtherKey="Donvi_ID")]
		public EntitySet<CanBo> CanBos
		{
			get
			{
				return this._CanBos;
			}
			set
			{
				this._CanBos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonVi_LichCongTac", Storage="_LichCongTacs", ThisKey="ID_Donvi", OtherKey="Donvi_ID")]
		public EntitySet<LichCongTac> LichCongTacs
		{
			get
			{
				return this._LichCongTacs;
			}
			set
			{
				this._LichCongTacs.Assign(value);
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
		
		private void attach_CanBos(CanBo entity)
		{
			this.SendPropertyChanging();
			entity.DonVi = this;
		}
		
		private void detach_CanBos(CanBo entity)
		{
			this.SendPropertyChanging();
			entity.DonVi = null;
		}
		
		private void attach_LichCongTacs(LichCongTac entity)
		{
			this.SendPropertyChanging();
			entity.DonVi = this;
		}
		
		private void detach_LichCongTacs(LichCongTac entity)
		{
			this.SendPropertyChanging();
			entity.DonVi = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LichCongTac")]
	public partial class LichCongTac : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Lich;
		
		private System.Nullable<System.DateTime> _Ngay_Giohop;
		
		private System.Nullable<int> _Donvi_ID;
		
		private System.Nullable<int> _CanBo_ID;
		
		private string _Diadiem;
		
		private string _Noidung;
		
		private string _ThanhPhan;
		
		private EntityRef<CanBo> _CanBo;
		
		private EntityRef<DonVi> _DonVi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_LichChanging(int value);
    partial void OnID_LichChanged();
    partial void OnNgay_GiohopChanging(System.Nullable<System.DateTime> value);
    partial void OnNgay_GiohopChanged();
    partial void OnDonvi_IDChanging(System.Nullable<int> value);
    partial void OnDonvi_IDChanged();
    partial void OnCanBo_IDChanging(System.Nullable<int> value);
    partial void OnCanBo_IDChanged();
    partial void OnDiadiemChanging(string value);
    partial void OnDiadiemChanged();
    partial void OnNoidungChanging(string value);
    partial void OnNoidungChanged();
    partial void OnThanhPhanChanging(string value);
    partial void OnThanhPhanChanged();
    #endregion
		
		public LichCongTac()
		{
			this._CanBo = default(EntityRef<CanBo>);
			this._DonVi = default(EntityRef<DonVi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Lich", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Lich
		{
			get
			{
				return this._ID_Lich;
			}
			set
			{
				if ((this._ID_Lich != value))
				{
					this.OnID_LichChanging(value);
					this.SendPropertyChanging();
					this._ID_Lich = value;
					this.SendPropertyChanged("ID_Lich");
					this.OnID_LichChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngay_Giohop", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngay_Giohop
		{
			get
			{
				return this._Ngay_Giohop;
			}
			set
			{
				if ((this._Ngay_Giohop != value))
				{
					this.OnNgay_GiohopChanging(value);
					this.SendPropertyChanging();
					this._Ngay_Giohop = value;
					this.SendPropertyChanged("Ngay_Giohop");
					this.OnNgay_GiohopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Donvi_ID", DbType="Int")]
		public System.Nullable<int> Donvi_ID
		{
			get
			{
				return this._Donvi_ID;
			}
			set
			{
				if ((this._Donvi_ID != value))
				{
					if (this._DonVi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDonvi_IDChanging(value);
					this.SendPropertyChanging();
					this._Donvi_ID = value;
					this.SendPropertyChanged("Donvi_ID");
					this.OnDonvi_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanBo_ID", DbType="Int")]
		public System.Nullable<int> CanBo_ID
		{
			get
			{
				return this._CanBo_ID;
			}
			set
			{
				if ((this._CanBo_ID != value))
				{
					if (this._CanBo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCanBo_IDChanging(value);
					this.SendPropertyChanging();
					this._CanBo_ID = value;
					this.SendPropertyChanged("CanBo_ID");
					this.OnCanBo_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diadiem", DbType="NVarChar(250)")]
		public string Diadiem
		{
			get
			{
				return this._Diadiem;
			}
			set
			{
				if ((this._Diadiem != value))
				{
					this.OnDiadiemChanging(value);
					this.SendPropertyChanging();
					this._Diadiem = value;
					this.SendPropertyChanged("Diadiem");
					this.OnDiadiemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Noidung", DbType="NVarChar(MAX)")]
		public string Noidung
		{
			get
			{
				return this._Noidung;
			}
			set
			{
				if ((this._Noidung != value))
				{
					this.OnNoidungChanging(value);
					this.SendPropertyChanging();
					this._Noidung = value;
					this.SendPropertyChanged("Noidung");
					this.OnNoidungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhPhan", DbType="NVarChar(250)")]
		public string ThanhPhan
		{
			get
			{
				return this._ThanhPhan;
			}
			set
			{
				if ((this._ThanhPhan != value))
				{
					this.OnThanhPhanChanging(value);
					this.SendPropertyChanging();
					this._ThanhPhan = value;
					this.SendPropertyChanged("ThanhPhan");
					this.OnThanhPhanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CanBo_LichCongTac", Storage="_CanBo", ThisKey="CanBo_ID", OtherKey="ID_Canbo", IsForeignKey=true)]
		public CanBo CanBo
		{
			get
			{
				return this._CanBo.Entity;
			}
			set
			{
				CanBo previousValue = this._CanBo.Entity;
				if (((previousValue != value) 
							|| (this._CanBo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CanBo.Entity = null;
						previousValue.LichCongTacs.Remove(this);
					}
					this._CanBo.Entity = value;
					if ((value != null))
					{
						value.LichCongTacs.Add(this);
						this._CanBo_ID = value.ID_Canbo;
					}
					else
					{
						this._CanBo_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("CanBo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonVi_LichCongTac", Storage="_DonVi", ThisKey="Donvi_ID", OtherKey="ID_Donvi", IsForeignKey=true)]
		public DonVi DonVi
		{
			get
			{
				return this._DonVi.Entity;
			}
			set
			{
				DonVi previousValue = this._DonVi.Entity;
				if (((previousValue != value) 
							|| (this._DonVi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonVi.Entity = null;
						previousValue.LichCongTacs.Remove(this);
					}
					this._DonVi.Entity = value;
					if ((value != null))
					{
						value.LichCongTacs.Add(this);
						this._Donvi_ID = value.ID_Donvi;
					}
					else
					{
						this._Donvi_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("DonVi");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _Username;
		
		private string _FirstName;
		
		private string _LastName;
		
		private bool _IsSuperUser;
		
		private System.Nullable<int> _AffiliateId;
		
		private string _Email;
		
		private string _DisplayName;
		
		private bool _UpdatePassword;
		
		private string _LastIPAddress;
		
		private bool _IsDeleted;
		
		private System.Nullable<int> _CreatedByUserID;
		
		private System.Nullable<System.DateTime> _CreatedOnDate;
		
		private System.Nullable<int> _LastModifiedByUserID;
		
		private System.Nullable<System.DateTime> _LastModifiedOnDate;
		
		private System.Nullable<System.Guid> _PasswordResetToken;
		
		private System.Nullable<System.DateTime> _PasswordResetExpiration;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnIsSuperUserChanging(bool value);
    partial void OnIsSuperUserChanged();
    partial void OnAffiliateIdChanging(System.Nullable<int> value);
    partial void OnAffiliateIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDisplayNameChanging(string value);
    partial void OnDisplayNameChanged();
    partial void OnUpdatePasswordChanging(bool value);
    partial void OnUpdatePasswordChanged();
    partial void OnLastIPAddressChanging(string value);
    partial void OnLastIPAddressChanged();
    partial void OnIsDeletedChanging(bool value);
    partial void OnIsDeletedChanged();
    partial void OnCreatedByUserIDChanging(System.Nullable<int> value);
    partial void OnCreatedByUserIDChanged();
    partial void OnCreatedOnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnDateChanged();
    partial void OnLastModifiedByUserIDChanging(System.Nullable<int> value);
    partial void OnLastModifiedByUserIDChanged();
    partial void OnLastModifiedOnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastModifiedOnDateChanged();
    partial void OnPasswordResetTokenChanging(System.Nullable<System.Guid> value);
    partial void OnPasswordResetTokenChanged();
    partial void OnPasswordResetExpirationChanging(System.Nullable<System.DateTime> value);
    partial void OnPasswordResetExpirationChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSuperUser", DbType="Bit NOT NULL")]
		public bool IsSuperUser
		{
			get
			{
				return this._IsSuperUser;
			}
			set
			{
				if ((this._IsSuperUser != value))
				{
					this.OnIsSuperUserChanging(value);
					this.SendPropertyChanging();
					this._IsSuperUser = value;
					this.SendPropertyChanged("IsSuperUser");
					this.OnIsSuperUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AffiliateId", DbType="Int")]
		public System.Nullable<int> AffiliateId
		{
			get
			{
				return this._AffiliateId;
			}
			set
			{
				if ((this._AffiliateId != value))
				{
					this.OnAffiliateIdChanging(value);
					this.SendPropertyChanging();
					this._AffiliateId = value;
					this.SendPropertyChanged("AffiliateId");
					this.OnAffiliateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisplayName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string DisplayName
		{
			get
			{
				return this._DisplayName;
			}
			set
			{
				if ((this._DisplayName != value))
				{
					this.OnDisplayNameChanging(value);
					this.SendPropertyChanging();
					this._DisplayName = value;
					this.SendPropertyChanged("DisplayName");
					this.OnDisplayNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatePassword", DbType="Bit NOT NULL")]
		public bool UpdatePassword
		{
			get
			{
				return this._UpdatePassword;
			}
			set
			{
				if ((this._UpdatePassword != value))
				{
					this.OnUpdatePasswordChanging(value);
					this.SendPropertyChanging();
					this._UpdatePassword = value;
					this.SendPropertyChanged("UpdatePassword");
					this.OnUpdatePasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastIPAddress", DbType="NVarChar(50)")]
		public string LastIPAddress
		{
			get
			{
				return this._LastIPAddress;
			}
			set
			{
				if ((this._LastIPAddress != value))
				{
					this.OnLastIPAddressChanging(value);
					this.SendPropertyChanging();
					this._LastIPAddress = value;
					this.SendPropertyChanged("LastIPAddress");
					this.OnLastIPAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDeleted", DbType="Bit NOT NULL")]
		public bool IsDeleted
		{
			get
			{
				return this._IsDeleted;
			}
			set
			{
				if ((this._IsDeleted != value))
				{
					this.OnIsDeletedChanging(value);
					this.SendPropertyChanging();
					this._IsDeleted = value;
					this.SendPropertyChanged("IsDeleted");
					this.OnIsDeletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedByUserID", DbType="Int")]
		public System.Nullable<int> CreatedByUserID
		{
			get
			{
				return this._CreatedByUserID;
			}
			set
			{
				if ((this._CreatedByUserID != value))
				{
					this.OnCreatedByUserIDChanging(value);
					this.SendPropertyChanging();
					this._CreatedByUserID = value;
					this.SendPropertyChanged("CreatedByUserID");
					this.OnCreatedByUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOnDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOnDate
		{
			get
			{
				return this._CreatedOnDate;
			}
			set
			{
				if ((this._CreatedOnDate != value))
				{
					this.OnCreatedOnDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedOnDate = value;
					this.SendPropertyChanged("CreatedOnDate");
					this.OnCreatedOnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastModifiedByUserID", DbType="Int")]
		public System.Nullable<int> LastModifiedByUserID
		{
			get
			{
				return this._LastModifiedByUserID;
			}
			set
			{
				if ((this._LastModifiedByUserID != value))
				{
					this.OnLastModifiedByUserIDChanging(value);
					this.SendPropertyChanging();
					this._LastModifiedByUserID = value;
					this.SendPropertyChanged("LastModifiedByUserID");
					this.OnLastModifiedByUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastModifiedOnDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastModifiedOnDate
		{
			get
			{
				return this._LastModifiedOnDate;
			}
			set
			{
				if ((this._LastModifiedOnDate != value))
				{
					this.OnLastModifiedOnDateChanging(value);
					this.SendPropertyChanging();
					this._LastModifiedOnDate = value;
					this.SendPropertyChanged("LastModifiedOnDate");
					this.OnLastModifiedOnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordResetToken", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> PasswordResetToken
		{
			get
			{
				return this._PasswordResetToken;
			}
			set
			{
				if ((this._PasswordResetToken != value))
				{
					this.OnPasswordResetTokenChanging(value);
					this.SendPropertyChanging();
					this._PasswordResetToken = value;
					this.SendPropertyChanged("PasswordResetToken");
					this.OnPasswordResetTokenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordResetExpiration", DbType="DateTime")]
		public System.Nullable<System.DateTime> PasswordResetExpiration
		{
			get
			{
				return this._PasswordResetExpiration;
			}
			set
			{
				if ((this._PasswordResetExpiration != value))
				{
					this.OnPasswordResetExpirationChanging(value);
					this.SendPropertyChanging();
					this._PasswordResetExpiration = value;
					this.SendPropertyChanged("PasswordResetExpiration");
					this.OnPasswordResetExpirationChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserInfo")]
	public partial class UserInfo
	{
		
		private int _UserID;
		
		private string _Matkhau_User;
		
		private string _Nhom_User;
		
		private System.Nullable<int> _ID_Donvi;
		
		private string _Chucvu_User;
		
		private string _Phongban_User;
		
		private string _Ghichu_User;
		
		public UserInfo()
		{
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
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau_User", DbType="VarChar(50)")]
		public string Matkhau_User
		{
			get
			{
				return this._Matkhau_User;
			}
			set
			{
				if ((this._Matkhau_User != value))
				{
					this._Matkhau_User = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nhom_User", DbType="VarChar(50)")]
		public string Nhom_User
		{
			get
			{
				return this._Nhom_User;
			}
			set
			{
				if ((this._Nhom_User != value))
				{
					this._Nhom_User = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Donvi", DbType="Int")]
		public System.Nullable<int> ID_Donvi
		{
			get
			{
				return this._ID_Donvi;
			}
			set
			{
				if ((this._ID_Donvi != value))
				{
					this._ID_Donvi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chucvu_User", DbType="VarChar(100)")]
		public string Chucvu_User
		{
			get
			{
				return this._Chucvu_User;
			}
			set
			{
				if ((this._Chucvu_User != value))
				{
					this._Chucvu_User = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phongban_User", DbType="VarChar(100)")]
		public string Phongban_User
		{
			get
			{
				return this._Phongban_User;
			}
			set
			{
				if ((this._Phongban_User != value))
				{
					this._Phongban_User = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ghichu_User", DbType="VarChar(1000)")]
		public string Ghichu_User
		{
			get
			{
				return this._Ghichu_User;
			}
			set
			{
				if ((this._Ghichu_User != value))
				{
					this._Ghichu_User = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
