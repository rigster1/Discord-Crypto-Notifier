using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using LiteDB;

namespace Database
{
    public class UserService
    {
        private static readonly LiteDatabase Db = new LiteDatabase(@"..\..\..\..\Database\userDb.json");

        
        public static bool Insert(User user)
        {
            try
            {
                var userCollection = Db.GetCollection<User>("Employee");
                return userCollection.Insert(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static List<User> Find()
        {
            try
            {
                var userCollection = Db.GetCollection<User>("Employee");
                return userCollection.FindAll().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        
        public static User FindById(long userId)
        {
            try
            {
                var userCollection = Db.GetCollection<User>("Employee");
                return userCollection.FindOne(x => x.UserId == userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public static bool FindByIdAndUpdate(long userId, User user)
        {
            try
            {
                var userCollection = Db.GetCollection<User>("Employee");
                return userCollection.Update(userId, user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}