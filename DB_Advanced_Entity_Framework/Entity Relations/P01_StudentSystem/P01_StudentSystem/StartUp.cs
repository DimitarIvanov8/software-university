﻿using P01_StudentSystem.Data;

namespace P01_StudentSystem
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var context = new StudentSystemContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
