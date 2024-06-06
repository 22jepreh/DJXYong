using DJXYong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJXYong.Repository
{
    public class DatabaseSingleton
    {
        private static DJXYongDatabaseEntities instance;

        public static DJXYongDatabaseEntities getInstance()
        {
            if (instance == null)
            {
                instance = new DJXYongDatabaseEntities();
            }
            return instance;
        }
    }
}