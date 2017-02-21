using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblemSolvingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Imagine you are the frog in a new frogger game.  Assume this game is similar to the original frogger games but they added an additional aspect where the frog has a limited amount of energy.
You gain energy by eating insects and lose energy by moving.

Given an array containing positive and negative numbers. The array represents lanes from one end to other end of street that you must cross. 
Positive and negative values represent amount of energy change that will occur to get to the next lane. Positive numbers increase the energy, 
indicating that you get more energy from eating insects in that lane than you will spend to get across. 
Negative numbers decrease the energy indicating that you will spend more energy crossing the lane than you will get from eating insects in that lane. 
Find the minimum initial energy required to cross the street such that Energy level is never less than 0 indicating you will not be able to move and get crushed by the cars.


Examples:

Input : arr[] = {4, -10, 4, 4, 4}
Output: 6
Suppose initially we have energy = 0, now at 1st
checkpoint, we get 4. At 2nd checkpoint, energy gets
reduced by -10 so we have 4 + (-10) = -6 but at any 
checkpoint value of energy can not less than equals 
to 0. So initial energy must be at least 6 because
having 6 as initial energy value at 1st checkpoint
our energy will be = 6+4 = 10 and then we can cross 
2nd checkpoint successfully. Now after 2nd checkpoint,
all checkpoint have positive value so we can cross 
street successfully with 6 initial energy.

Input : arr[] = {3, 5, 2, 6, 1}
Output: 0

Input : arr[] = {-1, -5, -9}
Output: 15
*/

// find the starting point 
        }
    }
}
