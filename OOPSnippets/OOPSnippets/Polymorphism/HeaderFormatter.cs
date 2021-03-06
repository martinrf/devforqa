﻿using OOPSnippets.Polymorphism.Models;

namespace OOPSnippets.Polymorphism
{
    public class HeaderFormatter 
    {
        protected HeaderModel Entity { get; set; }

        public HeaderFormatter(HeaderModel model)
        {
            this.Entity = model;
        }

        public virtual string LineOne
        {
            get { return $"Price: {this.Entity.Price}"; }
        }

        public virtual string LineTwo
        {
            get { return $"Date: {this.Entity.Date}"; }
        }
    }
}