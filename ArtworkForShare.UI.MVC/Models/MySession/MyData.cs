using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtworkForShare.UI.MVC.Models.MySession
{
    public class MyData
    {
        static private registerVM data = new registerVM();
        public registerVM GetData => data;
        public void UpdateData(registerVM input)
        {
            data = input;
        }
        public void DeleteData()
        {
            data = null;
        }
    }
}
