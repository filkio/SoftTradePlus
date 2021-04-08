using System;
using System.Collections.Generic;
using System.Text;
using SoftTradePlus.DI;

namespace SoftTradePlus.Bll
{
    public class Manager : IManager
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
