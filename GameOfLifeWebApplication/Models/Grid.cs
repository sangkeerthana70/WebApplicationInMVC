﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfLifeWebApplication.Models
{
    public class Grid
    {
        public int[,] grid;
        public int generation = 0;

        public Grid(int rows, int columns)
        {
            this.grid = new int[rows, columns];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    this.grid[i, j] = 0;
                }
            }
        }


    }
}