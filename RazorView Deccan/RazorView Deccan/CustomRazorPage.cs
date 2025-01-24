using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace RazorViewDeccan
{

    public abstract class CustomRazorPage<TModel> : RazorPage<TModel>
    {
        public string CustomText { get; } = "This is Custom Text";
    }
     public interface IMath
    {
        int add(int a, int b);

    }
    public class Math: IMath
    {
        public int add(int a ,int b)
        {
            return a + b;
        }
    }
}
