using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UserApp.Models;

namespace UserApp.Models
{
    public class UserAppRepository
    {
        private readonly UserContext context;
        public UserAppRepository(UserContext context)
        {
            this.context = context;
        }

        //выбрать все записи из таблицы Articles
        public IQueryable<User> GetUsers()
        {
            return context.Users.OrderBy(x => x.Name);
        }
       
        //найти определенную запись по id
        public User GetUserById(Guid id)
        {            
            return context.Users.Single(x => x.Id == id);
        }

        //сохранить новую либо обновить существующую запись в БД
        public Guid SaveUser(User entity)
        {
            //   if (entity.Id == default)
          
                context.Entry(entity).State = EntityState.Added;
          

            context.SaveChanges();
            return entity.Id;
        }
        public Guid UpdateUser(User entity)
        {
            //   if (entity.Id == default)
            context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
            return entity.Id;
        }
        //удалить существующую запись
        public Guid DeleteUser(User entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
            return entity.Id;
        }
        public Guid DeleteRole(UserRole entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
            return entity.Id;
        }
        public UserRole GetRoleById(Guid id)
        {
            return context.UserRoles.Single(x => x.Id == id);
        }

        //сохранить новую либо обновить существующую запись в БД
        public Guid SaveRole(UserRole entity)
        {
            //   if (entity.Id == default)
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
            return entity.Id;
        }
    }
}
