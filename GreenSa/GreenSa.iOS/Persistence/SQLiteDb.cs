﻿using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using GreenSa.iOS.Persistence;
using GreenSa.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace GreenSa.iOS.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}
