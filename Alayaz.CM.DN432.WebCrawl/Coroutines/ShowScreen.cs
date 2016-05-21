﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
 using System.ComponentModel.Composition;

namespace Alayaz.CM.DN432.WebCrawl.Coroutines
{
    public class ShowScreen : IResult
    {
        readonly Type screenType;
        readonly string name;

        [Import]
        public IShell Shell { get; set; }

        public ShowScreen(string name)
        {
            this.name = name;
        }

        public ShowScreen(Type screenType)
        {
            this.screenType = screenType;
        }

        public void Execute(CoroutineExecutionContext context)
        {
            var screen = !string.IsNullOrEmpty(name)
                ? IoC.Get<object>(name)
                : IoC.GetInstance(screenType, null);

            Shell.ActivateItem(screen);
            Completed(this, new ResultCompletionEventArgs());
        }

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };

        public static ShowScreen Of<T>()
        {
            return new ShowScreen(typeof(T));
        }
    }

}
