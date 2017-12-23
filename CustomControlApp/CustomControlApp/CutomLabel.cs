﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomControlApp
{
    public class CustomLabel : Label
    {
        public static readonly BindableProperty CurvedCornerRadiusProperty =

              BindableProperty.Create(

                  nameof(CurvedCornerRadius),

                  typeof(double),

                  typeof(CustomLabel),

                  12.0);

        public double CurvedCornerRadius

        {

            get { return (double)GetValue(CurvedCornerRadiusProperty); }

            set { SetValue(CurvedCornerRadiusProperty, value); }

        }





        public static readonly BindableProperty CurvedBackgroundColorProperty =

            BindableProperty.Create(

                nameof(CurvedCornerRadius),

                typeof(Color),

                typeof(CustomLabel),

                Color.Default);

        public Color CurvedBackgroundColor

        {

            get { return (Color)GetValue(CurvedBackgroundColorProperty); }

            set { SetValue(CurvedBackgroundColorProperty, value); }

        }

    }
}
