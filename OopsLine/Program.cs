using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagePro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Employee Wage Program");
            //EmpCheck.EmpPresentOrNot();
            // CalculateEmpWage.CalEmpWage();
            // SwitchCalEmpWage.CalEmpWage();
            //  HourseCalEmpWage.CalHourse(); 
            // SnakeLadderProb.SimuLadder();
            //    SnakeLadderProb gm = new SnakeLadderProb();
            //  gm.SimuLadder()
            //   LineCompaProb.ComparisonProb();
            // DailyEmpWage.CalcuDaily();
            // SnakePlayer.PlayerSnake();
            // SnakePlayer player1 = new SnakePlayer();
            //SnakePlayer player2 = new SnakePlayer();

            LineCompaProb length1 = new LineCompaProb();
            LineCompaProb length2 = new LineCompaProb();

            double line1 = length1.ComparisonProb();

            double line2 = length1.ComparisonProb();


        }
    }
}
