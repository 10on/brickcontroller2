﻿using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace BrickController2.CreationManagement
{
    public class Creation
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ControllerProfile> ControllerProfiles { get; set; }
    }
}