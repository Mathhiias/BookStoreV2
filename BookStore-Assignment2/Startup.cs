﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStore_Assignment2.Startup))]
namespace BookStore_Assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
