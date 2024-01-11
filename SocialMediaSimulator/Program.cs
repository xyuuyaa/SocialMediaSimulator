using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal class Program
    {
        
        public static IUser currentUser; // User der zurzeit verwendet wird
        static void Main(string[] args) // move whole console stuff to Simulator.cs at the end for tidying up
        {
            Simulator Start = new Simulator();
            Start.StartMenu();
        } 
    }
}