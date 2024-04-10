using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Konyv.models
{
    public class models_class
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }


        public models_class(){ }

        public models_class(string title, string author, int year, int pages)
        {

            Title = title;
            Author = author;
            Year = year; 
            Pages = pages;

        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Pages: {Pages}");
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}, Pages: {Pages}";
        }

    }

}
