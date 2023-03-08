using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblemSolving.Easy
{
    public class ParkingSystem
    {
        private int[] _parkingSpaces;

        public ParkingSystem(int big, int medium, int small)
        {
            _parkingSpaces = new int[] { 0, big, medium, small };
        }

        public bool AddCar(int carType)
        {
            if (_parkingSpaces[carType] <= 0)
                return false;
            else
            {
                _parkingSpaces[carType]--;
                return true;
            }
        }
    }

    internal class P_1603
    {
    }
}
