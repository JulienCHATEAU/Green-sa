﻿using GreenSa.Models.Tools;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenSa.Models.GolfModel
{
    public class ScoreHole
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(Hole))]
        public string IdHole { get; set; }
        [OneToOne(CascadeOperations=CascadeOperation.All)]
        public Hole Hole { get; set; }
        public int Score { get; set; }
        public bool Hit { get; set; }
        public DateTime Date { get; set; }
        public ScoreHole()
        {

        }

        public ScoreHole(Hole hole, int score,bool hit,DateTime date)
        {
            this.Hole = hole;
            this.Score = score;
            this.Hit = hit;
            Date = date;
        }

        public override string ToString()
        {
            return "{ Hole "+Hole+" Score "+Score+" ("+(Hit?"Hit":"Miss")+") the "+Date;
        }


    }
}
