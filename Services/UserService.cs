using Models.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly List<User> data;
        public UserService()
        {
            data = new List<User>();
            InitData();
        }

        public bool Creat(User data)
        {
            this.data.Add(data);
            return true;
        }

        public bool Delete(User data)
        {
            return this.data.Remove(data);
        }

        public IEnumerable<User> GetAll()
        {
            return this.data.ToArray();
        }

        public void InitData()
        {
            int count = 1;
            data.AddRange(new User[] {
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
                new User {ID = Guid.NewGuid(), AccName=$"User{count++}", Email=$"user{count}@email.com", Name=$"User Number {count++}", PhoneNumber="012356789", RegistryDate=DateTime.Now},
            });
        }

        public bool Update(User data)
        {
            var userObject = this.data.FirstOrDefault(d => d.ID == data.ID);
            var rs = this.data.Remove(userObject);
            this.data.Add(data);
            return rs;
        }
    }
}
