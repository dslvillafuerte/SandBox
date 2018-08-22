using System;
namespace SandBox.ViewModels
{
    using System.Collections.Generic;
    //using Models;

    public class MainViewModel
    {
        #region Properties
       
        #endregion

        #region ViewModels
        public MyFirstViewModel MyFirst
        {
            get;
            set;
        }

       
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.MyFirst = new MyFirstViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
