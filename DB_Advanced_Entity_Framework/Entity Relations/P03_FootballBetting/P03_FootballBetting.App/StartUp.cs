using System;
using P03_FootballBetting.Data;
using P03_FootballBetting.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace P03_FootballBetting.App
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new FootballBettingContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
