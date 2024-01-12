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
        static void Main(string[] args) 
        {
            Simulator Start = new Simulator();
            Start.StartMenu();
        } 
    }
}