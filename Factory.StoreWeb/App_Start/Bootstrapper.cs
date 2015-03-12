using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Factory.StoreWeb.Mapping;

namespace Factory.StoreWeb
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            //Configure AutoMapper
            AutoMapperConfiguration.Configure();
        }
    }
}