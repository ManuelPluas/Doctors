﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Doctors.Infraestructure
{
    using ViewsModels;
    
    class InstanceLocator
    {
        #region properties
        public MainViewModel Main
        { get; set; }

        #endregion

        #region constructores
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
