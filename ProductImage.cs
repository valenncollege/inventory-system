using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory_System
{
    [Serializable]
    public class ProductImage
    {
        private string id;
        private string fileName;

        public string Id { get => id; set => id = value; }
        public string FileName { get => fileName; set => fileName = value; }

        public ProductImage(string pId, string pFileName)
        {
            this.Id = pId;
            this.FileName = pFileName;
        }
    }
}