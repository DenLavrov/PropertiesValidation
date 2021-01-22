﻿using System;
using System.Collections.Generic;
using System.Text;
using PropertiesValidation.Base;
using Xamarin.Forms.Sample.Helpers;

namespace Xamarin.Forms.Sample.BL.ViewModels
{
    public class BaseViewModel: Bindable, IValidatable
    {
        public DynamicValuesDictionary<string, bool> Validation { get; set; }

        public BaseViewModel()
        {
            ((IValidatable)this).Init();
        }

        protected bool Validate()
        {
            return ((IValidatable) this).ValidateAll();
        }
    }
}
