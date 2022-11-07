﻿using Project.Data.Dao;
using Project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Project.Data.Impl
{
    public class OrderDaoImpl : OrderDao
    {
        private DBDataContext db;
        public OrderDaoImpl()
        {
            db = new DBDataContext(Constants.DB_CONNECT_STRING);
        }

        public int count()
        {
            var query = from order in db.GetTable<Order>() select order;
            List<Order> orderList = query.ToList<Order>();
            return orderList.Count();
        }

        public void deleteById(int id)
        {
            Order find = db.Orders.Single(us => us.Id == id);
            db.Orders.DeleteOnSubmit(find);
            db.SubmitChanges();
        }

        public List<Order> findAll()
        {
            var all = from order in db.GetTable<Order>() select order;
            var orderList = all.ToList();
            return orderList;
        }

        public Order findById(int id)
        {
            return db.Orders.Single(us => us.Id == id);
        }

        public void insert(Order order)
        {
            db.Orders.InsertOnSubmit(order);
            db.SubmitChanges();
        }

        public void update(Order order)
        {
            Order find = db.Orders.Single(us => us.Id == order.Id);
            find.UserId = order.UserId;
            find.Code = order.Code;
            find.Status = order.Status;
            db.SubmitChanges();
        }
    }
}
