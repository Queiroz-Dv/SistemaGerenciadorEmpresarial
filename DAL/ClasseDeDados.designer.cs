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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GerenciadorEmpresarial")]
	public partial class ClasseDeDadosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAUTORIZACAO(AUTORIZACAO instance);
    partial void UpdateAUTORIZACAO(AUTORIZACAO instance);
    partial void DeleteAUTORIZACAO(AUTORIZACAO instance);
    partial void InsertAUTORIZACAOESTADO(AUTORIZACAOESTADO instance);
    partial void UpdateAUTORIZACAOESTADO(AUTORIZACAOESTADO instance);
    partial void DeleteAUTORIZACAOESTADO(AUTORIZACAOESTADO instance);
    partial void InsertCARGO(CARGO instance);
    partial void UpdateCARGO(CARGO instance);
    partial void DeleteCARGO(CARGO instance);
    partial void InsertCOLABORADOR(COLABORADOR instance);
    partial void UpdateCOLABORADOR(COLABORADOR instance);
    partial void DeleteCOLABORADOR(COLABORADOR instance);
    partial void InsertDEPARTAMENTO(DEPARTAMENTO instance);
    partial void UpdateDEPARTAMENTO(DEPARTAMENTO instance);
    partial void DeleteDEPARTAMENTO(DEPARTAMENTO instance);
    partial void InsertMESES(MESES instance);
    partial void UpdateMESES(MESES instance);
    partial void DeleteMESES(MESES instance);
    partial void InsertSALARIO(SALARIO instance);
    partial void UpdateSALARIO(SALARIO instance);
    partial void DeleteSALARIO(SALARIO instance);
    partial void InsertTAREFAS(TAREFAS instance);
    partial void UpdateTAREFAS(TAREFAS instance);
    partial void DeleteTAREFAS(TAREFAS instance);
    partial void InsertTAREFASESTADO(TAREFASESTADO instance);
    partial void UpdateTAREFASESTADO(TAREFASESTADO instance);
    partial void DeleteTAREFASESTADO(TAREFASESTADO instance);
    #endregion
		
		public ClasseDeDadosDataContext() : 
				base(global::DAL.Properties.Settings.Default.GerenciadorEmpresarialConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ClasseDeDadosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClasseDeDadosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClasseDeDadosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClasseDeDadosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AUTORIZACAO> AUTORIZACAO
		{
			get
			{
				return this.GetTable<AUTORIZACAO>();
			}
		}
		
		public System.Data.Linq.Table<AUTORIZACAOESTADO> AUTORIZACAOESTADO
		{
			get
			{
				return this.GetTable<AUTORIZACAOESTADO>();
			}
		}
		
		public System.Data.Linq.Table<CARGO> CARGO
		{
			get
			{
				return this.GetTable<CARGO>();
			}
		}
		
		public System.Data.Linq.Table<COLABORADOR> COLABORADOR
		{
			get
			{
				return this.GetTable<COLABORADOR>();
			}
		}
		
		public System.Data.Linq.Table<DEPARTAMENTO> DEPARTAMENTO
		{
			get
			{
				return this.GetTable<DEPARTAMENTO>();
			}
		}
		
		public System.Data.Linq.Table<MESES> MESES
		{
			get
			{
				return this.GetTable<MESES>();
			}
		}
		
		public System.Data.Linq.Table<SALARIO> SALARIO
		{
			get
			{
				return this.GetTable<SALARIO>();
			}
		}
		
		public System.Data.Linq.Table<TAREFAS> TAREFAS
		{
			get
			{
				return this.GetTable<TAREFAS>();
			}
		}
		
		public System.Data.Linq.Table<TAREFASESTADO> TAREFASESTADO
		{
			get
			{
				return this.GetTable<TAREFASESTADO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AUTORIZACAO")]
	public partial class AUTORIZACAO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AutorizacaoID;
		
		private int _ColaboradorID;
		
		private System.DateTime _AutorizacaoDataInicial;
		
		private System.DateTime _AutorizacaoDataFinal;
		
		private int _AutorizacaoEstado;
		
		private string _AutorizacaoDescricao;
		
		private int _AutorizacaoDia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAutorizacaoIDChanging(int value);
    partial void OnAutorizacaoIDChanged();
    partial void OnColaboradorIDChanging(int value);
    partial void OnColaboradorIDChanged();
    partial void OnAutorizacaoDataInicialChanging(System.DateTime value);
    partial void OnAutorizacaoDataInicialChanged();
    partial void OnAutorizacaoDataFinalChanging(System.DateTime value);
    partial void OnAutorizacaoDataFinalChanged();
    partial void OnAutorizacaoEstadoChanging(int value);
    partial void OnAutorizacaoEstadoChanged();
    partial void OnAutorizacaoDescricaoChanging(string value);
    partial void OnAutorizacaoDescricaoChanged();
    partial void OnAutorizacaoDiaChanging(int value);
    partial void OnAutorizacaoDiaChanged();
    #endregion
		
		public AUTORIZACAO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AutorizacaoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AutorizacaoID
		{
			get
			{
				return this._AutorizacaoID;
			}
			set
			{
				if ((this._AutorizacaoID != value))
				{
					this.OnAutorizacaoIDChanging(value);
					this.SendPropertyChanging();
					this._AutorizacaoID = value;
					this.SendPropertyChanged("AutorizacaoID");
					this.OnAutorizacaoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColaboradorID", DbType="Int NOT NULL")]
		public int ColaboradorID
		{
			get
			{
				return this._ColaboradorID;
			}
			set
			{
				if ((this._ColaboradorID != value))
				{
					this.OnColaboradorIDChanging(value);
					this.SendPropertyChanging();
					this._ColaboradorID = value;
					this.SendPropertyChanged("ColaboradorID");
					this.OnColaboradorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AutorizacaoDataInicial", DbType="Date NOT NULL")]
		public System.DateTime AutorizacaoDataInicial
		{
			get
			{
				return this._AutorizacaoDataInicial;
			}
			set
			{
				if ((this._AutorizacaoDataInicial != value))
				{
					this.OnAutorizacaoDataInicialChanging(value);
					this.SendPropertyChanging();
					this._AutorizacaoDataInicial = value;
					this.SendPropertyChanged("AutorizacaoDataInicial");
					this.OnAutorizacaoDataInicialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AutorizacaoDataFinal", DbType="Date NOT NULL")]
		public System.DateTime AutorizacaoDataFinal
		{
			get
			{
				return this._AutorizacaoDataFinal;
			}
			set
			{
				if ((this._AutorizacaoDataFinal != value))
				{
					this.OnAutorizacaoDataFinalChanging(value);
					this.SendPropertyChanging();
					this._AutorizacaoDataFinal = value;
					this.SendPropertyChanged("AutorizacaoDataFinal");
					this.OnAutorizacaoDataFinalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AutorizacaoEstado", DbType="Int NOT NULL")]
		public int AutorizacaoEstado
		{
			get
			{
				return this._AutorizacaoEstado;
			}
			set
			{
				if ((this._AutorizacaoEstado != value))
				{
					this.OnAutorizacaoEstadoChanging(value);
					this.SendPropertyChanging();
					this._AutorizacaoEstado = value;
					this.SendPropertyChanged("AutorizacaoEstado");
					this.OnAutorizacaoEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AutorizacaoDescricao", DbType="VarChar(MAX)")]
		public string AutorizacaoDescricao
		{
			get
			{
				return this._AutorizacaoDescricao;
			}
			set
			{
				if ((this._AutorizacaoDescricao != value))
				{
					this.OnAutorizacaoDescricaoChanging(value);
					this.SendPropertyChanging();
					this._AutorizacaoDescricao = value;
					this.SendPropertyChanged("AutorizacaoDescricao");
					this.OnAutorizacaoDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AutorizacaoDia", DbType="Int NOT NULL")]
		public int AutorizacaoDia
		{
			get
			{
				return this._AutorizacaoDia;
			}
			set
			{
				if ((this._AutorizacaoDia != value))
				{
					this.OnAutorizacaoDiaChanging(value);
					this.SendPropertyChanging();
					this._AutorizacaoDia = value;
					this.SendPropertyChanged("AutorizacaoDia");
					this.OnAutorizacaoDiaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AUTORIZACAOESTADO")]
	public partial class AUTORIZACAOESTADO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EstadoID;
		
		private string _EstadoNome;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEstadoIDChanging(int value);
    partial void OnEstadoIDChanged();
    partial void OnEstadoNomeChanging(string value);
    partial void OnEstadoNomeChanged();
    #endregion
		
		public AUTORIZACAOESTADO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EstadoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EstadoID
		{
			get
			{
				return this._EstadoID;
			}
			set
			{
				if ((this._EstadoID != value))
				{
					this.OnEstadoIDChanging(value);
					this.SendPropertyChanging();
					this._EstadoID = value;
					this.SendPropertyChanged("EstadoID");
					this.OnEstadoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EstadoNome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EstadoNome
		{
			get
			{
				return this._EstadoNome;
			}
			set
			{
				if ((this._EstadoNome != value))
				{
					this.OnEstadoNomeChanging(value);
					this.SendPropertyChanging();
					this._EstadoNome = value;
					this.SendPropertyChanged("EstadoNome");
					this.OnEstadoNomeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CARGO")]
	public partial class CARGO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CargoID;
		
		private string _CargoNome;
		
		private int _DepartamentoID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCargoIDChanging(int value);
    partial void OnCargoIDChanged();
    partial void OnCargoNomeChanging(string value);
    partial void OnCargoNomeChanged();
    partial void OnDepartamentoIDChanging(int value);
    partial void OnDepartamentoIDChanged();
    #endregion
		
		public CARGO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CargoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CargoID
		{
			get
			{
				return this._CargoID;
			}
			set
			{
				if ((this._CargoID != value))
				{
					this.OnCargoIDChanging(value);
					this.SendPropertyChanging();
					this._CargoID = value;
					this.SendPropertyChanged("CargoID");
					this.OnCargoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CargoNome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CargoNome
		{
			get
			{
				return this._CargoNome;
			}
			set
			{
				if ((this._CargoNome != value))
				{
					this.OnCargoNomeChanging(value);
					this.SendPropertyChanging();
					this._CargoNome = value;
					this.SendPropertyChanged("CargoNome");
					this.OnCargoNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartamentoID", DbType="Int NOT NULL")]
		public int DepartamentoID
		{
			get
			{
				return this._DepartamentoID;
			}
			set
			{
				if ((this._DepartamentoID != value))
				{
					this.OnDepartamentoIDChanging(value);
					this.SendPropertyChanging();
					this._DepartamentoID = value;
					this.SendPropertyChanged("DepartamentoID");
					this.OnDepartamentoIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.COLABORADOR")]
	public partial class COLABORADOR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ColaboradorID;
		
		private int _NumeroUsuario;
		
		private string _Nome;
		
		private string _Sobrenome;
		
		private string _CaminhoImagem;
		
		private int _DepartamentoID;
		
		private int _CargoID;
		
		private int _Salario;
		
		private System.Nullable<System.DateTime> _DtNascimento;
		
		private string _Endereco;
		
		private string _Senha;
		
		private System.Nullable<bool> _isAdmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnColaboradorIDChanging(int value);
    partial void OnColaboradorIDChanged();
    partial void OnNumeroUsuarioChanging(int value);
    partial void OnNumeroUsuarioChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnSobrenomeChanging(string value);
    partial void OnSobrenomeChanged();
    partial void OnCaminhoImagemChanging(string value);
    partial void OnCaminhoImagemChanged();
    partial void OnDepartamentoIDChanging(int value);
    partial void OnDepartamentoIDChanged();
    partial void OnCargoIDChanging(int value);
    partial void OnCargoIDChanged();
    partial void OnSalarioChanging(int value);
    partial void OnSalarioChanged();
    partial void OnDtNascimentoChanging(System.Nullable<System.DateTime> value);
    partial void OnDtNascimentoChanged();
    partial void OnEnderecoChanging(string value);
    partial void OnEnderecoChanged();
    partial void OnSenhaChanging(string value);
    partial void OnSenhaChanged();
    partial void OnisAdminChanging(System.Nullable<bool> value);
    partial void OnisAdminChanged();
    #endregion
		
		public COLABORADOR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColaboradorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ColaboradorID
		{
			get
			{
				return this._ColaboradorID;
			}
			set
			{
				if ((this._ColaboradorID != value))
				{
					this.OnColaboradorIDChanging(value);
					this.SendPropertyChanging();
					this._ColaboradorID = value;
					this.SendPropertyChanged("ColaboradorID");
					this.OnColaboradorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroUsuario", DbType="Int NOT NULL")]
		public int NumeroUsuario
		{
			get
			{
				return this._NumeroUsuario;
			}
			set
			{
				if ((this._NumeroUsuario != value))
				{
					this.OnNumeroUsuarioChanging(value);
					this.SendPropertyChanging();
					this._NumeroUsuario = value;
					this.SendPropertyChanged("NumeroUsuario");
					this.OnNumeroUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sobrenome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Sobrenome
		{
			get
			{
				return this._Sobrenome;
			}
			set
			{
				if ((this._Sobrenome != value))
				{
					this.OnSobrenomeChanging(value);
					this.SendPropertyChanging();
					this._Sobrenome = value;
					this.SendPropertyChanged("Sobrenome");
					this.OnSobrenomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CaminhoImagem", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CaminhoImagem
		{
			get
			{
				return this._CaminhoImagem;
			}
			set
			{
				if ((this._CaminhoImagem != value))
				{
					this.OnCaminhoImagemChanging(value);
					this.SendPropertyChanging();
					this._CaminhoImagem = value;
					this.SendPropertyChanged("CaminhoImagem");
					this.OnCaminhoImagemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartamentoID", DbType="Int NOT NULL")]
		public int DepartamentoID
		{
			get
			{
				return this._DepartamentoID;
			}
			set
			{
				if ((this._DepartamentoID != value))
				{
					this.OnDepartamentoIDChanging(value);
					this.SendPropertyChanging();
					this._DepartamentoID = value;
					this.SendPropertyChanged("DepartamentoID");
					this.OnDepartamentoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CargoID", DbType="Int NOT NULL")]
		public int CargoID
		{
			get
			{
				return this._CargoID;
			}
			set
			{
				if ((this._CargoID != value))
				{
					this.OnCargoIDChanging(value);
					this.SendPropertyChanging();
					this._CargoID = value;
					this.SendPropertyChanged("CargoID");
					this.OnCargoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salario", DbType="Int NOT NULL")]
		public int Salario
		{
			get
			{
				return this._Salario;
			}
			set
			{
				if ((this._Salario != value))
				{
					this.OnSalarioChanging(value);
					this.SendPropertyChanging();
					this._Salario = value;
					this.SendPropertyChanged("Salario");
					this.OnSalarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DtNascimento", DbType="Date")]
		public System.Nullable<System.DateTime> DtNascimento
		{
			get
			{
				return this._DtNascimento;
			}
			set
			{
				if ((this._DtNascimento != value))
				{
					this.OnDtNascimentoChanging(value);
					this.SendPropertyChanging();
					this._DtNascimento = value;
					this.SendPropertyChanged("DtNascimento");
					this.OnDtNascimentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Endereco", DbType="VarChar(MAX)")]
		public string Endereco
		{
			get
			{
				return this._Endereco;
			}
			set
			{
				if ((this._Endereco != value))
				{
					this.OnEnderecoChanging(value);
					this.SendPropertyChanging();
					this._Endereco = value;
					this.SendPropertyChanged("Endereco");
					this.OnEnderecoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Senha", DbType="VarChar(20)")]
		public string Senha
		{
			get
			{
				return this._Senha;
			}
			set
			{
				if ((this._Senha != value))
				{
					this.OnSenhaChanging(value);
					this.SendPropertyChanging();
					this._Senha = value;
					this.SendPropertyChanged("Senha");
					this.OnSenhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAdmin", DbType="Bit")]
		public System.Nullable<bool> isAdmin
		{
			get
			{
				return this._isAdmin;
			}
			set
			{
				if ((this._isAdmin != value))
				{
					this.OnisAdminChanging(value);
					this.SendPropertyChanging();
					this._isAdmin = value;
					this.SendPropertyChanged("isAdmin");
					this.OnisAdminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DEPARTAMENTO")]
	public partial class DEPARTAMENTO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DepartamentoID;
		
		private string _DepartamentoNome;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepartamentoIDChanging(int value);
    partial void OnDepartamentoIDChanged();
    partial void OnDepartamentoNomeChanging(string value);
    partial void OnDepartamentoNomeChanged();
    #endregion
		
		public DEPARTAMENTO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartamentoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DepartamentoID
		{
			get
			{
				return this._DepartamentoID;
			}
			set
			{
				if ((this._DepartamentoID != value))
				{
					this.OnDepartamentoIDChanging(value);
					this.SendPropertyChanging();
					this._DepartamentoID = value;
					this.SendPropertyChanged("DepartamentoID");
					this.OnDepartamentoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartamentoNome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DepartamentoNome
		{
			get
			{
				return this._DepartamentoNome;
			}
			set
			{
				if ((this._DepartamentoNome != value))
				{
					this.OnDepartamentoNomeChanging(value);
					this.SendPropertyChanging();
					this._DepartamentoNome = value;
					this.SendPropertyChanged("DepartamentoNome");
					this.OnDepartamentoNomeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MESES")]
	public partial class MESES : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MesesID;
		
		private string _MesNome;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMesesIDChanging(int value);
    partial void OnMesesIDChanged();
    partial void OnMesNomeChanging(string value);
    partial void OnMesNomeChanged();
    #endregion
		
		public MESES()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MesesID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MesesID
		{
			get
			{
				return this._MesesID;
			}
			set
			{
				if ((this._MesesID != value))
				{
					this.OnMesesIDChanging(value);
					this.SendPropertyChanging();
					this._MesesID = value;
					this.SendPropertyChanged("MesesID");
					this.OnMesesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MesNome", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MesNome
		{
			get
			{
				return this._MesNome;
			}
			set
			{
				if ((this._MesNome != value))
				{
					this.OnMesNomeChanging(value);
					this.SendPropertyChanging();
					this._MesNome = value;
					this.SendPropertyChanged("MesNome");
					this.OnMesNomeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SALARIO")]
	public partial class SALARIO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SalarioID;
		
		private int _ColaboradorID;
		
		private int _Quantidade;
		
		private int _Ano;
		
		private int _MesID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSalarioIDChanging(int value);
    partial void OnSalarioIDChanged();
    partial void OnColaboradorIDChanging(int value);
    partial void OnColaboradorIDChanged();
    partial void OnQuantidadeChanging(int value);
    partial void OnQuantidadeChanged();
    partial void OnAnoChanging(int value);
    partial void OnAnoChanged();
    partial void OnMesIDChanging(int value);
    partial void OnMesIDChanged();
    #endregion
		
		public SALARIO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalarioID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SalarioID
		{
			get
			{
				return this._SalarioID;
			}
			set
			{
				if ((this._SalarioID != value))
				{
					this.OnSalarioIDChanging(value);
					this.SendPropertyChanging();
					this._SalarioID = value;
					this.SendPropertyChanged("SalarioID");
					this.OnSalarioIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColaboradorID", DbType="Int NOT NULL")]
		public int ColaboradorID
		{
			get
			{
				return this._ColaboradorID;
			}
			set
			{
				if ((this._ColaboradorID != value))
				{
					this.OnColaboradorIDChanging(value);
					this.SendPropertyChanging();
					this._ColaboradorID = value;
					this.SendPropertyChanged("ColaboradorID");
					this.OnColaboradorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantidade", DbType="Int NOT NULL")]
		public int Quantidade
		{
			get
			{
				return this._Quantidade;
			}
			set
			{
				if ((this._Quantidade != value))
				{
					this.OnQuantidadeChanging(value);
					this.SendPropertyChanging();
					this._Quantidade = value;
					this.SendPropertyChanged("Quantidade");
					this.OnQuantidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ano", DbType="Int NOT NULL")]
		public int Ano
		{
			get
			{
				return this._Ano;
			}
			set
			{
				if ((this._Ano != value))
				{
					this.OnAnoChanging(value);
					this.SendPropertyChanging();
					this._Ano = value;
					this.SendPropertyChanged("Ano");
					this.OnAnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MesID", DbType="Int NOT NULL")]
		public int MesID
		{
			get
			{
				return this._MesID;
			}
			set
			{
				if ((this._MesID != value))
				{
					this.OnMesIDChanging(value);
					this.SendPropertyChanging();
					this._MesID = value;
					this.SendPropertyChanged("MesID");
					this.OnMesIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAREFAS")]
	public partial class TAREFAS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TarefaID;
		
		private int _ColaboradorID;
		
		private string _TarefaTitulo;
		
		private string _TarefaConteudo;
		
		private System.Nullable<System.DateTime> _TarefaDataInicial;
		
		private System.Nullable<System.DateTime> _TarefaDataEntrega;
		
		private int _TarefaEstado;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTarefaIDChanging(int value);
    partial void OnTarefaIDChanged();
    partial void OnColaboradorIDChanging(int value);
    partial void OnColaboradorIDChanged();
    partial void OnTarefaTituloChanging(string value);
    partial void OnTarefaTituloChanged();
    partial void OnTarefaConteudoChanging(string value);
    partial void OnTarefaConteudoChanged();
    partial void OnTarefaDataInicialChanging(System.Nullable<System.DateTime> value);
    partial void OnTarefaDataInicialChanged();
    partial void OnTarefaDataEntregaChanging(System.Nullable<System.DateTime> value);
    partial void OnTarefaDataEntregaChanged();
    partial void OnTarefaEstadoChanging(int value);
    partial void OnTarefaEstadoChanged();
    #endregion
		
		public TAREFAS()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TarefaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TarefaID
		{
			get
			{
				return this._TarefaID;
			}
			set
			{
				if ((this._TarefaID != value))
				{
					this.OnTarefaIDChanging(value);
					this.SendPropertyChanging();
					this._TarefaID = value;
					this.SendPropertyChanged("TarefaID");
					this.OnTarefaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColaboradorID", DbType="Int NOT NULL")]
		public int ColaboradorID
		{
			get
			{
				return this._ColaboradorID;
			}
			set
			{
				if ((this._ColaboradorID != value))
				{
					this.OnColaboradorIDChanging(value);
					this.SendPropertyChanging();
					this._ColaboradorID = value;
					this.SendPropertyChanged("ColaboradorID");
					this.OnColaboradorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TarefaTitulo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TarefaTitulo
		{
			get
			{
				return this._TarefaTitulo;
			}
			set
			{
				if ((this._TarefaTitulo != value))
				{
					this.OnTarefaTituloChanging(value);
					this.SendPropertyChanging();
					this._TarefaTitulo = value;
					this.SendPropertyChanged("TarefaTitulo");
					this.OnTarefaTituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TarefaConteudo", DbType="VarChar(MAX)")]
		public string TarefaConteudo
		{
			get
			{
				return this._TarefaConteudo;
			}
			set
			{
				if ((this._TarefaConteudo != value))
				{
					this.OnTarefaConteudoChanging(value);
					this.SendPropertyChanging();
					this._TarefaConteudo = value;
					this.SendPropertyChanged("TarefaConteudo");
					this.OnTarefaConteudoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TarefaDataInicial", DbType="Date")]
		public System.Nullable<System.DateTime> TarefaDataInicial
		{
			get
			{
				return this._TarefaDataInicial;
			}
			set
			{
				if ((this._TarefaDataInicial != value))
				{
					this.OnTarefaDataInicialChanging(value);
					this.SendPropertyChanging();
					this._TarefaDataInicial = value;
					this.SendPropertyChanged("TarefaDataInicial");
					this.OnTarefaDataInicialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TarefaDataEntrega", DbType="Date")]
		public System.Nullable<System.DateTime> TarefaDataEntrega
		{
			get
			{
				return this._TarefaDataEntrega;
			}
			set
			{
				if ((this._TarefaDataEntrega != value))
				{
					this.OnTarefaDataEntregaChanging(value);
					this.SendPropertyChanging();
					this._TarefaDataEntrega = value;
					this.SendPropertyChanged("TarefaDataEntrega");
					this.OnTarefaDataEntregaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TarefaEstado", DbType="Int NOT NULL")]
		public int TarefaEstado
		{
			get
			{
				return this._TarefaEstado;
			}
			set
			{
				if ((this._TarefaEstado != value))
				{
					this.OnTarefaEstadoChanging(value);
					this.SendPropertyChanging();
					this._TarefaEstado = value;
					this.SendPropertyChanged("TarefaEstado");
					this.OnTarefaEstadoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAREFASESTADO")]
	public partial class TAREFASESTADO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TarefasEstadoID;
		
		private string _TarefasEstadoNome;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTarefasEstadoIDChanging(int value);
    partial void OnTarefasEstadoIDChanged();
    partial void OnTarefasEstadoNomeChanging(string value);
    partial void OnTarefasEstadoNomeChanged();
    #endregion
		
		public TAREFASESTADO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TarefasEstadoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TarefasEstadoID
		{
			get
			{
				return this._TarefasEstadoID;
			}
			set
			{
				if ((this._TarefasEstadoID != value))
				{
					this.OnTarefasEstadoIDChanging(value);
					this.SendPropertyChanging();
					this._TarefasEstadoID = value;
					this.SendPropertyChanged("TarefasEstadoID");
					this.OnTarefasEstadoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TarefasEstadoNome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TarefasEstadoNome
		{
			get
			{
				return this._TarefasEstadoNome;
			}
			set
			{
				if ((this._TarefasEstadoNome != value))
				{
					this.OnTarefasEstadoNomeChanging(value);
					this.SendPropertyChanging();
					this._TarefasEstadoNome = value;
					this.SendPropertyChanged("TarefasEstadoNome");
					this.OnTarefasEstadoNomeChanged();
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