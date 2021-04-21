using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetManagement
{
    //3Assets information
    public class AssetInformation
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public int Year{get;set;}
    }
}

