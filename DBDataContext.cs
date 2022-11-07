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

namespace DBDataContext
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


    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = "csdl")]
    public partial class DataClasses1DataContext : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        #region Extensibility Method Definitions
        partial void OnCreated();
        partial void InsertCategory(Category instance);
        partial void UpdateCategory(Category instance);
        partial void DeleteCategory(Category instance);
        partial void InsertOrder(Order instance);
        partial void UpdateOrder(Order instance);
        partial void DeleteOrder(Order instance);
        partial void InsertOrderDetail(OrderDetail instance);
        partial void UpdateOrderDetail(OrderDetail instance);
        partial void DeleteOrderDetail(OrderDetail instance);
        partial void InsertProduct(Product instance);
        partial void UpdateProduct(Product instance);
        partial void DeleteProduct(Product instance);
        partial void InsertUser(User instance);
        partial void UpdateUser(User instance);
        partial void DeleteUser(User instance);
        #endregion

        public DataClasses1DataContext(string connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public DataClasses1DataContext(System.Data.IDbConnection connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<Category> Categories
        {
            get
            {
                return this.GetTable<Category>();
            }
        }

        public System.Data.Linq.Table<Order> Orders
        {
            get
            {
                return this.GetTable<Order>();
            }
        }

        public System.Data.Linq.Table<OrderDetail> OrderDetails
        {
            get
            {
                return this.GetTable<OrderDetail>();
            }
        }

        public System.Data.Linq.Table<Product> Products
        {
            get
            {
                return this.GetTable<Product>();
            }
        }

        public System.Data.Linq.Table<User> Users
        {
            get
            {
                return this.GetTable<User>();
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Category")]
    public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _Name;

        private string _Description;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        #endregion

        public Category()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Description", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._Description = value;
                    this.SendPropertyChanged("Description");
                    this.OnDescriptionChanged();
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.[Order]")]
    public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _Status;

        private int _UserId;

        private EntityRef<User> _User;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        partial void OnUserIdChanging(int value);
        partial void OnUserIdChanged();
        #endregion

        public Order()
        {
            this._User = default(EntityRef<User>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Status", DbType = "NVarChar(10) NOT NULL", CanBeNull = false)]
        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if ((this._Status != value))
                {
                    this.OnStatusChanging(value);
                    this.SendPropertyChanging();
                    this._Status = value;
                    this.SendPropertyChanged("Status");
                    this.OnStatusChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_UserId", DbType = "Int NOT NULL")]
        public int UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                if ((this._UserId != value))
                {
                    if (this._User.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnUserIdChanging(value);
                    this.SendPropertyChanging();
                    this._UserId = value;
                    this.SendPropertyChanged("UserId");
                    this.OnUserIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "User_Order", Storage = "_User", ThisKey = "UserId", OtherKey = "Id", IsForeignKey = true)]
        public User User
        {
            get
            {
                return this._User.Entity;
            }
            set
            {
                User previousValue = this._User.Entity;
                if (((previousValue != value)
                            || (this._User.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._User.Entity = null;
                        previousValue.Orders.Remove(this);
                    }
                    this._User.Entity = value;
                    if ((value != null))
                    {
                        value.Orders.Add(this);
                        this._UserId = value.Id;
                    }
                    else
                    {
                        this._UserId = default(int);
                    }
                    this.SendPropertyChanged("User");
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.OrderDetail")]
    public partial class OrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private int _ProductId;

        private int _Quantity;

        private decimal _Price;

        private int _OrderId;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnProductIdChanging(int value);
        partial void OnProductIdChanged();
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        partial void OnOrderIdChanging(int value);
        partial void OnOrderIdChanged();
        #endregion

        public OrderDetail()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ProductId", DbType = "Int NOT NULL")]
        public int ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                if ((this._ProductId != value))
                {
                    this.OnProductIdChanging(value);
                    this.SendPropertyChanging();
                    this._ProductId = value;
                    this.SendPropertyChanged("ProductId");
                    this.OnProductIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Quantity", DbType = "Int NOT NULL")]
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                if ((this._Quantity != value))
                {
                    this.OnQuantityChanging(value);
                    this.SendPropertyChanging();
                    this._Quantity = value;
                    this.SendPropertyChanged("Quantity");
                    this.OnQuantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Price", DbType = "Decimal(8,0) NOT NULL")]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                if ((this._Price != value))
                {
                    this.OnPriceChanging(value);
                    this.SendPropertyChanging();
                    this._Price = value;
                    this.SendPropertyChanged("Price");
                    this.OnPriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_OrderId", DbType = "Int NOT NULL")]
        public int OrderId
        {
            get
            {
                return this._OrderId;
            }
            set
            {
                if ((this._OrderId != value))
                {
                    this.OnOrderIdChanging(value);
                    this.SendPropertyChanging();
                    this._OrderId = value;
                    this.SendPropertyChanged("OrderId");
                    this.OnOrderIdChanged();
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Product")]
    public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _Name;

        private int _Quantity;

        private decimal _Price;

        private int _CategoryId;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        partial void OnCategoryIdChanging(int value);
        partial void OnCategoryIdChanged();
        #endregion

        public Product()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(20) NOT NULL", CanBeNull = false)]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Quantity", DbType = "Int NOT NULL")]
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                if ((this._Quantity != value))
                {
                    this.OnQuantityChanging(value);
                    this.SendPropertyChanging();
                    this._Quantity = value;
                    this.SendPropertyChanged("Quantity");
                    this.OnQuantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Price", DbType = "Decimal(8,0) NOT NULL")]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                if ((this._Price != value))
                {
                    this.OnPriceChanging(value);
                    this.SendPropertyChanging();
                    this._Price = value;
                    this.SendPropertyChanged("Price");
                    this.OnPriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CategoryId", DbType = "Int NOT NULL")]
        public int CategoryId
        {
            get
            {
                return this._CategoryId;
            }
            set
            {
                if ((this._CategoryId != value))
                {
                    this.OnCategoryIdChanging(value);
                    this.SendPropertyChanging();
                    this._CategoryId = value;
                    this.SendPropertyChanged("CategoryId");
                    this.OnCategoryIdChanged();
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.[User]")]
    public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _Username;

        private string _Password;

        private EntitySet<Order> _Orders;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        #endregion

        public User()
        {
            this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Username", DbType = "NVarChar(11) NOT NULL", CanBeNull = false)]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Password", DbType = "NVarChar(10) NOT NULL", CanBeNull = false)]
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "User_Order", Storage = "_Orders", ThisKey = "Id", OtherKey = "UserId")]
        public EntitySet<Order> Orders
        {
            get
            {
                return this._Orders;
            }
            set
            {
                this._Orders.Assign(value);
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

        private void attach_Orders(Order entity)
        {
            this.SendPropertyChanging();
            entity.User = this;
        }

        private void detach_Orders(Order entity)
        {
            this.SendPropertyChanging();
            entity.User = null;
        }
    }
}
#pragma warning restore 1591
