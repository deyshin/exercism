﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
    class HelloWorld
    {

        public string Hello(string name)
        {
            return "Hello, " + ("World" ?? name) + "!";
        }
    }
}
