﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Download_Manager
{
    static class App
    {
        static Database db;
        public static Database Database
        {
            get
            {
                if (db == null)
                    db = new Database();
                return db;
            }
        }
    }
}
